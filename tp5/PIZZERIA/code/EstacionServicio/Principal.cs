﻿using System;
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
            //Inicio Bloque Simulacion
            if (validarDatos())
            {
                this.tomarDatosPatalla();
                this.inicializarVariables();

                //Limpiar Grilla 
                dgvResultados.Rows.Clear();

                //Genero Evento Llegada Pedido 0
                int fila = 0;
                llegadaPedido.simular(relojSimulacion, rand.NextDouble());

                //Imprimo fila 0
                if (this.filaAPartirDeDondeMostrar == 0 || radioCada10mil.Checked)
                {
                    this.dgvResultados.Rows.Add();
                    agregarEventoInicio();
                }

                //Bucle principal de Simulacion
                while (relojSimulacion.getDia() < tiempoFinCorrida)
                {
                    //Selecciono el siguiente evento
                    Reloj firstEvent = this.getFirstEvent(this.llegadaPedido.getProximaLlegada(), this.finCoccionEmpleado1.getProximaLlegada(), this.finCoccionEmpleado2.getProximaLlegada(), this.finCoccionEmpleado3.getProximaLlegada(), this.finDelivery.getProximaLlegada());
                    //Cargo el reloj y genero una nueva fila
                    this.relojSimulacion.setReloj(firstEvent.getReloj());
                    fila++;

                    //Evento Llegada Pedido
                    if (this.llegadaPedido.getProximaLlegada().Equals(firstEvent))
                    {
                        this.relojSimulacion.setDia(firstEvent.getDia());
                        this.relojSimulacion.setTurno(firstEvent.getTurno());
                        this.llegadaPedido.simular(this.relojSimulacion, this.rand.NextDouble());

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
                                }
                            }           

                        }
                        imprimirFila(llegadaPedido, fila);
                    }
                    //Evento Fin coccion empleado 1
                    if (this.finCoccionEmpleado1.getProximaLlegada().Equals(firstEvent)) 
                    {
                        finCoccionEmpleado1.setHoraFin(new Reloj());         
                        //actualizar el pedido a preparado
                        //liberar el empleado si no hay cola
                        //si hay cola sacar de colar y calcular nueva demora 
                        actualizarEstadoEmpleado(empleado1, fila);
                        // hacer la parte del delivery

                        if (this.delivery.getEstado() == "Libre")
                        {
                            //aca me quede controlar bien xq se armo el bucle
                            this.generarDemoraDelivery(fila, relojSimulacion ,1);
                                                       
                        }
                        imprimirFila(finCoccionEmpleado1, fila);
                    }
                    //Evento Fin coccion empleado 2
                    if (this.finCoccionEmpleado2.getProximaLlegada().Equals(firstEvent))
                    {
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
                        imprimirFila(finCoccionEmpleado2, fila);
                    }
                    //Evento Fin coccion empleado 3
                    if (this.finCoccionEmpleado3.getProximaLlegada().Equals(firstEvent))
                    {
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
                        imprimirFila(finCoccionEmpleado3, fila);
                    }
                    //Evento Fin Delivery
                    if (this.finDelivery.getProximaLlegada().Equals(firstEvent))
                    {
                        finDelivery.setHoraFin(new Reloj());
                        //fijarse en la cola si hay pedidos 
                        //actuallizar su estado
                        imprimirFila(finDelivery, fila);
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

        public void imprimirFila(Evento evento, int fila)
        {
            if ((fila>= this.filaAPartirDeDondeMostrar && fila <= filaHastaDondeMostrar) 
                || radioCada10mil.Checked)
            {
                int i = this.dgvResultados.Rows.Add();
                agregarEventoAGrilla(i, evento, fila);
            }
        }

        public void generarDemoraPedido(int j, int idEmpleado, LlegadaPedido lp)
        {
            switch (idEmpleado)
            {
                case 1:
                    this.generarDemoraEnEmpleado(j, this.finCoccionEmpleado1.getIdEmpleado(), lp);
                    break;
                case 2:
                    this.generarDemoraEnEmpleado(j, this.finCoccionEmpleado2.getIdEmpleado(), lp);
                    break;
                case 3:
                    this.generarDemoraEnEmpleado(j, this.finCoccionEmpleado3.getIdEmpleado(), lp);
                    break;
            }
        }

        private void generarDemoraDelivery(int fila, Reloj reloj ,int idDelivery)
        {
            // fijarse en la cola si hay pedidos 
            Random r = new Random();
            this.finDelivery.simular(reloj, r.NextDouble());
            //if (delivery.getCola().Count != 0)
            //{ //puede solo cargar tres pedidos 
            //    aca me quede


            //      sacar de a tres, actualizar el estado de los pedidos, actualizar el estado del delivery
            //}
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
            }
            else
            {
                //libero los datos de empleado
                switch (e.getId())
                {
                    case 1:
                        empleado1.setEstado("Libre");
                        empleado1.setDemora(0);
                        empleado1.setFinCoccion(new Reloj());
                        break;
                    case 2:
                        empleado2.setEstado("Libre");
                        empleado2.setDemora(0);
                        empleado2.setFinCoccion(new Reloj());
                        break;
                    case 3:
                        empleado3.setEstado("Libre");
                        empleado3.setDemora(0);
                        empleado3.setFinCoccion(new Reloj());
                        break;
                }
            }
        }

        private void ponerColaPedido(LlegadaPedido lp) {
            colaPreparacion.setCola(lp.getPedido());
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

        private void agregarEventoInicio()
        {
            Console.WriteLine("Imprimiendo: " + 0);
            dgvResultados.Rows[0].Cells["colFila"].Value = 0;
            dgvResultados.Rows[0].Cells["colEvento"].Value = "Inicio Simulacion";
            dgvResultados.Rows[0].Cells["colReloj"].Value = relojSimulacion.getReloj();
            dgvResultados.Rows[0].Cells["colDia"].Value = relojSimulacion.getDia();
            dgvResultados.Rows[0].Cells["colTurno"].Value = relojSimulacion.getTurno();
            dgvResultados.Rows[0].Cells["colRNDLlegadaComb"].Value = llegadaPedido.getRandom(); ;
            dgvResultados.Rows[0].Cells["colTiempoLlegadaComb"].Value = llegadaPedido.getTiempoEntreLlegada();
            dgvResultados.Rows[0].Cells["colProxLlegadaComb"].Value = llegadaPedido.getProximaLlegada().getReloj();
            dgvResultados.Rows[0].Cells["colColaPreparacion"].Value = colaPreparacion.getCola().Count();
            dgvResultados.Rows[0].Cells["colEstadoEmpleado1"].Value = empleado1.getEstado();
            dgvResultados.Rows[0].Cells["colEstadoEmpleado2"].Value = empleado2.getEstado();
            dgvResultados.Rows[0].Cells["colEstadoEmpleado3"].Value = empleado3.getEstado();
            dgvResultados.Rows[0].Cells["colEstadoMoto"].Value = delivery.getEstado();
        }

        private void agregarEventoAGrilla(int i, Evento evento, int fila)
        {
            Console.WriteLine("Imprimiendo: " + fila);

            //Columnas que se muestran siempre
            dgvResultados.Rows[i].Cells["colFila"].Value = fila;
            dgvResultados.Rows[i].Cells["colEvento"].Value = evento.getNombreEvento();
            dgvResultados.Rows[i].Cells["colReloj"].Value = relojSimulacion.getReloj();
            dgvResultados.Rows[i].Cells["colDia"].Value = relojSimulacion.getDia();
            dgvResultados.Rows[i].Cells["colTurno"].Value = relojSimulacion.getTurno().ToString();
            dgvResultados.Rows[i].Cells["colColaPreparacion"].Value = colaPreparacion.getCola().Count();
            dgvResultados.Rows[i].Cells["colEstadoEmpleado1"].Value = empleado1.getEstado();
            dgvResultados.Rows[i].Cells["colEstadoEmpleado2"].Value = empleado2.getEstado();
            dgvResultados.Rows[i].Cells["colEstadoEmpleado3"].Value = empleado3.getEstado();
            dgvResultados.Rows[i].Cells["colEstadoMoto"].Value = delivery.getEstado();

            //Estos se muestran solo en caso de que el evento sea una llegada de Pedido
            if (evento.getNombreEvento().Equals("llegada_Pedido")){
                dgvResultados.Rows[i].Cells["colRNDLlegadaComb"].Value = llegadaPedido.getRandom(); ;
                dgvResultados.Rows[i].Cells["colTiempoLlegadaComb"].Value = llegadaPedido.getTiempoEntreLlegada();
                dgvResultados.Rows[i].Cells["colRNDTipoPedido"].Value = llegadaPedido.getRandomTipoPed();
                dgvResultados.Rows[i].Cells["colTipoPedido"].Value = llegadaPedido.getPedido().Tipo;
                dgvResultados.Rows[i].Cells["colCantidad"].Value = llegadaPedido.getPedido().Cantidad;
                if (llegadaPedido.getPedido().Tipo.Equals("Empanadas"))
                    dgvResultados.Rows[i].Cells["colRNDCant"].Value = llegadaPedido.getPedido().RndCantidad;
            }

            //Estos se muestra si hay una proxima llegada pendiente
            if (llegadaPedido.getProximaLlegada().getReloj() > 0)
            {
                dgvResultados.Rows[i].Cells["colProxLlegadaComb"].Value = llegadaPedido.getProximaLlegada().getReloj();
            }

            //Estos se muestra si hay un proximo fin de coccion del empleado 1 pendiente
            if (finCoccionEmpleado1.getProximaLlegada().getReloj() > 0 )
            {
                dgvResultados.Rows[i].Cells["colRndDemora1"].Value = finCoccionEmpleado1.getRandom();
                dgvResultados.Rows[i].Cells["colDemora1"].Value = finCoccionEmpleado1.getTiempoEntreLlegada();
                dgvResultados.Rows[i].Cells["colFinCoccion1"].Value = finCoccionEmpleado1.getProximaLlegada().getReloj();
            }

            //Estos se muestra si hay un proximo fin de coccion del empleado 2 pendiente
            if (finCoccionEmpleado2.getProximaLlegada().getReloj() > 0)
            {
                dgvResultados.Rows[i].Cells["colRndDemora2"].Value = finCoccionEmpleado2.getRandom();
                dgvResultados.Rows[i].Cells["colDemora2"].Value = finCoccionEmpleado2.getTiempoEntreLlegada();
                dgvResultados.Rows[i].Cells["colFinCoccion2"].Value = finCoccionEmpleado2.getProximaLlegada().getReloj();
            }

            //Estos se muestra si hay un proximo fin de coccion del empleado 2 pendiente
            if (finCoccionEmpleado3.getProximaLlegada().getReloj() > 0)
            {
                dgvResultados.Rows[i].Cells["colRndDemora3"].Value = finCoccionEmpleado3.getRandom();
                dgvResultados.Rows[i].Cells["colDemora3"].Value = finCoccionEmpleado3.getTiempoEntreLlegada();
                dgvResultados.Rows[i].Cells["colFinCoccion3"].Value = finCoccionEmpleado3.getProximaLlegada().getReloj();
            }

            //Estos se muestra si hay un proximo fin de delivery pendiente
            if (this.finDelivery.getProximaLlegada().getReloj() > 0)
            {
                dgvResultados.Rows[i].Cells["colRndDelivery"].Value = this.finDelivery.getRandom();
                dgvResultados.Rows[i].Cells["colTiempoEntrega"].Value = this.finDelivery.getTiempoEntreLlegada();
                dgvResultados.Rows[i].Cells["colFinEntregaDelivery"].Value = this.finDelivery.getProximaLlegada().getReloj();
            }
        }
    }
}
