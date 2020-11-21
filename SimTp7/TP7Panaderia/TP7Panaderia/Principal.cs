using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TP7Panaderia
{
    public partial class Principal : Form
    {
        //Servidores y Eventos del Sistema
        private LlegadaCliente llegadaCliente;
        private ColaAtencion colaAtencion;
        private FinAtencion finAtencionEmpleado1, finAtencionEmpleado2;
        private FinCoccion finCoccion;
        private InicioCoccion inicioCoccion;
        private Empleado empleado1, empleado2;
        private Horno horno;
        private int stock;
        private double cantClientes;
        private double cantClientesAtendidos;
        private double cantClientesPerdidos;
        private int stockInicial;
        private int stockMinimo;

        //Parametros de la corrida
        private double tiempoFinCorrida;
        private double filaAPartirDeDondeMostrar, filaHastaDondeMostrar;
        private int cantCompraA, cantCompraB;
        private double mediaLlegadas;
        private double tiempoAtenA, tiempoAtenB;
        private double h, relHMin, tiempoCoccionTempMax, T0;
        private double porcentajePromedioPerdidos;

        //Variables necesarias
        private Reloj relojSimulacion;
        Random rand = new Random((int)DateTime.Now.Ticks);

        public Principal()
        {
            InitializeComponent();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                SetLoading(true);

                this.tomarDatosPatalla();
                this.inicializarVariables();

                //Limpiar Grilla 
                dgvResultados.Rows.Clear();
                //Genero Evento Llegada Pedido 0
                llegadaCliente.simular(relojSimulacion, rand.NextDouble());

                //Imprimo fila 0
                if (this.filaAPartirDeDondeMostrar == 0 || radioCada10mil.Checked)
                {
                    this.dgvResultados.Rows.Add();
                    agregarEventoInicio();
                }

                //Bucle principal 
                simulacion();

                SetLoading(false);
            }
        }

        private void simulacion() {
            int fila = 0;
            while (relojSimulacion.getReloj() < tiempoFinCorrida)
            {
                fila++;
                Reloj firstEvent;

                if (stock > stockMinimo || Constantes.ESTADO_ENCENDIDO.Equals(horno.getEstado()))
                {
                    //Selecciono el siguiente evento
                    firstEvent = this.getFirstEvent(
                        this.llegadaCliente.getProximoTiempo(),
                        this.finAtencionEmpleado1.getProximoTiempo(),
                        this.finAtencionEmpleado2.getProximoTiempo(),
                        this.finCoccion.getProximoTiempo(),
                        this.inicioCoccion.getProximoTiempo());

                    //Cargo el reloj y genero una nueva fila
                    this.relojSimulacion.setReloj(firstEvent.getReloj());
                }
                else
                {
                    // En caso de no tener stock adelanto el proximo inicio de coccion
                    this.inicioCoccion.setHoraFin(this.relojSimulacion);
                    firstEvent = inicioCoccion.getProximoTiempo();
                }
                

                //Llegada Cliente
                if (this.llegadaCliente.getProximoTiempo().Equals(firstEvent))
                {
                    this.llegadaCliente.simular(this.relojSimulacion, this.rand.NextDouble());
                    cantClientes++;

                    Empleado empleadoLibre = getEmpleadoLibre(this.empleado1, this.empleado2);

                    if (empleadoLibre != null)
                    {
                        if (stock > 0)
                        {
                            //Actualizo stock
                            actualizarStockPorVenta(llegadaCliente.getCantProd());
                            generarDemoraAtencion(empleadoLibre.getId());
                        } else
                        {
                            cantClientesPerdidos++;
                        }
                    }
                    else {
                        ponerEnCola(llegadaCliente);
                    }

                    imprimirFila(llegadaCliente, fila);
                }
                else {
                    //Evento Fin S1
                    if (this.finAtencionEmpleado1.getProximoTiempo().Equals(firstEvent))
                    {
                        finAtencionEmpleado1.setHoraFin(new Reloj());

                        //si hay cola sacar de colar y calcular nueva demora DESCARGA
                        this.empleado1.setEstado(Constantes.ESTADO_LIBRE);
                        actualizarEstadoEmpleado(empleado1);

                        imprimirFila(finAtencionEmpleado1, fila);
                    }
                    //Evento Fin S2
                   else if (this.finAtencionEmpleado2.getProximoTiempo().Equals(firstEvent))
                    {
                        finAtencionEmpleado2.setHoraFin(new Reloj());

                        //si hay cola sacar de colar y calcular nueva demora 
                        this.empleado2.setEstado(Constantes.ESTADO_LIBRE);
                        actualizarEstadoEmpleado(empleado2);

                        imprimirFila(finAtencionEmpleado2, fila);
                    }
                    //Evento Fin Coccion
                    else if (this.finCoccion.getProximoTiempo().Equals(firstEvent))
                    {
                        finCoccion.setHoraFin(new Reloj());
                        finCoccion.setDemora(0);
                        //Le agrego al stock lo cocinado
                        actualizarStockFinCoccion();
                        //Genero proximo inicio de coccion
                        inicioCoccion.simular(relojSimulacion, 0);
                        imprimirFila(finCoccion, fila);
                    }
                    //Evento Inicio Coccion
                    else if (this.inicioCoccion.getProximoTiempo().Equals(firstEvent))
                    {
                        inicioCoccion.setHoraFin(new Reloj());
                        //Instancio horno con la cantidad
                        cargaHorno();
                        //Genero proximo fin de coccion
                        finCoccion.simular(relojSimulacion, horno.getCantidad());
                        imprimirFila(inicioCoccion, fila);
                    }
                }
            }
            this.txtCantClientesAtendidos.Text = formatearResultado(cantClientesAtendidos);
            this.txtCantClientes.Text = formatearResultado(cantClientes);
            this.txtCantClixHoraProm.Text = formatearResultado(cantClientes/(relojSimulacion.getReloj()/60));
            this.txtCantClientesPerdidos.Text = formatearResultado(cantClientesPerdidos);
            this.txtPorcenPerdidos.Text = formatearResultado((cantClientesPerdidos/ cantClientes)*100);
        }

        public static string formatearResultado(double value)
        {
            return Convert.ToString(Math.Round(value, 2));
        }

        public void actualizarStockPorVenta(int cantVenta)
        {
            if (stock - cantVenta > 0)
            {
                stock -= cantVenta;
            } else
            {
                stock = 0;
            }  
        }

        public void actualizarStockFinCoccion()
        {
            stock += horno.getCantidad();
            horno = new Horno();
        }

        public void cargaHorno()
        {
            if (stock > 0)
            {
                horno = new Horno(30);
            } else
            {
                horno = new Horno(45);
            }
        }

        private void ponerEnCola(LlegadaCliente lc)
        {
            colaAtencion.setCola(lc.getCliente());
        }

        public void generarDemoraAtencion(int id)
        {
            cantClientesAtendidos++;
            double rnd = this.rand.NextDouble();
            switch (id)
            {
                case 1:
                    this.finAtencionEmpleado1.simular(this.relojSimulacion, rnd);
                    break;
                case 2:
                    this.finAtencionEmpleado2.simular(this.relojSimulacion, rnd);
                    break;
            }
        }

        private void agregarEventoInicio()
        {
            dgvResultados.Rows[0].Cells["colFila"].Value = 0;
            dgvResultados.Rows[0].Cells["colEvento"].Value = Constantes.EVENTO_INICIO_SIM;
            dgvResultados.Rows[0].Cells["colReloj"].Value = relojSimulacion.getReloj();

            dgvResultados.Rows[0].Cells["colRndLlegada"].Value = llegadaCliente.getRandom();
            dgvResultados.Rows[0].Cells["colTiempoEntreLlegada"].Value = llegadaCliente.getTiempoEntreLlegada();
            dgvResultados.Rows[0].Cells["colProxLlegada"].Value = llegadaCliente.getProximoTiempo().getReloj();

            dgvResultados.Rows[0].Cells["colCola"].Value = "0";
            dgvResultados.Rows[0].Cells["colStock"].Value = stock;
            dgvResultados.Rows[0].Cells["colEstadoHorno"].Value = horno.getEstado();
            dgvResultados.Rows[0].Cells["colEstadoS1"].Value = empleado1.getEstado();
            dgvResultados.Rows[0].Cells["colEstadoS2"].Value = empleado2.getEstado();
        }

        public void imprimirFila(Evento evento, int fila)
        {
            if ((fila >= this.filaAPartirDeDondeMostrar && fila <= filaHastaDondeMostrar && !radioCada10mil.Checked)
                || (radioCada10mil.Checked && fila % 10000 == 0))
            {
                int i = this.dgvResultados.Rows.Add();
                agregarEventoAGrilla(i, evento, fila);
            }
        }

        private void agregarEventoAGrilla(int i, Evento evento, int fila) {

            //Console.WriteLine("Imprimiendo: " + fila);

            //Columnas que se muestran siempre
            dgvResultados.Rows[i].Cells["colFila"].Value = fila;
            dgvResultados.Rows[i].Cells["colEvento"].Value = concatenarId(evento);
            dgvResultados.Rows[i].Cells["colReloj"].Value = relojSimulacion.getReloj();
            dgvResultados.Rows[i].Cells["colCola"].Value = colaAtencion.getCola().Count();

            dgvResultados.Rows[i].Cells["colStock"].Value = stock;

            if (evento.getNombreEvento().Equals(Constantes.EVENTO_LLEGADA)) {
                dgvResultados.Rows[i].Cells["colRndLlegada"].Value = llegadaCliente.getRandom();
                dgvResultados.Rows[i].Cells["colTiempoEntreLlegada"].Value = llegadaCliente.getTiempoEntreLlegada();

                dgvResultados.Rows[i].Cells["colRndCantProducto"].Value = llegadaCliente.getRandomCant();
                dgvResultados.Rows[i].Cells["colcantProducto"].Value = llegadaCliente.getCantProd();
            }

            dgvResultados.Rows[i].Cells["colProxLlegada"].Value = llegadaCliente.getProximoTiempo().getReloj();

            dgvResultados.Rows[i].Cells["colEstadoHorno"].Value = horno.getEstado();
            if (inicioCoccion.getProximoTiempo().getReloj() != 0)
            {
                dgvResultados.Rows[i].Cells["colDemoraInicio"].Value = inicioCoccion.getDemora();
                dgvResultados.Rows[i].Cells["colProximoInicio"].Value = inicioCoccion.getProximoTiempo().getReloj();
            }
            if (finCoccion.getProximoTiempo().getReloj() != 0)
            {
                dgvResultados.Rows[i].Cells["colDemoraCoccion"].Value = finCoccion.getDemora();
                dgvResultados.Rows[i].Cells["colProximoFinCoccion"].Value = finCoccion.getProximoTiempo().getReloj();
            }
            dgvResultados.Rows[i].Cells["colCantClientesPerdidos"].Value = this.cantClientesPerdidos;
            //calPorcentajePerdidos(evento);
            dgvResultados.Rows[i].Cells["colPromPorcCliPerdidos"].Value = Math.Round(cantClientesPerdidos / cantClientes, 4) * 100 + "%";

            setColDemoraFinDescarga(finAtencionEmpleado1, 1, i);
            setColDemoraFinDescarga(finAtencionEmpleado2, 2, i);
        }

        private void setColDemoraFinDescarga(FinAtencion fd, int id, int i)
        {
            if (fd.getProximoTiempo().getReloj() > 0)
            {
                dgvResultados.Rows[i].Cells["colEstadoS" + id].Value = fd.getEmpleado().getEstado();
                dgvResultados.Rows[i].Cells["colRNDDemora" + id].Value = fd.getEmpleado().getRNDDemora();
                dgvResultados.Rows[i].Cells["colDemoraS" + id].Value = fd.getTiempoEntreLlegada();
                dgvResultados.Rows[i].Cells["colFinDescargaS" + id].Value = fd.getProximoTiempo().getReloj();
            }else {
                dgvResultados.Rows[i].Cells["colEstadoS" + id].Value = fd.getEmpleado().getEstado();
            }
        }

        public void calPorcentajePerdidos(Evento evento)
        {
            if (evento.getNombreEvento() == Constantes.EVENTO_LLEGADA)
            {
                porcentajePromedioPerdidos = 1 / cantClientes * ((porcentajePromedioPerdidos * (cantClientes - 1)) + cantClientesPerdidos / cantClientes);
            }
            else
            {
                porcentajePromedioPerdidos = 1 / cantClientes * (porcentajePromedioPerdidos* cantClientes + cantClientesPerdidos / cantClientes);
            }
        }

        private void actualizarEstadoEmpleado(Empleado s)
        {

            if (colaAtencion.getCola().Count != 0)
            {
                Empleado empleadoLibre = getEmpleadoLibre(this.empleado1, this.empleado2);

                if (empleadoLibre != null)
                {
                    Cliente clienteEnCola = colaAtencion.getCola().Dequeue();
                    // TODO ver que hacer con el cliente que saco de la cola
                    if (stock > 0)
                    {
                        //Actualizo stock
                        actualizarStockPorVenta(clienteEnCola.CantProductos);
                        generarDemoraAtencion(empleadoLibre.getId());
                    } else
                    {
                        cantClientesPerdidos++;
                    }
                }

            }
            else {
                switch (s.getId())
                {
                    case 1:
                        empleado1.setEstado(Constantes.ESTADO_LIBRE);
                        empleado1.setDemora(0);
                        empleado1.setFinAtencion(new Reloj());
                        break;
                    case 2:
                        empleado2.setEstado(Constantes.ESTADO_LIBRE);
                        empleado2.setDemora(0);
                        empleado2.setFinAtencion(new Reloj());
                        break;
                }
            }

        }

        private string concatenarId(Evento e)
        {
            string idPedido = "";
            if (e.getNombreEvento() == Constantes.EVENTO_LLEGADA)
            {
                idPedido = "-" + Convert.ToString(((LlegadaCliente)e).getCliente().Id);
            }
            return e.getNombreEvento() + idPedido;
        }

        public Reloj getFirstEvent(Reloj n1, Reloj n2, Reloj n3, Reloj n4, Reloj n5)
        {
            List<Reloj> list = new List<Reloj>();
            if (n1.getReloj() > 0.0)
                list.Add(n1);
            if (n2.getReloj() > 0.0)
                list.Add(n2);
            if (n3.getReloj() > 0.0)
                list.Add(n3);
            if (n4.getReloj() > 0.0)
                list.Add(n4);
            if (n5.getReloj() > 0.0)
                list.Add(n5);
            list.Sort();
            return list.FirstOrDefault<Reloj>();
        }

        private Empleado getEmpleadoLibre(Empleado s1, Empleado s2) {
            List<Empleado> list = new List<Empleado>();
            list.Add(s1);
            list.Add(s2);

            var results = list.Where(s => s.getEstado() == Constantes.ESTADO_LIBRE);
            return results.FirstOrDefault();
        }

        // VALIDACION
        private bool isValid()
        {
            return validarDatos() && esValidaLlegada();
        }

        private bool validarDatos()
        {
            foreach (Control con in this.Controls)
            {
                if (con is GroupBox)
                {
                    if (validarGroup((GroupBox)con) ==  false) {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool validarGroup(GroupBox grupo)
        {
            foreach (Control con in grupo.Controls)
            {
                if (con is NumericUpDown)
                {
                    if (Validaciones.estaVacio((NumericUpDown)con))//Valida que los campos no esten vacios
                    {
                        MessageBox.Show("Parametros no pueden estar vacio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        con.Focus();
                        return false;
                    }
                }
            }

            return true;
        }

        private bool esValidaLlegada()
        {
            int tipoCamionA = Convert.ToInt32(txtCantCompraA.Value);
            int tipoCamionB = Convert.ToInt32(txtCantCompraB.Value);
            if (tipoCamionA > tipoCamionB)
            {
                MessageBox.Show("Parametros Incorrectos, A no puede ser mayor a B", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtCantCompraA.Focus();
                return false;
            }
            return true;
        }

        // FIN VALIDACION


        public void tomarDatosPatalla()
        {
            this.tiempoFinCorrida = Convert.ToDouble(this.txtTiempoSim.Text);
            this.filaAPartirDeDondeMostrar = Convert.ToDouble(this.txtHsDesde.Text);
            this.filaHastaDondeMostrar = Convert.ToDouble(this.txtHsHasta.Text);
            this.cantCompraA = Convert.ToInt32(this.txtCantCompraA.Value);
            this.cantCompraB = Convert.ToInt32(this.txtCantCompraB.Value);
            this.h = Convert.ToDouble(this.txtHDescarga.Value);
            this.mediaLlegadas = Convert.ToDouble(this.textMediaLlegada.Value);
            this.tiempoAtenA = Convert.ToDouble(this.txtTiempoAtenA.Value);
            this.tiempoAtenB = Convert.ToDouble(this.txtTiempoAtenB.Value);
            this.T0 = Convert.ToDouble(this.txtT0.Value);
            this.tiempoCoccionTempMax = Convert.ToDouble(this.txtTiempoCoccionTempMax.Value);
            this.relHMin = Convert.ToDouble(this.txtRelHMin.Value);
            this.stockInicial = Convert.ToInt32(this.txtStockInicial.Value);
            this.stockMinimo = Convert.ToInt32(this.txtMinCocinar.Value);
        }

        public void inicializarVariables()
        {
            this.relojSimulacion = new Reloj();
            this.llegadaCliente = new LlegadaCliente(this.cantCompraA, this.cantCompraB, this.mediaLlegadas);
            this.colaAtencion = new ColaAtencion();
            this.stock = this.stockInicial;
            Cliente.id = -1;
            cantClientes = 0;
            cantClientesPerdidos = 0;
            cantClientesAtendidos = 0;
            porcentajePromedioPerdidos = 0;

            //empleados
            this.empleado1 = new Empleado(1);
            this.empleado2 = new Empleado(2);

            //finAtencion
            this.finAtencionEmpleado1 = new FinAtencion(this.empleado1, this.tiempoAtenA, this.tiempoAtenB);
            this.finAtencionEmpleado2 = new FinAtencion(this.empleado2, this.tiempoAtenA, this.tiempoAtenB);

            //Coccion
            this.finCoccion = new FinCoccion(this.h, this.relHMin, this.T0, this.tiempoCoccionTempMax);
            this.inicioCoccion = new InicioCoccion(45);
            inicioCoccion.simular(relojSimulacion, 0);

            //horno
            this.horno = new Horno();
        }

        private void SetLoading(bool displayLoader)
        {
            if (displayLoader)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                });
            }
            else
            {
                this.Invoke((MethodInvoker)delegate
                {
                   this.Cursor = System.Windows.Forms.Cursors.Default;
                });
            }
        }

        private void btnVerEcDif_Click(object sender, EventArgs e)
        {
            EcDiferencial ecd = new EcDiferencial();
            ecd.Show();
        }

    }
}
