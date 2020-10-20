using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
        private List<Empleado> empleados;
        private ColaPreparacion colaPreparacion;

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
        private double filaHastaDondeMostrar;
        private double precioSandwich;
        private double demoraEmpax3;
        private double demoraEmpax2;
        private double precioEmpa;
        private double demoraHamburguesa;
        private double precioHamburguesa;
        private double demoraLomo;
        private double precioLomo;

        //Parametros de la corrida
        private double tiempoFinCorrida;
        private double filaAPartirDeDondeMostrar;
        private int cantidadDeEventosAMostrar;


        //Variables necesarias
        private Reloj relojSimulacion;
        private int identificadorPedido;
        private int eventosYaSimuladosYMostrados;
        Random rand = new Random((int)DateTime.Now.Ticks);
        bool resul = true;
        TextBox invalido = null;

        public frm_principal()
        {
            InitializeComponent();
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

        private void btnSimular_Click(object sender, EventArgs e)
        {
            //reset();

            //Inicio Bloque Simulacion
            if (validarDatos())
            {
                this.tomarDatosPatalla();
                this.inicializarVariables();

                //Limpiar Grilla 
                dgvResultados.Rows.Clear();

                //Inicio de La Simulacion
                if (filaAPartirDeDondeMostrar == 0 )//Calculos los primeros eventos
                {

                    llegadaPedido.simular(relojSimulacion, rand.NextDouble());//carga de llegada de pedido

                    int i = this.dgvResultados.Rows.Add();
                    this.agregarDatosAGrila(i, "Inicio Simulacion");
                    this.agregarEventoAGrilla(i, true, this.llegadaPedido, 0);
;
                    this.agregarEventoAGrilla(i, false, this.finCoccionEmpleado1, this.finCoccionEmpleado1.getIdEmpleado());
                    this.agregarEventoAGrilla(i, false, this.finCoccionEmpleado2, this.finCoccionEmpleado2.getIdEmpleado());
                    this.agregarEventoAGrilla(i, false, this.finCoccionEmpleado3, this.finCoccionEmpleado3.getIdEmpleado());
                    this.eventosYaSimuladosYMostrados++;

                }

                int fila = 0;

                //Bucle principal de Simulacion
                while (relojSimulacion.getDia() < tiempoFinCorrida)
                {
                    Reloj firstEvent = this.getFirstEvent(this.llegadaPedido.getProximaLlegada(), this.finCoccionEmpleado1.getProximaLlegada(), this.finCoccionEmpleado2.getProximaLlegada(), this.finCoccionEmpleado3.getProximaLlegada(), this.finDelivery.getProximaLlegada());

                    this.relojSimulacion.setReloj(firstEvent.getReloj());

                    if (this.llegadaPedido.getProximaLlegada().Equals(firstEvent))
                    {
                        this.relojSimulacion.setDia(firstEvent.getDia());
                        this.relojSimulacion.setTurno(firstEvent.getTurno());
                        fila = this.generarLlegadaPedido();

                        //hacer para los 3 empleados
                        if (this.empleado1.getEstado() == "Libre")
                        {
                            generarDemoraPedido(fila, 1, llegadaPedido);
                        }
                        else
                        {
                            if (this.empleado2.getEstado() == "Libre")
                            {
                                generarDemoraPedido(fila, 2, llegadaPedido);
                            }
                            else
                            {
                                if (this.empleado3.getEstado() == "Libre")
                                {
                                    generarDemoraPedido(fila, 3, llegadaPedido);
                                }
                                else
                                {
                                    // mandar a cola
                                    ponerColaPedido(llegadaPedido);
                                    agregarColaAGrilla(fila);

                                    //repetir valores de fin de coccion
                                    //pasar empleado correspondiente
                                    repetirValoresDemora(empleado1, finCoccionEmpleado1, fila);
                                    repetirValoresDemora(empleado2, finCoccionEmpleado2, fila);
                                    repetirValoresDemora(empleado3, finCoccionEmpleado3, fila);
                                }
                            }

                            //si estan todos ocupados mandar a cola 

                        }

                    }
                    if (this.finCoccionEmpleado1.getProximaLlegada().Equals(firstEvent)) 
                    {
                        fila = agregarEventoFinCoccion(1);

                        finCoccionEmpleado1.setHoraFin(new Reloj());
                        
                        //actualizar el pedido a preparado 
                        cambiarEstadoPedido(llegadaPedido.getPedido());
                        //liberar el empleado si no hay cola
                        //si hay cola sacar de colar y calcular nueva demora 
                        actualizarEstadoEmpleado(empleado1, fila);
                        // hacer la parte del delivery

                        if (this.delivery.getEstado() == "Libre")
                        {
                            //aca me quede controlar bien xq se armo el bucle
                            this.generarDemoraDelivery(fila, relojSimulacion ,1);
                                                       
                        }  
                    }
                    if (this.finCoccionEmpleado2.getProximaLlegada().Equals(firstEvent))
                    {
                        
                        fila = agregarEventoFinCoccion(2);

                        finCoccionEmpleado2.setHoraFin(new Reloj());

                        //actualizar el pedido a preparado 
                        cambiarEstadoPedido(llegadaPedido.getPedido());
                        //liberar el empleado si no hay cola
                        //si hay cola sacar de colar y calcular nueva demora 
                        actualizarEstadoEmpleado(empleado2, fila);
                        // hacer la parte del delivery

                        if (this.delivery.getEstado() == "Libre")
                        {
                            //aca me quede controlar bien xq se armo el bucle
                            this.generarDemoraDelivery(fila, relojSimulacion, 1);

                        }
                    }
                    if (this.finCoccionEmpleado3.getProximaLlegada().Equals(firstEvent))
                    {
                        fila = agregarEventoFinCoccion(3);

                        finCoccionEmpleado3.setHoraFin(new Reloj());

                        //actualizar el pedido a preparado 
                        cambiarEstadoPedido(llegadaPedido.getPedido());
                        //liberar el empleado si no hay cola
                        //si hay cola sacar de colar y calcular nueva demora 
                        actualizarEstadoEmpleado(empleado3, fila);
                        // hacer la parte del delivery

                        if (this.delivery.getEstado() == "Libre")
                        {
                            //aca me quede controlar bien xq se armo el bucle
                            this.generarDemoraDelivery(fila, relojSimulacion, 1);

                        }
                    }

                    if (this.finDelivery.getProximaLlegada().Equals(firstEvent))
                    {
                        
                        fila=agregarEventoFinDelivery();
                        finDelivery.setHoraFin(new Reloj());
                        //fijarse en la cola si hay pedidos 
                        //actuallizar su estado 
                    }
                    
                }

            }
            else
            {
                indicarErrorYPonerFocus();
                resul = true;
            }

            //Fin Bloque Simulacion
        }

        private int agregarEventoFinDelivery()
        {
            int k = this.dgvResultados.Rows.Add();
            this.agregarEventoAGrilla(k, true, finDelivery, 1);

            return k;
        }
        private void generarDemoraDelivery(int fila, Reloj reloj ,int idDelivery)
        {
            // fijarse en la cola si hay pedidos 
            Random r = new Random();
            this.finDelivery.simular(reloj, r.NextDouble());
            this.agregarDemoraEnGrillaDelivery(fila, true, finDelivery);
            //if (delivery.getCola().Count != 0)
            //{ //puede solo cargar tres pedidos 
            //    aca me quede


            //      sacar de a tres, actualizar el estado de los pedidos, actualizar el estado del delivery
            //}


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
                dgvResultados.Rows[i].Cells["colFinEntregaDelivery"].Value = ((FinDelivery)evento).getProximaLlegada().getReloj();
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
                generarDemoraPedido(fila, e.getId(), lp);
                //actulizar la cola de pedidos en la grilla
                agregarColaAGrilla(fila);
            }
            else
            {
                //libero los datos de empleado
                empleado1.setEstado("Libre");
                empleado1.setDemora(0);
                empleado1.setFinCoccion(new Reloj());
                repetirValoresDemora(empleado1, finCoccionEmpleado1,  fila);
            }
        }

        private void repetirValoresDemora(Empleado empleado, FinCoccionEmpleado finCoccion, int i) {
            int id = empleado.getId();
            dgvResultados.Rows[i].Cells["colEstadoEmpleado"+id].Value = empleado.getEstado();
            dgvResultados.Rows[i].Cells["colRndDemora" + id].Value = "";
            dgvResultados.Rows[i].Cells["colDemora" + id].Value = finCoccion.getTiempoEntreLlegada();
            dgvResultados.Rows[i].Cells["colFinCoccion" + id].Value = finCoccion.getProximaLlegada().getReloj();
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

            switch (idEmpleado)
            {
                case 1:
                    this.generarDemoraEnEmpleado(j, this.finCoccionEmpleado1.getIdEmpleado(), lp);
                    this.agregarDemoraEnGrillaEmpleados(idEmpleado, j, true, finCoccionEmpleado1);
                    break;
                case 2:
                    this.generarDemoraEnEmpleado(j, this.finCoccionEmpleado2.getIdEmpleado(), lp);
                    this.agregarDemoraEnGrillaEmpleados(idEmpleado, j, true, finCoccionEmpleado2);

                    break;
                case 3:
                    this.generarDemoraEnEmpleado(j, this.finCoccionEmpleado3.getIdEmpleado(), lp);
                    this.agregarDemoraEnGrillaEmpleados(idEmpleado, j, true, finCoccionEmpleado3);

                    break;
            }
            

        }

        public void generarDemoraEnEmpleado(int i, int id, LlegadaPedido p)
        {
            

            switch (id) {
                case 1:
                    this.finCoccionEmpleado1.simularDemora(this.relojSimulacion, this.rand.NextDouble(), p); 
                    break;
                case 2:
                    this.finCoccionEmpleado2.simularDemora(this.relojSimulacion, this.rand.NextDouble(), p);
                    
                    break;
                case 3:
                    this.finCoccionEmpleado3.simularDemora(this.relojSimulacion, this.rand.NextDouble(), p);

                    break;
            }
           
 
        }

       
        public void tomarDatosPatalla()
        {
            this.tiempoFinCorrida = Convert.ToDouble(this.txtTiempoSim.Text);
            this.filaAPartirDeDondeMostrar = Convert.ToDouble(this.txtMinDesde.Text);
            this.filaHastaDondeMostrar = Convert.ToDouble(this.txtMinHasta.Text);
            this.mediaLlegadaPedidos = Convert.ToDouble(this.txtLlegadaPedido.Text);
            this.tiempoTopeGratis = Convert.ToDouble(this.txtTopeGratis.Text);
            this.tiempoTopeEspera = Convert.ToInt32(this.txtTopeEspera.Text);
            this.promSandwich = Convert.ToDouble(this.txtPromSandwich.Text);
            this.desvSandwich = Convert.ToDouble(this.txtdesvSandwich.Text);
            this.precioSandwich = Convert.ToDouble(this.textPrecioSandwich.Text);
            this.desdePizza = Convert.ToDouble(this.txtDesdePizza.Text);
            this.hastaPizza = Convert.ToDouble(this.txtHastaPizza.Text);
            this.precioPizza = Convert.ToDouble(this.txtPrecioPizza.Text);
            this.demoraEmpax3 = Convert.ToDouble(this.textDemora3Empa.Text);
            this.demoraEmpax2 = Convert.ToDouble(this.textDemora2Empa.Text);
            this.precioEmpa = Convert.ToDouble(this.textPrecioEmpa.Text);
            this.demoraHamburguesa = Convert.ToDouble(this.textDemoraHambur.Text);
            this.precioHamburguesa = Convert.ToDouble(this.textPrecioHambur.Text);
            this.demoraLomo = Convert.ToDouble(this.textDemoraLomo.Text);
            this.precioLomo = Convert.ToDouble(this.textPrecioLomo.Text);
        }


        public void inicializarVariables()
        {
            this.relojSimulacion = new Reloj();
            this.identificadorPedido = 0;
            this.eventosYaSimuladosYMostrados = 0;
            this.llegadaPedido = new LlegadaPedido(this.mediaLlegadaPedidos);
            this.empleado1 = new Empleado(1, 0); //TODO pasar valores tomados por parametros
            this.empleado2 = new Empleado(2, 0); //TODO pasar valores tomados por parametros
            this.empleado3 = new Empleado(3, 0); //TODO pasar valores tomados por parametros
            this.delivery= new Delivery (1,0); //TODO pasar valores tomados por parametros
            this.finCoccionEmpleado1 = new FinCoccionEmpleado(promSandwich, desvSandwich, desdePizza, hastaPizza, demoraEmpax3, demoraEmpax2, demoraHamburguesa, demoraLomo, 1, empleado1);
            this.finCoccionEmpleado2 = new FinCoccionEmpleado(promSandwich, desvSandwich, desdePizza, hastaPizza, demoraEmpax3, demoraEmpax2, demoraHamburguesa, demoraLomo, 2, empleado2);
            this.finCoccionEmpleado3 = new FinCoccionEmpleado(promSandwich, desvSandwich, desdePizza, hastaPizza, demoraEmpax3, demoraEmpax2, demoraHamburguesa, demoraLomo, 3, empleado3);
            this.colaPreparacion = new ColaPreparacion();

            this.finDelivery = new FinDelivery(this.desdePizza, this.hastaPizza, 1, this.precioPizza);//TODO pasar parametros 
            this.empleados = new List<Empleado>() { empleado1, empleado2, empleado3 };
           
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

                dgvResultados.Rows[i].Cells["colProxLlegadaComb"].Value = ((LlegadaPedido)evento).getProximaLlegada().getReloj();

            } 
            
            if (evento is FinCoccionEmpleado) 
            {

                if (relojSimulacion.getReloj() != 0.00)
                {
                    dgvResultados.Rows[i].Cells["colEvento"].Value = evento.getNombreEvento();
                    dgvResultados.Rows[i].Cells["colReloj"].Value = relojSimulacion.getReloj();
                    dgvResultados.Rows[i].Cells["colDia"].Value = relojSimulacion.getDia();
                    dgvResultados.Rows[i].Cells["colTurno"].Value = relojSimulacion.getTurno().ToString();
                }



            }
            else if (evento is FinDelivery) 
            {
                dgvResultados.Rows[i].Cells["colEvento"].Value = evento.getNombreEvento();
                dgvResultados.Rows[i].Cells["colReloj"].Value = relojSimulacion.getReloj();
                dgvResultados.Rows[i].Cells["colDia"].Value = relojSimulacion.getDia();
                dgvResultados.Rows[i].Cells["colTurno"].Value = relojSimulacion.getTurno().ToString();

            }

        }

        private int  agregarEventoFinCoccion(int idEmpleado)
        {
            int k = this.dgvResultados.Rows.Add();
            switch (idEmpleado)
            {
                case 1:
                    this.agregarEventoAGrilla(k, true, finCoccionEmpleado1, 1);
                    break;
                case 2:
                    this.agregarEventoAGrilla(k, true, finCoccionEmpleado2, 2);

                    break;
                case 3:
                    this.agregarEventoAGrilla(k, true, finCoccionEmpleado3, 3);

                    break;
            }

            return k;
        }

        private void agregarDemoraEnGrillaEmpleados(int id, int i, bool conRandom, Evento evento)
        {
            dgvResultados.Rows[i].Cells["colEstadoEmpleado"+id].Value = "Libre";
            dgvResultados.Rows[i].Cells["colRndDemora"+id].Value = "-";
            dgvResultados.Rows[i].Cells["colDemora"+id].Value = "-";
            dgvResultados.Rows[i].Cells["colFinCoccion"+id].Value = "-";

            if (conRandom)
            {
                dgvResultados.Rows[i].Cells["colEstadoEmpleado"+id].Value = ((FinCoccionEmpleado)evento).Empleado.getEstado();
                dgvResultados.Rows[i].Cells["colRndDemora"+id].Value = ((FinCoccionEmpleado)evento).getRandom();
                dgvResultados.Rows[i].Cells["colDemora"+id].Value = ((FinCoccionEmpleado)evento).Empleado.getDemora();
                dgvResultados.Rows[i].Cells["colFinCoccion"+id].Value = ((FinCoccionEmpleado)evento).Empleado.getFinCoccion().getReloj();
            }
        }

        private void agregarDatosAGrila(int i, string evento)
        {
            //Mostrar datos de la simulacion y estadisticas
            dgvResultados.Rows[i].Cells["colEvento"].Value = evento;
            dgvResultados.Rows[i].Cells["colReloj"].Value = relojSimulacion.getReloj();
            dgvResultados.Rows[i].Cells["colDia"].Value = relojSimulacion.getDia();
            dgvResultados.Rows[i].Cells["colTurno"].Value = relojSimulacion.getTurno();
        }

        private void agregarColumnasAGrilla(int identificadorVehiculo)
        {
            int i;
            i = dgvResultados.Columns.Add("EstadoVehi" + identificadorVehiculo, "Estado Vehiculos" + identificadorVehiculo);
            dgvResultados.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            i = dgvResultados.Columns.Add("colHoraInicioEsperaVehiculo" + identificadorVehiculo, "Hora Inicio Espera Vehiculo" + identificadorVehiculo);
            dgvResultados.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;

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
