using EstacionServicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
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
        private double mediaLlegadaGas;
        private int colaMaxima;

        //Parametros de Finalizacion
        private double valorAUniformeFinCombustible;
        private double valorBUniformeFinCombustible;
        private double valorAUniformeFinGas;
        private double valorBUniformeFinGas;
        private double cteSumadaAUniformeGas;

        //Parametros de la corrida
        private double tiempoFinCorrida;
        private double tiempoAPartirDeDondeMostrar;
        private int cantidadDeEventosAMostrar;


        //Variables necesarias
        private double relojSimulacion;
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
            //Inicio Bloque Simulacion
            if (validarDatos())
            {
                this.tomarDatosPatalla();
                this.inicializarVariables();

                //bloqueo el boton simular para obligar a resetear antes de una nueva simulacion
                btnSimular.Enabled = false;

                //Limpiar Grilla 
                dgvResultados.Rows.Clear();

                //Inicio de La Simulacion
                if (relojSimulacion == 0.00)//Calculos los primeros eventos
                {
                  
                    llegadaPedido.simular(relojSimulacion, rand.NextDouble());//carga de llegada de pedido

                    if (tiempoAPartirDeDondeMostrar == 0.00 && eventosYaSimuladosYMostrados < cantidadDeEventosAMostrar)//Veo si tengo que graficar
                    {

                        int i = this.dgvResultados.Rows.Add();
                        this.agregarEventoAGrilla(i, true, this.llegadaPedido, 0);
                        this.agregarDatosAGrila(i, "Inicio Simulacion");
                        //this.agregarSurtidoresAGrilla(i);
                        this.agregarEventoAGrilla(i, false, this.finCoccionEmpleado1, this.finCoccionEmpleado1.getIdEmpleado());
                        this.agregarEventoAGrilla(i, false, this.finCoccionEmpleado2, this.finCoccionEmpleado2.getIdEmpleado());
                        this.agregarEventoAGrilla(i, false, this.finCoccionEmpleado3, this.finCoccionEmpleado3.getIdEmpleado());
                        this.eventosYaSimuladosYMostrados++;
                    }


                }

                int j = 0;
                //Bucle principal de Simulacion
                while (relojSimulacion < tiempoFinCorrida)
                {
                    double firstEvent = this.getFirstEvent(this.llegadaPedido.getProximaLlegada(), this.finCoccionEmpleado1.getProximaLlegada(), this.finCoccionEmpleado2.getProximaLlegada(), this.finCoccionEmpleado3.getProximaLlegada(), this.finDelivery.getProximaLlegada());
                    this.relojSimulacion = firstEvent;
                    if (this.llegadaPedido.getProximaLlegada() == firstEvent)
                    {
                        j = this.generarLlegadaPedido();

                        // hacer para los 3 empleados 
                        if (this.empleado1.getEstado() == "Libre") {
                            this.generarDemoraEmpleado(j, this.finCoccionEmpleado1.getIdEmpleado(), llegadaPedido);
                        }


                        // mandar a cola

                        //ponerColaPedido(llegadaPedido);
                        //int i = this.dgvResultados.Rows.Add();
                        //agregarColaAGrilla(j);

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

                    else if (this.finCoccionEmpleado1.getProximaLlegada() == firstEvent){
                        int k = this.dgvResultados.Rows.Add();
                        this.agregarFinCoccion(k);



                    }
                    //else if (this.finCoccionEmpleado2.getProximaLlegada() == firstEvent)
                    //{
                    //    //this.generarDemoraEmpleado(2);
                    //}
                    //else if (this.finCoccionEmpleado3.getProximaLlegada() == firstEvent)
                    //{
                    //    //this.generarDemoraEmpleado(3);
                    //}
                    //else if (this.finDelivery.getProximaLlegada() == firstEvent)
                    //{

                    //}

                }
                /*
                //Calcular y Mostrar Estadisticas
                if (ContVehiculosCombustibleIngresanAlSitema != 0 || ContVehiculosGasIngresanAlSitema != 0)
                {
                    txtPorcenAutosAtendidos.Text = Math.Round((((ContVehiculosCombustibleAtendidos + ContVehiculosGasAtendidos) / (ContVehiculosCombustibleIngresanAlSitema + ContVehiculosGasIngresanAlSitema)) * 100), 2).ToString();//proporcio de atendido respecto a los que ingresaron al sistema 
                }

                if (ContVehiculosCombustibleIngresanAlSitema != 0)
                {
                    txtPorcenAutosCombAtendidos.Text = Math.Round(((ContVehiculosCombustibleAtendidos / ContVehiculosCombustibleIngresanAlSitema) * 100), 2).ToString();//proporcion de atendido respecto a los que ingresaron al sistema combustible 
                }
                //txtPorcenAutosCombAtendidos.Text = ((ContVehiculosCombustibleAtendidos / (ContVehiculosCombustibleIngresanAlSitema + ContVehiculosCombustibleRechazados)) * 100).ToString();//proporcion de en relacion al total, es decir ingresaron + rechazados
                if (ContVehiculosGasIngresanAlSitema != 0)
                {
                    txtPorcenAutosGasAtendidos.Text = Math.Round(((ContVehiculosGasAtendidos / ContVehiculosGasIngresanAlSitema) * 100), 2).ToString();//proporcio de atendido respecto a los que ingresaron al sistema gas 
                }
                //txtPorcenAutosGasAtendidos.Text = ((ContVehiculosGasAtendidos / (ContVehiculosGasIngresanAlSitema + ContVehiculosGasRechazados)) * 100).ToString();
                txtPromTiempoOcioSurt.Text = Math.Round(((AcumTiempoOcioServidoresCombustible + AcumTiempoOcioServidoresGas) / 7), 2).ToString();
                txtPromTiempoOcioSurtComb.Text = Math.Round((AcumTiempoOcioServidoresCombustible / 4), 2).ToString();
                txtPromTiempoOcioSurtGas.Text = Math.Round((AcumTiempoOcioServidoresGas / 3), 2).ToString();
                if (ContVehiConTiempoEsperaVehiculosCombustible != 0 || ContVehiConTiempoEsperaVehiculosGas != 0)
                {
                    txtTiempoPromEsperaVehi.Text = Math.Round((((AcumTiempoEsperaVehiculosCombustible + AcumTiempoEsperaVehiculosGas) / (ContVehiConTiempoEsperaVehiculosCombustible + ContVehiConTiempoEsperaVehiculosGas))), 2).ToString();
                }
                if (ContVehiConTiempoEsperaVehiculosCombustible != 0)
                {
                    txtTiempoPromEsperaVehiComb.Text = Math.Round((AcumTiempoEsperaVehiculosCombustible / ContVehiConTiempoEsperaVehiculosCombustible), 2).ToString();
                }
                if (ContVehiConTiempoEsperaVehiculosGas != 0)
                {
                    txtTiempoPromEsperaVehiGas.Text = Math.Round((AcumTiempoEsperaVehiculosGas / ContVehiConTiempoEsperaVehiculosGas), 2).ToString();
                }
                txtTotalCombRechazados.Text = ContVehiculosCombustibleRechazados.ToString();
                txtTotalCombustibleIngresados.Text = ContVehiculosCombustibleIngresanAlSitema.ToString();
                txtTotalGasIngresados.Text = ContVehiculosGasIngresanAlSitema.ToString();
                txtTotalGasRechazados.Text = ContVehiculosGasRechazados.ToString();
                txtTotalIngresados.Text = (ContVehiculosGasIngresanAlSitema + ContVehiculosCombustibleIngresanAlSitema).ToString();
                txtTotalRechazados.Text = (ContVehiculosCombustibleRechazados + ContVehiculosGasRechazados).ToString();

                darFormatoATodos(true);

                */
            }
            else
            {
                indicarErrorYPonerFocus();
                resul = true;
            }

            //Fin Bloque Simulacion
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
            //this.agregarSurtidoresAGrilla(i);
            return i;
        }

        public void generarDemoraEmpleado(int i, int id, LlegadaPedido llegadaP)
        {
            //int i = this.dgvResultados.Rows.Add();
            string tipoPedido = llegadaP.getPedido().Tipo;
            int cantidad = llegadaP.getPedido().Cantidad;

            switch (id) {
                case 1:
                    this.finCoccionEmpleado1.simularDemora(this.relojSimulacion, this.rand.NextDouble(), tipoPedido, cantidad);
                   
                    //this.agregarEventoAGrilla(i, true, this.finCoccionEmpleado1, 1);
                    //this.agregarDatosAGrila(i, this.finCoccionEmpleado1.getNombreEvento());
                    setGrillaEmpleados(1, i, true, this.finCoccionEmpleado1);

                    break;
                case 2:
                    this.finCoccionEmpleado2.simularDemora(this.relojSimulacion, this.rand.NextDouble(), tipoPedido, cantidad);
                    this.agregarEventoAGrilla(i, true, this.finCoccionEmpleado2, 2);
                    this.agregarDatosAGrila(i, this.finCoccionEmpleado2.getNombreEvento());

                    break;
                case 3:
                    this.finCoccionEmpleado3.simularDemora(this.relojSimulacion, this.rand.NextDouble(), tipoPedido, cantidad);
                    this.agregarEventoAGrilla(i, true, this.finCoccionEmpleado3, 3);
                    this.agregarDatosAGrila(i, this.finCoccionEmpleado3.getNombreEvento());
                    break;
            }
           
            //this.agregarSurtidoresAGrilla(i);
        }

       
        public void tomarDatosPatalla()
        {
            this.tiempoFinCorrida = Convert.ToDouble(this.txtTiempoSim.Text);
            this.tiempoAPartirDeDondeMostrar = Convert.ToDouble(this.txtMinDesde.Text);
            this.cantidadDeEventosAMostrar = Convert.ToInt32(this.txtNEventosMostrar.Text);
            this.mediaLlegadaPedidos = Convert.ToDouble(this.txtLlegadaConbustible.Text);
            this.mediaLlegadaGas = Convert.ToDouble(this.txtLlegadaGas.Text);
            this.colaMaxima = Convert.ToInt32(this.txtColaMax.Text);
            this.valorAUniformeFinCombustible = Convert.ToDouble(this.txtFinCombustibleDesde.Text);
            this.valorBUniformeFinCombustible = Convert.ToDouble(this.txtFinCombustibleHasta.Text);
            this.valorAUniformeFinGas = Convert.ToDouble(this.txtFinGasDesde.Text);
            this.valorBUniformeFinGas = Convert.ToDouble(this.txtFinGasHasta.Text);
            this.cteSumadaAUniformeGas = Convert.ToDouble(this.txtFinGasCte.Text);
        }

        public void inicializarVariables()
        {
            this.relojSimulacion = 0.0;
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
            this.finCoccionEmpleado1 = new FinCoccionEmpleado(0, 0, 1, empleado1);
            this.finCoccionEmpleado2 = new FinCoccionEmpleado(0, 0, 2, empleado2);
            this.finCoccionEmpleado3 = new FinCoccionEmpleado(0, 0, 3, empleado3);
            this.colaPreparacion = new ColaPreparacion();
            this.finDelivery = new FinDelivery(this.valorAUniformeFinGas, this.valorBUniformeFinGas, 1, this.cteSumadaAUniformeGas);
           
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
                //dgvResultados.Rows[i].Cells["colRNDFinGas"].Value = "-";
                //dgvResultados.Rows[i].Cells["colTiempoFinGas"].Value = "-";

                //if (conRandom)
                //{
                //    dgvResultados.Rows[i].Cells["colRNDFinGas"].Value = ((FinDelivery)evento).getRandom();
                //    dgvResultados.Rows[i].Cells["colTiempoFinGas"].Value = ((FinDelivery)evento).getTiempoEntreLlegada();

                //}
                //switch (idEmpleado)
                //{
                //    case 1:
                //        dgvResultados.Rows[i].Cells["colFinGasServ1"].Value = "-";
                //        if (((FinDelivery)evento).getProximaLlegada() != 0)
                //        {
                //            dgvResultados.Rows[i].Cells["colFinGasServ1"].Value = ((FinDelivery)evento).getProximaLlegada();
                //        }
                //        break;
                //    case 2:
                //        dgvResultados.Rows[i].Cells["colFinGasServ2"].Value = "-";
                //        if (((FinDelivery)evento).getProximaLlegada() != 0)
                //        {
                //            dgvResultados.Rows[i].Cells["colFinGasServ2"].Value = ((FinDelivery)evento).getProximaLlegada();
                //        }

                //        break;
                //    case 3:
                //        dgvResultados.Rows[i].Cells["colFinGasServ3"].Value = "-";
                //        if (((FinDelivery)evento).getProximaLlegada() != 0)
                //        {
                //            dgvResultados.Rows[i].Cells["colFinGasServ3"].Value = ((FinDelivery)evento).getProximaLlegada();
                //        }

                //        break;

                //}


            }

        }

        private void agregarFinCoccion(int i)
        {
            //int k = this.dgvResultados.Rows.Add();
            this.agregarDatosAGrila(i, finCoccionEmpleado1.getNombreEvento());
        }
        private void setGrillaEmpleados(int id, int i, bool conRandom, Evento evento)
        {
            dgvResultados.Rows[i].Cells["colEstadoEmpleado"+id].Value = "Libre";
            dgvResultados.Rows[i].Cells["colRndDemora"+id].Value = "-";
            dgvResultados.Rows[i].Cells["colDemora" + id].Value = "-";
            dgvResultados.Rows[i].Cells["colFinCoccion" + id].Value = "-";

            if (conRandom)
            {
                dgvResultados.Rows[i].Cells["colEstadoEmpleado" + id].Value = ((FinCoccionEmpleado)evento).Empleado.getEstado();
                dgvResultados.Rows[i].Cells["colRndDemora" + id].Value = ((FinCoccionEmpleado)evento).getRandom();
                dgvResultados.Rows[i].Cells["colDemora" + id].Value = ((FinCoccionEmpleado)evento).Empleado.getDemora();
                dgvResultados.Rows[i].Cells["colFinCoccion" + id].Value = ((FinCoccionEmpleado)evento).Empleado.getFinCoccion();
            }
        }

        private void agregarSurtidoresAGrilla(int i)//Graficar Los Surtidores
        {
            //this.dgvResultados.Rows[i].Cells["colEstadoCombSurt1"].Value = this.empleado1.Estado.ToString();
            //this.dgvResultados.Rows[i].Cells["colEstadoCombSurt2"].Value = this.empleado2.Estado.ToString();
            //this.dgvResultados.Rows[i].Cells["colEstadoCombSurt3"].Value = this.empleado3.Estado.ToString();
            //this.dgvResultados.Rows[i].Cells["colColaCombSurt1"].Value = this.empleado1.tamañoCola();
            //this.dgvResultados.Rows[i].Cells["colColaCombSurt2"].Value = this.empleado2.tamañoCola();
            //this.dgvResultados.Rows[i].Cells["colColaCombSurt3"].Value = this.empleado3.tamañoCola();
            this.dgvResultados.Rows[i].Cells["colInicioOcioCombSurt1"].Value = "-";

            //Los tiempos de ocio de Combustible

            dgvResultados.Rows[i].Cells["colInicioOcioCombSurt1"].Value = "-";
            if (this.empleado1.getHoraInicioOcio() != -1.00)
            {
                dgvResultados.Rows[i].Cells["colInicioOcioCombSurt1"].Value = this.empleado1.getHoraInicioOcio();
            }
            dgvResultados.Rows[i].Cells["colInicioOcioCombSurt2"].Value = "-";
            if (this.empleado2.getHoraInicioOcio() != -1.00)
            {
                dgvResultados.Rows[i].Cells["colInicioOcioCombSurt2"].Value = this.empleado2.getHoraInicioOcio();
            }
            dgvResultados.Rows[i].Cells["colInicioOcioCombSurt3"].Value = "-";
            if (this.empleado3.getHoraInicioOcio() != -1.00)
            {
                dgvResultados.Rows[i].Cells["colInicioOcioCombSurt3"].Value = this.empleado3.getHoraInicioOcio();
            }
            dgvResultados.Rows[i].Cells["colInicioOcioCombSurt4"].Value = "-";

        }

        private void agregarDatosAGrila(int i, string evento)
        {
            //Mostrar datos de la simulacion y estadisticas
            dgvResultados.Rows[i].Cells["colEvento"].Value = evento;
            dgvResultados.Rows[i].Cells["colReloj"].Value = relojSimulacion;
            
            /*
            dgvResultados.Rows[i].Cells["colAcumOcioCombSurt"].Value = AcumTiempoOcioServidoresCombustible;
            dgvResultados.Rows[i].Cells["colAcumOcioGasSurt"].Value = AcumTiempoOcioServidoresGas;
            dgvResultados.Rows[i].Cells["colAcumCombIngresados"].Value = ContVehiculosCombustibleIngresanAlSitema;
            dgvResultados.Rows[i].Cells["colAcumGasIngresaron"].Value = ContVehiculosGasIngresanAlSitema;
            dgvResultados.Rows[i].Cells["colAcumCombRechazados"].Value = ContVehiculosCombustibleRechazados;
            dgvResultados.Rows[i].Cells["colAcumGasRechazados"].Value = ContVehiculosGasRechazados;
            dgvResultados.Rows[i].Cells["colAcumCombAtendidos"].Value = ContVehiculosCombustibleAtendidos;
            dgvResultados.Rows[i].Cells["colAcumGasAtendidos"].Value = ContVehiculosGasAtendidos;
            dgvResultados.Rows[i].Cells["colAcumTiempoEsperaComb"].Value = AcumTiempoEsperaVehiculosCombustible;
            dgvResultados.Rows[i].Cells["colAcumTiempoEsperaGas"].Value = AcumTiempoEsperaVehiculosGas;
            dgvResultados.Rows[i].Cells["colAcumOcioCombSurt"].Value = AcumTiempoOcioServidoresCombustible;
            dgvResultados.Rows[i].Cells["colAcumOcioGasSurt"].Value = AcumTiempoOcioServidoresGas;
            dgvResultados.Rows[i].Cells["colContVehiculosEsperaronComb"].Value = ContVehiConTiempoEsperaVehiculosCombustible;
            dgvResultados.Rows[i].Cells["colContVehiculosEsperaronGas"].Value = ContVehiConTiempoEsperaVehiculosGas;
           
            */
        }
        private void agregarColumnasAGrilla(int identificadorVehiculo)
        {
            int i;
            i = dgvResultados.Columns.Add("EstadoVehi" + identificadorVehiculo, "Estado Vehiculos" + identificadorVehiculo);
            dgvResultados.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            i = dgvResultados.Columns.Add("colHoraInicioEsperaVehiculo" + identificadorVehiculo, "Hora Inicio Espera Vehiculo" + identificadorVehiculo);
            dgvResultados.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;

        }
        
        private void agregarPedidoAGrilla(Pedido pedido, int i)
        {
            if (pedido != null)
            {
                try
                {
                    dgvResultados.Rows[i].Cells[pedido.Id].Value = pedido.Estado;
                    dgvResultados.Rows[i].Cells[pedido.Id.Replace("EstadoVehi", "colHoraInicioEsperaVehiculo")].Value = Math.Round(pedido.getInicioEspera(), 2);
                    if (pedido.getInicioEspera() <= 0)
                    {
                        dgvResultados.Rows[i].Cells[pedido.Id.Replace("EstadoVehi", "colHoraInicioEsperaVehiculo")].Value = "-";

                    }
                }
                catch (Exception ex)
                {
                    agregarColumnasAGrilla(int.Parse(pedido.Id.Replace("EstadoVehi", "")));
                    dgvResultados.Rows[i].Cells[pedido.Id].Value = pedido.Estado;
                    dgvResultados.Rows[i].Cells[pedido.Id.Replace("EstadoVehi", "colHoraInicioEsperaVehiculo")].Value = Math.Round(pedido.getInicioEspera(), 2);
                    if (pedido.getInicioEspera() <= 0)
                    {
                        dgvResultados.Rows[i].Cells[pedido.Id.Replace("EstadoVehi", "colHoraInicioEsperaVehiculo")].Value = "-";

                    }
                }
            }

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

            //Poner Valores Originales en texbox
            txtColaMax.Text = "2";
            txtFinCombustibleDesde.Text = "3";
            txtFinCombustibleHasta.Text = "7";
            txtFinGasCte.Text = "5";
            txtFinGasDesde.Text = "3";
            txtFinGasHasta.Text = "7";
            txtLlegadaConbustible.Text = "3";
            txtLlegadaGas.Text = "7";
            txtMinDesde.Text = "0";
            txtNEventosMostrar.Text = "10";
            txtPorcenAutosAtendidos.Text = "0.00";
            txtPorcenAutosCombAtendidos.Text = "0.00";
            txtPorcenAutosGasAtendidos.Text = "0.00";
            txtPromTiempoOcioSurt.Text = "0.00";
            txtPromTiempoOcioSurtComb.Text = "0.00";
            txtPromTiempoOcioSurtGas.Text = "0.00";
            txtTiempoPromEsperaVehi.Text = "0.00";
            txtTiempoPromEsperaVehiComb.Text = "0.00";
            txtTiempoPromEsperaVehiGas.Text = "0.00";
            txtTiempoSim.Text = "60";
            txtTotalCombRechazados.Text = "0";
            txtTotalCombustibleIngresados.Text = "0";
            txtTotalGasIngresados.Text = "0";
            txtTotalGasRechazados.Text = "0";
            txtTotalIngresados.Text = "0";
            txtTotalRechazados.Text = "0";


            //Sacar Color A resultados
            darFormatoATodos(false);

            //Reset a variables
            resul = true;
            invalido = null;
            identificadorPedido = 0;
            relojSimulacion = 0.00;


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

        private void darFormatoATodos(bool formato)
        {
            darFormato(txtPorcenAutosAtendidos, formato);
            darFormato(txtPorcenAutosCombAtendidos, formato);
            darFormato(txtPorcenAutosGasAtendidos, formato);
            darFormato(txtPromTiempoOcioSurt, formato);
            darFormato(txtPromTiempoOcioSurtComb, formato);
            darFormato(txtPromTiempoOcioSurtGas, formato);
            darFormato(txtTiempoPromEsperaVehi, formato);
            darFormato(txtTiempoPromEsperaVehiComb, formato);
            darFormato(txtTiempoPromEsperaVehiGas, formato);
            darFormato(txtTotalCombRechazados, formato);
            darFormato(txtTotalCombustibleIngresados, formato);
            darFormato(txtTotalGasIngresados, formato);
            darFormato(txtTotalGasRechazados, formato);
            darFormato(txtTotalIngresados, formato);
            darFormato(txtTotalRechazados, formato);
        }

    }
}
