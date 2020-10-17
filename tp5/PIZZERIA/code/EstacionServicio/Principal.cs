using EstacionServicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static Pizzeria.Estados;

namespace Pizzeria
{
    public partial class frm_principal : Form
    {
        //Servidores y Eventos del Sistema
        private LlegadaPedido llegadaPedido;
        private FinCoccionEmpleado finCoccionEmpleado1;
        private FinCoccionEmpleado finCoccionEmpleado2;
        private FinCoccionEmpleado finCoccionEmpleado3;
        private Delivery delivery;
        private FinDelivery finDelivery;
        private Empleado empleado1;
        private Empleado empleado2;
        private Empleado empleado3;
        private ColaPreparacion colaPreparacion;

        //Variables de Estadisticas
        private double ContVehiculosCombustibleIngresanAlSitema;
        private double ContVehiculosGasIngresanAlSitema;
        private double ContVehiculosCombustibleRechazados;
        private double ContVehiculosGasRechazados;
        private double ContVehiculosCombustibleAtendidos;
        private double ContVehiculosGasAtendidos;
        private double AcumTiempoEsperaVehiculosCombustible;
        private double AcumTiempoEsperaVehiculosGas;
        private double ContVehiConTiempoEsperaVehiculosCombustible;
        private double ContVehiConTiempoEsperaVehiculosGas;
        private double AcumTiempoOcioServidoresCombustible;
        private double AcumTiempoOcioServidoresGas;


        //Parametros de Llega
        private double mediaLlegadaPedidos;
        private double tiempoTopeGratis;
        private int tiempoTopeEspera;

        //Parametros de Finalizacion
        private double promSandwich;
        private double desvSandwich;
        private double desdePizza;
        private double hastaPizza;
        private double precioPizza;

        //Parametros de la corrida
        private double tiempoFinCorrida;
        private double tiempoAPartirDeDondeMostrar;
        private int cantidadDeEventosAMostrar;


        //Variables necesarias
        private double relojSimulacion;
        private _TipoTurno turno;
        private double dia;
        private int identificadorPedido;
        private int eventosYaSimuladosYMostrados;
        Random rand = new Random((int)DateTime.Now.Ticks);
        bool resul = true;
        TextBox invalido = null;

        public frm_principal()
        {
            InitializeComponent();
        }

        public double getFirstEvent(double n1, double n2, double n3, double n4, double n5)
        {
            List<double> list = new List<double>();
            if (n1 > 0.0)
                list.Add(n1);
            if (n2 > 0.0)
                list.Add(n2);
            if (n3 > 0.0)
                list.Add(n3);
            if (n4 > 0.0)
                list.Add(n4);
            if (n5 > 0.0)
                list.Add(n5);
            list.Sort();
            return list.FirstOrDefault<double>();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            reset();

            //Inicio Bloque Simulacion
            if (validarDatos())
            {
                this.tomarDatosPatalla();
                this.inicializarVariables();

                //Limpiar Grilla 
                dgvResultados.Rows.Clear();

                //Inicio de La Simulacion
                if (relojSimulacion == 0.00)//Calculos los primeros eventos
                {

                    llegadaPedido.simular(relojSimulacion, rand.NextDouble());//carga de llegada de pedido

                    if (tiempoAPartirDeDondeMostrar == 0.00 && eventosYaSimuladosYMostrados < cantidadDeEventosAMostrar)//Veo si tengo que graficar
                    {

                        int i = this.dgvResultados.Rows.Add();
                        this.agregarDatosAGrila(i, "Inicio Simulacion");
                        this.agregarEventoAGrilla(i, true, this.llegadaPedido, 0);

                        //this.agregarSurtidoresAGrilla(i);
                        this.agregarEventoAGrilla(i, false, this.finCoccionEmpleado1, this.finCoccionEmpleado1.getIdEmpleado());
                        this.agregarEventoAGrilla(i, false, this.finCoccionEmpleado2, this.finCoccionEmpleado2.getIdEmpleado());
                        this.agregarEventoAGrilla(i, false, this.finCoccionEmpleado3, this.finCoccionEmpleado3.getIdEmpleado());
                        this.eventosYaSimuladosYMostrados++;
                    }


                }

                int fila = 0;

                //Bucle principal de Simulacion
                while (relojSimulacion < tiempoFinCorrida)
                {
                    double firstEvent = this.getFirstEvent(this.llegadaPedido.getProximaLlegada(), this.finCoccionEmpleado1.getProximaLlegada(), this.finCoccionEmpleado2.getProximaLlegada(), this.finCoccionEmpleado3.getProximaLlegada(), this.finDelivery.getProximaLlegada());

                    setReloj(firstEvent);
                    
                    if (this.llegadaPedido.getProximaLlegada() == firstEvent)
                    {
                        fila = this.generarLlegadaPedido();

                        //hacer para los 3 empleados
                        if (this.empleado1.getEstado() == "Libre")
                        {
                            generarDemoraPedido(fila, 1, llegadaPedido);
                        }
                        else
                        {
                            // mandar a cola
                            ponerColaPedido(llegadaPedido);
                            agregarColaAGrilla(fila);

                            //repetir valores de fin de coccion
                            //pasar empleado correspondiente
                            repetirValoresDemora(empleado1, fila);
                            repetirValoresDemora(empleado2, fila);
                            repetirValoresDemora(empleado3, fila);
                        }

                        //if (this.empleado2.getEstado() == "Libre")
                        //{
                        //    this.generarDemoraEmpleado(this.finCoccionEmpleado1.getIdEmpleado(), llegadaPedido);
                        //}
                        //else
                        //{
                        //    this.generarDemoraEmpleado(this.finCoccionEmpleado1.getIdEmpleado(), llegadaPedido);
                        //}
                        //si estan todos ocupados mandar a cola 
                    }


                    else if (this.finCoccionEmpleado1.getProximaLlegada() == firstEvent) {


                        fila = agregarEventoFinCoccion();

                        finCoccionEmpleado1.setHoraFin(0);
                        relojSimulacion = llegadaPedido.getProximaLlegada();

                        //actualizar el pedido a preparado 
                        cambiarEstadoPedido(llegadaPedido.getPedido());
                        //liberar el empleado si no hay cola
                        //si hay cola sacar de colar y calcular nueva demora 
                        actualizarEstadoEmpleado(empleado1, fila);
                        // hacer la parte del delivery
                        if (this.delivery.getEstado() == "Libre")
                        {
                            //aca me quede controlar bien xq se armo el bucle
                            //this.generarDemoraDelivery(fila, relojSimulacion ,1 , finCoccionEmpleado1);
                            // despues de esto actualizar el reloj
                        }
                    }

                    //hacer para otros empleados



                }

            }
            else
            {
                indicarErrorYPonerFocus();
                resul = true;
            }

            //Fin Bloque Simulacion
        }

        public void setReloj(double firstEvent)
        {
            this.relojSimulacion = firstEvent;
        }

        private void generarDemoraDelivery(int fila, double reloj ,int idDelivery, FinCoccionEmpleado fc)
        {
            // fijarse en la cola si hay pedidos 
            //puede solo cargar tres pedidos 

            Random r = new Random();
            this.finDelivery.simular(reloj, r.NextDouble());
            this.agregarDemoraEnGrillaDelivery(fila, true, finDelivery);

        }

        private void agregarDemoraEnGrillaDelivery( int i, bool conRandom, Evento evento)
        {
            dgvResultados.Rows[i].Cells["colEstadoMoto"].Value = "Libre";
            dgvResultados.Rows[i].Cells["colRndDelivery"].Value = "-";
            dgvResultados.Rows[i].Cells["colTiempoEntrega"].Value = "-";
            dgvResultados.Rows[i].Cells["colFinEntregaDelivery"].Value = "-";

            if (conRandom)
            {
                dgvResultados.Rows[i].Cells["colEstadoMoto"].Value = "Realizando entrega";
                dgvResultados.Rows[i].Cells["colRndDelivery"].Value = ((FinDelivery)evento).getRandom();
                dgvResultados.Rows[i].Cells["colTiempoEntrega"].Value = ((FinDelivery)evento).getTiempoEntreLlegada();
                dgvResultados.Rows[i].Cells["colFinEntregaDelivery"].Value = ((FinDelivery)evento).getProximaLlegada();
            }
        }

        private bool cambiarEstadoPedido(Pedido ped)
        {
            return colaPreparacion.cambiarEstadoPedido(ped);
        }

        private void actualizarEstadoEmpleado(Empleado e, int fila)
        {
            if (colaPreparacion.getCola().Count != 0)
            {
                //sacar de la cola y calcular nuevo tiempo de demora
                Pedido enPreparacion = colaPreparacion.getCola().Dequeue();
                LlegadaPedido lp = new LlegadaPedido();
                lp.setPedido(enPreparacion);
                generarDemoraPedido(fila, e.getId(),lp);
            }
        }

        private void repetirValoresDemora(Empleado empleado, int i) {
            int id = empleado.getId();
            dgvResultados.Rows[i].Cells["colEstadoEmpleado"+id].Value = empleado.getEstado();
            dgvResultados.Rows[i].Cells["colRndDemora" + id].Value = "";
            dgvResultados.Rows[i].Cells["colDemora" + id].Value = empleado.getDemora();
            dgvResultados.Rows[i].Cells["colFinCoccion" + id].Value = empleado.getFinCoccion();
        }

        private void ponerColaPedido(LlegadaPedido lp) {
            colaPreparacion.setCola(lp.getPedido());
        }

        private void agregarColaAGrilla(int i) {
            dgvResultados.Rows[i].Cells["colColaPreparacion"].Value = colaPreparacion.getCola().Count();
        }

        public int generarLlegadaPedido()
        {
            int i = this.dgvResultados.Rows.Add();
            this.llegadaPedido.simular(this.relojSimulacion, this.rand.NextDouble());
            this.agregarEventoAGrilla(i, true, this.llegadaPedido, 0);
            this.agregarDatosAGrila(i, this.llegadaPedido.getNombreEvento());

            return i;
        }

        public void generarDemoraPedido(int j, int idEmpleado, LlegadaPedido lp)
        {
          
                this.generarDemoraEnEmpleado(j, this.finCoccionEmpleado1.getIdEmpleado(), lp);
                this.agregarDemoraEnGrillaEmpleados(idEmpleado, j, true, finCoccionEmpleado1);      
         
        }
        
        public void generarDemoraEnEmpleado(int i, int id, LlegadaPedido p)
        {
            

            switch (id) {
                case 1:
                    this.finCoccionEmpleado1.simularDemora(this.relojSimulacion, this.rand.NextDouble(), p); 
                    break;
                case 2:
                    this.finCoccionEmpleado2.simularDemora(this.relojSimulacion, this.rand.NextDouble(), p);
                    this.agregarEventoAGrilla(i, true, this.finCoccionEmpleado2, 2);
                    this.agregarDatosAGrila(i, this.finCoccionEmpleado2.getNombreEvento());

                    break;
                case 3:
                    this.finCoccionEmpleado3.simularDemora(this.relojSimulacion, this.rand.NextDouble(), p);
                    this.agregarEventoAGrilla(i, true, this.finCoccionEmpleado3, 3);
                    this.agregarDatosAGrila(i, this.finCoccionEmpleado3.getNombreEvento());
                    break;
            }
           
 
        }

       
        public void tomarDatosPatalla()
        {
            this.tiempoFinCorrida = Convert.ToDouble(this.txtTiempoSim.Text);
            this.tiempoAPartirDeDondeMostrar = Convert.ToDouble(this.txtMinDesde.Text);
            this.mediaLlegadaPedidos = Convert.ToDouble(this.txtLlegadaPedido.Text);
            this.tiempoTopeGratis = Convert.ToDouble(this.txtTopeGratis.Text);
            this.tiempoTopeEspera = Convert.ToInt32(this.txtTopeEspera.Text);
            this.promSandwich = Convert.ToDouble(this.txtPromSandwich.Text);
            this.desvSandwich = Convert.ToDouble(this.txtdesvSandwich.Text);
            this.desdePizza = Convert.ToDouble(this.txtDesdePizza.Text);
            this.hastaPizza = Convert.ToDouble(this.txtHastaPizza.Text);
            this.precioPizza = Convert.ToDouble(this.txtPrecioPizza.Text);
        }

        public void inicializarVariables()
        {
            this.relojSimulacion = 0.0;
            this.turno = _TipoTurno.Mañana;
            this.dia = 0;
            this.identificadorPedido = 0;
            this.eventosYaSimuladosYMostrados = 0;
            this.ContVehiculosCombustibleIngresanAlSitema = 0.0;
            this.ContVehiculosGasIngresanAlSitema = 0.0;
            this.ContVehiculosCombustibleRechazados = 0.0;
            this.ContVehiculosGasRechazados = 0.0;
            this.ContVehiculosCombustibleAtendidos = 0.0;
            this.ContVehiculosGasAtendidos = 0.0;
            this.AcumTiempoEsperaVehiculosCombustible = 0.0;
            this.AcumTiempoEsperaVehiculosGas = 0.0;
            this.ContVehiConTiempoEsperaVehiculosCombustible = 0.0;
            this.ContVehiConTiempoEsperaVehiculosGas = 0.0;
            this.AcumTiempoOcioServidoresCombustible = 0.0;
            this.AcumTiempoOcioServidoresGas = 0.0;
            this.llegadaPedido = new LlegadaPedido(this.mediaLlegadaPedidos);
            this.empleado1 = new Empleado(1, 0);
            this.empleado2 = new Empleado(2, 0);
            this.empleado3 = new Empleado(3, 0);
            this.delivery= new Delivery (1,0);
            this.finCoccionEmpleado1 = new FinCoccionEmpleado(0, 0, 1, empleado1);
            this.finCoccionEmpleado2 = new FinCoccionEmpleado(0, 0, 2, empleado2);
            this.finCoccionEmpleado3 = new FinCoccionEmpleado(0, 0, 3, empleado3);
            this.colaPreparacion = new ColaPreparacion();

            this.finDelivery = new FinDelivery(this.desdePizza, this.hastaPizza, 1, this.precioPizza);
           
        }

        private void agregarEventoAGrilla(int i, bool conRandom, Evento evento, int idEmpleado)
        {
            if (evento is LlegadaPedido)
            {
                dgvResultados.Rows[i].Cells["colRNDLlegadaComb"].Value = "-";
                dgvResultados.Rows[i].Cells["colTiempoLlegadaComb"].Value = "-";
                dgvResultados.Rows[i].Cells["colRNDTipoPedido"].Value = "-";
                dgvResultados.Rows[i].Cells["colTipoPedido"].Value = "-";
                dgvResultados.Rows[i].Cells["colCantidad"].Value = "-";

                if (conRandom)
                {
                    dgvResultados.Rows[i].Cells["colRNDLlegadaComb"].Value = ((LlegadaPedido)evento).getRandom();
                    dgvResultados.Rows[i].Cells["colTiempoLlegadaComb"].Value = ((LlegadaPedido)evento).getTiempoEntreLlegada();
                    //
                    if (i != 0) {
                        dgvResultados.Rows[i].Cells["colRNDTipoPedido"].Value = ((LlegadaPedido)evento).getRandomTipoPed();
                        dgvResultados.Rows[i].Cells["colTipoPedido"].Value = ((LlegadaPedido)evento).getPedido().Tipo;
                        dgvResultados.Rows[i].Cells["colCantidad"].Value = ((LlegadaPedido)evento).getPedido().Cantidad;
                    }

                }

                dgvResultados.Rows[i].Cells["colProxLlegadaComb"].Value = ((LlegadaPedido)evento).getProximaLlegada();

            } 
            
            else if (evento is FinCoccionEmpleado) {

                if (relojSimulacion != 0.00)
                {
                    dgvResultados.Rows[i].Cells["colEvento"].Value = evento.getNombreEvento();
                    dgvResultados.Rows[i].Cells["colReloj"].Value = relojSimulacion;
                    dgvResultados.Rows[i].Cells["colDia"].Value = dia;
                    dgvResultados.Rows[i].Cells["colTurno"].Value = turno;
                }


                /*
                switch (idEmpleado) {
                    case 1:
                        setGrillaEmpleados(idEmpleado, i, conRandom, evento);
                        break;
                    case 2:
                        setGrillaEmpleados(idEmpleado, i, conRandom, evento);
                        break;
                    case 3:
                        setGrillaEmpleados(idEmpleado, i, conRandom, evento);
                        break;
                }
                */
                //int k = this.dgvResultados.Rows.Add();


            }
            else if (evento is FinDelivery) {

            }

        }

        private int  agregarEventoFinCoccion()
        {
            int k = this.dgvResultados.Rows.Add();
            this.agregarEventoAGrilla(k, true, finCoccionEmpleado1, 1);

            return k;
        }
        private void agregarDemoraEnGrillaEmpleados(int id, int i, bool conRandom, Evento evento)
        {
            dgvResultados.Rows[i].Cells["colEstadoEmpleado1"].Value = "Libre";
            dgvResultados.Rows[i].Cells["colRndDemora1"].Value = "-";
            dgvResultados.Rows[i].Cells["colDemora1"].Value = "-";
            dgvResultados.Rows[i].Cells["colFinCoccion1"].Value = "-";

            if (conRandom)
            {
                dgvResultados.Rows[i].Cells["colEstadoEmpleado1"].Value = ((FinCoccionEmpleado)evento).Empleado.getEstado();
                dgvResultados.Rows[i].Cells["colRndDemora1"].Value = ((FinCoccionEmpleado)evento).getRandom();
                dgvResultados.Rows[i].Cells["colDemora1"].Value = ((FinCoccionEmpleado)evento).Empleado.getDemora();
                dgvResultados.Rows[i].Cells["colFinCoccion1"].Value = ((FinCoccionEmpleado)evento).Empleado.getFinCoccion();
            }
        }

        private void agregarDatosAGrila(int i, string evento)
        {
            //Mostrar datos de la simulacion y estadisticas
            dgvResultados.Rows[i].Cells["colEvento"].Value = evento;
            dgvResultados.Rows[i].Cells["colReloj"].Value = relojSimulacion;
            dgvResultados.Rows[i].Cells["colDia"].Value = dia;
            dgvResultados.Rows[i].Cells["colTurno"].Value = turno;
        }
        private void agregarColumnasAGrilla(int identificadorVehiculo)
        {
            int i;
            i = dgvResultados.Columns.Add("EstadoVehi" + identificadorVehiculo, "Estado Vehiculos" + identificadorVehiculo);
            dgvResultados.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            i = dgvResultados.Columns.Add("colHoraInicioEsperaVehiculo" + identificadorVehiculo, "Hora Inicio Espera Vehiculo" + identificadorVehiculo);
            dgvResultados.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;

        }

        private void darFormato(TextBox txt, bool poner)//Da formato para resaltar los resultados estadisticos
        {
            if (poner)
            {
                txt.BackColor = Color.FromArgb(255, 199, 206);
                txt.ForeColor = Color.FromArgb(156, 0, 6);
            }
            else
            {
                txt.BackColor = SystemColors.Control;
                txt.ForeColor = SystemColors.WindowText;
            }
        }
        private bool validarDatos()//Punto de partida para validar la completitud y tipo de datos
        {
            foreach (Control con in this.Controls)
            {
                if (con is GroupBox)
                {
                    validar((GroupBox)con);

                }
            }
            return resul;
        }

        private void validar(GroupBox grupo)
        {
            foreach (Control con in grupo.Controls)
            {


                if (con is GroupBox)
                {
                    validar((GroupBox)con);
                }
                if (con is TextBox)
                {
                    if (!Validaciones.estaVacio((TextBox)con) || !Validaciones.validarNumero((TextBox)con))//Valida que los campos no esten vacios y sean de tipo numerico
                    {
                        invalido = (TextBox)con;
                        resul = false;
                    }
                }
            }

        }
        private void indicarErrorYPonerFocus()//Informa de datos invalidos y pone el foco en el ultimo control que fue invalido
        {
            MessageBox.Show("Parametro Vacío o Incorrecto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            invalido.Focus();
        }

        private void txtLlegadaConbustible_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 110 || e.KeyValue == 190)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtColaMax_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 110 || e.KeyValue == 190 || e.KeyValue == 188)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)//Advertencia de que se perderan los datos con el reset
        {
            if (MessageBox.Show("¿Está seguro que desea Reiniciar?\n\nSe Perderán los cambios realizados", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
            reset();
            }
        }
        private void reset()
        {
            //Limpiar la grilla
            dgvResultados.Rows.Clear();

            //Reset a variables
            resul = true;
            invalido = null;
            identificadorPedido = 0;
            relojSimulacion = 0.00;
            turno = _TipoTurno.Mañana;
            dia = 0;


            //Remover Columnas de Objetos Temporales

            int columnas = dgvResultados.Columns.Count-1;

            for (int i = columnas; i >= 52; i--)
            {
                try
                {
                    dgvResultados.Columns.RemoveAt(i);

                }
                catch (Exception)
                {


                }
            }

            //Habilitar Boton Simular
            btnSimular.Enabled = true;

        }

        private void radioCada10mil_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCada10mil.Checked)
            {
                this.txtMinDesde.Enabled = false;
                this.txtMinHasta.Enabled = false;
            }
            else
            {
                this.txtMinDesde.Enabled = true;
                this.txtMinHasta.Enabled = true;
            }
        }
    }
}
