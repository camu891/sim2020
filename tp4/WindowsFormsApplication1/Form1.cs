﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        // cantidades 
        double rosasVendidas = 0;
        double rosasCementerio = 0;
        double rosasFaltantes = 0;
        //Rango
        double desde = 0;
        double hasta = 0;
           string dia= "";
          double cantDias = 0;
        // calculos
          double promedioDia = 0;
          double gananciaPromedio = 0;
          double gananciaPromedio_D = 0;
           double venta = 0;
           double gananciaSobrante = 0;
           double gananciaTotal = 0;
           double costoCompra = 0;
           double ks = 0;
           double ks_D = 0;
           double costoTotal = 0;
           double costoTotal_D = 0;
           double gananciaDiaria = 0;
           double gananciaDiaria_D = 0;
           double acumGananciaDiaria = 0;
           double acumGananciaDiaria_D = 0;
           double promedio = 0;
           double promedio_D = 0;
        double demanda = 0;
        
        // datos parametrizados
        double cantCajones = 0;
        double cantComprada = 0;
        double precioCompra = 0;
        double precioVenta = 0;
        double precioVentaCementerio = 0;
        double precioCompraExcedente_PtoD = 0;
        double costoFalta = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        
       }
        public void getPoliticasCompra()
        {
            if (rb_Pa.Checked)
            {
                 cantComprada = 12;
                 cantCajones = 3;
                 costoCompra = cantComprada * precioCompra;
                 lbl_resultados.Text = "  la ganancia promedio en el pto A es: ";
                 return;
            }
            if (rb_Pb2.Checked)
            {
                 cantComprada = 8;
                 cantCajones = 2;
                 lbl_resultados.Text = "  la ganancia promedio en el pto B.2  es: ";
                 costoCompra = cantComprada * precioCompra;
                 return;
            }
            if (rb_Pb1.Checked)
            {
                 cantComprada = 16;
                 cantCajones = 4;
                 lbl_resultados.Text = "  la ganancia promedio en el pto B.1  es: ";
                 costoCompra = cantComprada * precioCompra;
                 return;
            }

            if (rb_Pc.Checked)
            {
                cantComprada = 3;
                cantCajones = 0;
                lbl_resultados.Text = "  la ganancia promedio en el pto C es: ";
                
                return;
            }
            
        }

        private void rb_Pa_CheckedChanged(object sender, EventArgs e)
        {
            cantComprada = 12;
        }

        private void tipoDia(double RND,double RNDaux2)
        {

            if (RND >= 0.00 && RND < 0.67)
            {
                dia = "Soleado";
                demandaSoleado(RNDaux2);
                return;
            }
            if (RND >= 0.67 && RND < 0.99)
            {
                dia = "Nublado";
                demandaNublado(RNDaux2);
                return;
            }
      

        }
        private void demandaSoleado(double RND)
        {

            if (RND >= 0.00 && RND < 0.05)
            {
                demanda = 14;
                return;
            }
            if (RND >= 0.05 && RND < 0.25)
            {
                demanda = 17;
                return;
            }
            if (RND >= 0.25 && RND < 0.70)
            {
                demanda = 20;
                return;
            }
            if (RND >= 0.70 && RND < 1)
            {
                demanda = 24;
                return;
            }

        }

        private void demandaNublado(double RND)
        {

            if (RND >= 0.00 && RND < 0.05)
            {
                demanda = 9;
                return;
            }
            if (RND >= 0.05 && RND < 0.20)
            {
                demanda = 11;
                return;
            }
            if (RND >= 0.20 && RND < 0.55)
            {
                demanda = 14;
                return;
            }
            if (RND >= 0.55 && RND < 0.80)
            {
                demanda = 16;
                return;
            }
            if (RND >= 0.80 && RND < 1)
            {
                demanda = 20;
                return;
            }

        }

        private void btn_generarSimulacion_Click(object sender, EventArgs e)
        {
            // tomar datos precios
            precioCompra = Convert.ToDouble(txt_precCompra.Text) * 12;
            precioCompra = Math.Round(precioCompra, 2);
            precioVenta = Convert.ToDouble(txt_precVenta.Text) * 12;
            precioVenta = Math.Round(precioVenta, 2);
            precioVentaCementerio = Convert.ToDouble(txt_precCementerio.Text) * 12;
            precioVentaCementerio = Math.Round(precioVentaCementerio, 2);
            costoFalta = Convert.ToDouble(txt_precFaltante.Text) * 12;
            costoFalta = Math.Round(costoFalta, 2);

            precioCompraExcedente_PtoD = Convert.ToDouble(txt_precFaltante_PtoD.Text) * 12;

            precioCompraExcedente_PtoD = Math.Round(precioCompraExcedente_PtoD, 2);
                 
            
            
            limpiarDatos();
            // activar la opcion elegida en el radio button
            getPoliticasCompra();
            // verificar los datos que pasa el usuario
            controlDatos();

            if (controlDatos() == true)
            // generar grilla con los resultados
            generar_tablaSimulacion();
        }
        private void generar_tablaSimulacion()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("NroDia");
            dt.Columns.Add("RND");
            dt.Columns.Add("Tipo dia");
            dt.Columns.Add("RndDem");
            dt.Columns.Add("Docenas demandadas");
            dt.Columns.Add("Cajones comprados");
            dt.Columns.Add("Cantidad comprada X docena");
            dt.Columns.Add("Costo Compra X docena");
            dt.Columns.Add("Rosas vendidas");
            dt.Columns.Add("Ingreso venta");
            dt.Columns.Add("Rosas cementerio");
            dt.Columns.Add("Ingreso por el cementerio");
            dt.Columns.Add("Total ingresos");
            dt.Columns.Add("Rosas faltantes");
            dt.Columns.Add("Costo rosas faltantes");
            dt.Columns.Add("Costo Total");
            dt.Columns.Add("Ganancia diaria");
            dt.Columns.Add("Acumula ganancia diaria");
            dt.Columns.Add("Ganancia promedio");
            dt.Columns.Add("Rosas faltantes PtoD");
            dt.Columns.Add("Costo rosas faltantes PtoD");
            dt.Columns.Add("Costo Total PtoD");
            dt.Columns.Add("Ganancia diaria PtoD");
            dt.Columns.Add("Acumula ganancia diaria PtoD");
            dt.Columns.Add("Ganancia promedio PtoD");


            Random RND = new Random();


                // hago los calculos dependiendo el tipoPolitica elegida, si es igual a 3 es la policita del pto c , sino cualquiera
                // de las otras politicas

                //caso if de politica C
                if (cantComprada == 3)
                {
                    cantComprada = 8;

                    for (int i = 1; i <= cantDias; i++)
                    {
                        
                        // variables
                        double RNDaux = Math.Round(RND.NextDouble(), 4);
                        double RNDaux2 = Math.Round(RND.NextDouble(), 4);


                        // me devuelve si es soleado o nublado , a su vez calcula la demanda dependiendo del dia elegido
                        tipoDia(RNDaux, RNDaux2);


                        //calcular la venta
                        calcularGanancia();
                        // calcular la ganancia de lo que sobro , que se vendio al cementerio
                        //calcularGananciaSobrante();
                        //costo compra
                        costoCompra = cantComprada * precioCompra;
                        // calculo la ganancia toma de la suma de lo anterior
                        gananciaTotal = venta + gananciaSobrante;
                       
                        // calcular costo faltante
                        costoFaltante();
                        // suma costos
                        costoTotal = costoCompra + ks;
                        // obtener la ganancia diaria, segun lo que obtuve de costos y ganancias
                        gananciaDiaria = gananciaTotal - costoTotal;
                        gananciaDiaria = Math.Round(gananciaDiaria, 2);
                        // acumular la ganancia diaria , para sacar un promedio
                       
                        acumGananciaDiaria = gananciaDiaria + acumGananciaDiaria;
                       
                   
                   
                  
                        // calculos ptoD
                        // suma costos
                        costoTotal_D  = costoCompra + ks_D;
                        // total ganancia
                        gananciaDiaria_D = gananciaTotal - costoTotal_D;
                        gananciaDiaria_D = Math.Round(gananciaDiaria_D, 2);

                        acumGananciaDiaria_D = gananciaDiaria_D + acumGananciaDiaria_D;

                                      
                      

                       
                      

                        if (i >= desde && i <= hasta)
                        {

                            // Datos pasados a string para que no de problemas en grandes numeros     
                            //  string i1;
                            //  i1 = Convert.ToString(i);
                            //  string cantCajo;
                            //  cantCajo = Convert.ToString(cantCajones);
                            //  string cantCom;
                            //  cantCom = Convert.ToString(cantComprada);
                            string rosasV;
                            rosasV = Convert.ToString(rosasVendidas);
                            string rosasC;
                            rosasC = Convert.ToString(rosasCementerio);
                            string rosasF;
                            rosasF = Convert.ToString(rosasFaltantes);

                            string r2;
                            r2 = Convert.ToString(RNDaux2);
                            string k;
                            k = Convert.ToString(ks);
                            // string r1;
                            // r1 = Convert.ToString(RNDaux);
                            //string d;
                            //d = Convert.ToString(demanda);
                            string v;
                            v = Convert.ToString(venta);
                            string gs;
                            gs = Convert.ToString(gananciaSobrante);
                            string gt;
                            gt = Convert.ToString(gananciaTotal);
                            string cc;
                            cc = Convert.ToString(costoCompra);
                            string ct;
                            ct = Convert.ToString(costoTotal);
                            string gd;
                            gd = Convert.ToString(gananciaDiaria);
                            string acg;
                            acg = Convert.ToString(acumGananciaDiaria);

                            // ptoD

                            string kD;
                            kD = Convert.ToString(ks_D);
                            string ctD;
                            ctD = Convert.ToString(costoTotal_D);
                            string gdD;
                            gdD = Convert.ToString(gananciaDiaria_D);
                            string acgD;
                            acgD = Convert.ToString(acumGananciaDiaria_D);
                            
                            
                            gananciaPromedio = (acumGananciaDiaria / i);
                            gananciaPromedio = Math.Round(gananciaPromedio, 2);
                            string gananP;
                            gananP = Convert.ToString(gananciaPromedio);

                            // pto d
                            gananciaPromedio_D = (acumGananciaDiaria_D / i);
                            gananciaPromedio_D = Math.Round(gananciaPromedio_D, 2);
                            string gananPD;
                            gananPD = Convert.ToString(gananciaPromedio_D);

                            
                           
                            DataRow dr = dt.NewRow();
                            // Carga datos
                            dr["NroDia"] = i;
                            dr["RND"] = RNDaux;
                            dr["Tipo dia"] = dia;
                            dr["RndDem"] = r2;
                            dr["Docenas demandadas"] = demanda;
                            dr["Cajones comprados"] = cantCajones;
                            dr["Cantidad comprada X docena"] = cantComprada;
                            dr["Costo Compra X docena"] = cc;
                            dr["Rosas vendidas"] = rosasV;
                            dr["Ingreso venta"] = v;
                            dr["Rosas cementerio"] = rosasC;
                            dr["Ingreso por el cementerio"] = gs;
                            dr["Total ingresos"] = gt;
                            dr["Rosas faltantes"] = rosasF;
                            dr["Costo rosas faltantes"] = k;
                            dr["Costo Total"] = ct;
                            dr["ganancia diaria"] = gd;
                            dr["Acumula ganancia diaria"] = acg;
                            dr["Ganancia promedio"] = gananP;
                            dr["Rosas faltantes PtoD"] = rosasF;
                            dr["Costo rosas faltantes PtoD"] = kD;
                            dr["Costo Total PtoD"] = ctD;
                            dr["Ganancia diaria PtoD"] = gdD;
                            dr["Acumula ganancia diaria PtoD"] = acgD;
                            dr["Ganancia promedio PtoD"] = gananPD;

                            dt.Rows.Add(dr);


                        }




                        cantComprada = demanda;

                    }
                }
                else
                {


                    // recorre hasta que termine la cantida de dias
                    for (int i = 1; i <= cantDias; i++)
                    {
                        
                        // variables
                        double RNDaux = Math.Round(RND.NextDouble(), 4);
                        double RNDaux2 = Math.Round(RND.NextDouble(), 4);


                        // me devuelve si es soleado o nublado , a su vez calcula la demanda dependiendo del dia elegido
                        tipoDia(RNDaux, RNDaux2);


                        //calcular la venta
                        calcularGanancia();
                        // calcular la ganancia de lo que sobro , que se vendio al cementerio
                       // calcularGananciaSobrante();
                        // calculo la ganancia toma de la suma de lo anterior
                        gananciaTotal = venta + gananciaSobrante;
                    
                        // calcular costo faltante
                        costoFaltante();
                        // suma costos
                        costoTotal = costoCompra + ks;
                        // obtener la ganancia diaria, segun lo que obtuve de costos y ganancias
                        gananciaDiaria = gananciaTotal - costoTotal;
                        gananciaDiaria = Math.Round(gananciaDiaria, 2);
                        // acumular la ganancia diaria , para sacar un promedio

                        acumGananciaDiaria = gananciaDiaria + acumGananciaDiaria;




                        // calculos ptoD
                        // suma costos
                        costoTotal_D = costoCompra + ks_D;
                        // total ganancia
                        gananciaDiaria_D = gananciaTotal - costoTotal_D;
                        gananciaDiaria_D = Math.Round(gananciaDiaria_D, 2);

                        acumGananciaDiaria_D = gananciaDiaria_D + acumGananciaDiaria_D;



                        if (i >= desde && i <= hasta)
                        {

                            // Datos pasados a string para que no de problemas en grandes numeros     
                            //  string i1;
                            //  i1 = Convert.ToString(i);
                            // string cantCajo;
                            // cantCajo = Convert.ToString(cantCajones);
                            // string cantCom;
                            // cantCom = Convert.ToString(cantComprada);
                            string rosasV;
                            rosasV = Convert.ToString(rosasVendidas);
                            string rosasC;
                            rosasC = Convert.ToString(rosasCementerio);
                            string rosasF;
                            rosasF = Convert.ToString(rosasFaltantes);

                            string r2;
                            r2 = Convert.ToString(RNDaux2);
                            string k;
                            k = Convert.ToString(ks);
                            // string r1;
                            // r1 = Convert.ToString(RNDaux);
                            //  string d;
                            // d = Convert.ToString(demanda);
                            string v;
                            v = Convert.ToString(venta);
                            string gs;
                            gs = Convert.ToString(gananciaSobrante);
                            string gt;
                            gt = Convert.ToString(gananciaTotal);
                            string cc;
                            cc = Convert.ToString(costoCompra);
                            string ct;
                            ct = Convert.ToString(costoTotal);
                            string gd;
                            gd = Convert.ToString(gananciaDiaria);
                            string acg;
                            acg = Convert.ToString(acumGananciaDiaria);

                            // ptoD

                            string kD;
                            kD = Convert.ToString(ks_D);
                            string ctD;
                            ctD = Convert.ToString(costoTotal_D);
                            string gdD;
                            gdD = Convert.ToString(gananciaDiaria_D);
                            string acgD;
                            acgD = Convert.ToString(acumGananciaDiaria_D);

                            
                            gananciaPromedio = (acumGananciaDiaria / i);
                            gananciaPromedio = Math.Round(gananciaPromedio, 2);
                            string gananP;
                            gananP = Convert.ToString(gananciaPromedio);

                            // pto d
                            gananciaPromedio_D = (acumGananciaDiaria_D / i);
                            gananciaPromedio_D = Math.Round(gananciaPromedio_D, 2);
                            string gananPD;
                            gananPD = Convert.ToString(gananciaPromedio_D);



                            DataRow dr = dt.NewRow();
                            // Carga datos
                            dr["NroDia"] = i;
                            dr["RND"] = RNDaux;
                            dr["Tipo dia"] = dia;
                            dr["RndDem"] = r2;
                            dr["Docenas demandadas"] = demanda;
                            dr["Cajones comprados"] = cantCajones;
                            dr["Cantidad comprada X docena"] = cantComprada;
                            dr["Costo Compra X docena"] = cc;
                            dr["Rosas vendidas"] = rosasV;
                            dr["Ingreso venta"] = v;
                            dr["Rosas cementerio"] = rosasC;
                            dr["Ingreso por el cementerio"] = gs;
                            dr["Total ingresos"] = gt;
                            dr["Rosas faltantes"] = rosasF;
                            dr["Costo rosas faltantes"] = k;
                            dr["Costo Total"] = ct;
                            dr["ganancia diaria"] = gd;
                            dr["Acumula ganancia diaria"] = acg;
                            dr["Ganancia promedio"] = gananP;
                            dr["Rosas faltantes PtoD"] = rosasF;
                            dr["Costo rosas faltantes PtoD"] = kD;
                            dr["Costo Total PtoD"] = ctD;
                            dr["Ganancia diaria PtoD"] = gdD;
                            dr["Acumula ganancia diaria PtoD"] = acgD;
                            dr["Ganancia promedio PtoD"] = gananPD;

                            dt.Rows.Add(dr);


                        }

                    }

            }
                obtenerPromedio();
                lbl_resultados.Text =   lbl_resultados.Text + "$" + promedio;
                obtenerPromedio_ptoD();
                lbl_resultados_D.Text = "  la ganancia promedio en el pto D es: ";
                lbl_resultados_D.Text = lbl_resultados_D.Text + "$" + promedio_D;
                MessageBox.Show("Carga exitosa");

                this.dgv_simulacion.DataSource = dt;
                this.colorColumnas();
        }
        public void calcularGanancia()
        {
            if (demanda >= cantComprada)
            {
                venta = cantComprada * precioVenta;
                rosasVendidas = cantComprada * 12;
          
                // ganancia sobrante calcular y rosas cementerio
                gananciaSobrante = 0;
                rosasCementerio = 0;
 
            }
            else
            {
                venta = demanda * precioVenta;
                rosasVendidas = demanda * 12;
                // ganancia sobrante calcular y rosas cementerio
                rosasCementerio = (cantComprada - demanda) * 12;
                gananciaSobrante = (cantComprada - demanda) * precioVentaCementerio;
                gananciaSobrante = Math.Round(gananciaSobrante, 2);
            }
        }

    /*    public void calcularGananciaSobrante()
        {
            if ( cantComprada > demanda)
            {
                rosasCementerio = (cantComprada - demanda) *12;

                gananciaSobrante = (cantComprada - demanda) * precioVentaCementerio;
               gananciaSobrante = Math.Round(gananciaSobrante, 2);
            }
            else
            {
                gananciaSobrante = 0;
                rosasCementerio = 0;
            }
        }  */

        public void costoFaltante()
        {
            if (demanda > cantComprada)
            {
                rosasFaltantes = (demanda - cantComprada) * 12;
               
                ks = (demanda - cantComprada) * costoFalta;

                ks = Math.Round(ks, 2);
                // ptoD
                ks_D = (demanda - cantComprada) * precioCompraExcedente_PtoD;
                ks_D = Math.Round(ks_D, 2);
            }
            else
            {
                ks = 0;
                rosasFaltantes = 0;
                // ptoD
                ks_D = 0;
            }
        }

   

        public void obtenerPromedio()
        {
            if(cantDias>0)
            { promedio = acumGananciaDiaria / cantDias;

            promedio = Math.Round(promedio, 2);
            }  
        }
        public void obtenerPromedio_ptoD()
        {
            if (cantDias > 0)
            {
                promedio_D = acumGananciaDiaria_D / cantDias;

                promedio_D = Math.Round(promedio_D, 2);
            }
        }

        public void limpiarDatos()
        {
            rosasVendidas = 0;
           
            rosasFaltantes = 0;
            
            rosasCementerio = 0;
            desde = 0;
             hasta = 0;
             dia = "";
             cantDias = 0;
             venta = 0;
             gananciaSobrante = 0;
           gananciaTotal = 0;
             costoCompra = 0;
             ks = 0;
             costoTotal = 0;
             gananciaDiaria = 0;
            acumGananciaDiaria = 0;
             promedio = 0;
             demanda = 0;
             cantComprada = 0;

             gananciaPromedio = 0;


           // dgv_simulacion.Rows.Clear();

            //pto d
             ks_D = 0;
             costoTotal_D = 0;
             acumGananciaDiaria_D  =0;
             gananciaDiaria_D = 0;
             gananciaPromedio_D = 0;
               
        }

          private void colorColumnas()
        {
            // VERDULERIA
            Color ptoD = Color.LightGreen;


            dgv_simulacion.Columns[19].DefaultCellStyle.BackColor = ptoD;
            dgv_simulacion.Columns[20].DefaultCellStyle.BackColor = ptoD;
            dgv_simulacion.Columns[21].DefaultCellStyle.BackColor = ptoD;
            dgv_simulacion.Columns[22].DefaultCellStyle.BackColor = ptoD;
            dgv_simulacion.Columns[23].DefaultCellStyle.BackColor = ptoD;
            dgv_simulacion.Columns[24].DefaultCellStyle.BackColor = ptoD;
        }

        public bool controlDatos()
         {
        // control radio button
            if (cantComprada <= 0)
            {
                MessageBox.Show("Debe elegir alguna politica");
                return false;
            }
          
  
            if(txt_cantDias.Text == "")
                {
                    MessageBox.Show("Debe ingresar la cantida de dias");
                    return false;
               }
            if(txt_desde.Text=="")
            {
                MessageBox.Show("Debe ingresar valores en desde");
                return false;
            }
            if (txt_hasta.Text == "")
            {
                MessageBox.Show("Debe ingresar valores en hasta");
                return false;
            }

            // tomar la cantidad de dias
            cantDias = Convert.ToDouble(txt_cantDias.Text);
            // tomar rango
            desde = Convert.ToDouble(txt_desde.Text);
            hasta = Convert.ToDouble(txt_hasta.Text);

            if(desde >= hasta)
                {
                    MessageBox.Show("desde debe ser menor que hasta");
                    return false;
               }

          
            if (hasta > cantDias)
            {
                MessageBox.Show("hasta debe ser menor o igual que la cantidad de dias");
                return false;
            }

            return true;
        
         }

        // control de datos

        // para que solo ingrese numeros

        private void txt_desde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar) < 48 && e.KeyChar != 8) || e.KeyChar > 57)
            {
                MessageBox.Show("Sólo se permiten Números");
                e.Handled = true;
            }
        }

        private void txt_hasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar) < 48 && e.KeyChar != 8) || e.KeyChar > 57)
            {
                MessageBox.Show("Sólo se permiten Números");
                e.Handled = true;
            }
        }

        private void txt_cantDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar) < 48 && e.KeyChar != 8) || e.KeyChar > 57)
            {
                MessageBox.Show("Sólo se permiten Números");
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_precVenta.Enabled== true)
               {
                    txt_precVenta.Enabled = false;
                    txt_precFaltante.Enabled = false;
                    txt_precCompra.Enabled = false;
                    txt_precCementerio.Enabled = false;
                    txt_precFaltante_PtoD.Enabled = false;
               }
            else
                {
                    txt_precVenta.Enabled = true;
                    txt_precFaltante.Enabled = true;
                    txt_precCompra.Enabled = true;
                    txt_precCementerio.Enabled = true;
                    txt_precFaltante_PtoD.Enabled = true;
                }
        }

        private void txt_precVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar) < 48 && e.KeyChar != 8) || e.KeyChar > 57)
            {
                MessageBox.Show("Sólo se permiten Números");
                e.Handled = true;
            }
        }

        private void txt_precCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar) < 48 && e.KeyChar != 8) || e.KeyChar > 57)
            {
                MessageBox.Show("Sólo se permiten Números");
                e.Handled = true;
            }
        }

        private void txt_precCementerio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar) < 48 && e.KeyChar != 8) || e.KeyChar > 57)
            {
                MessageBox.Show("Sólo se permiten Números");
                e.Handled = true;
            }
        }

        private void txt_precFaltante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar) < 48 && e.KeyChar != 8) || e.KeyChar > 57)
            {
                MessageBox.Show("Sólo se permiten Números");
                e.Handled = true;
            }
        }

    
    
    
}
}

