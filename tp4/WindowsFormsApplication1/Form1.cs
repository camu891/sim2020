﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class TP4 : Form
    {
        double desde = 0;
        double hasta = 0;
        double demora = 0;
        double cantDias = 0;
        double consumoMañana = 0;
        double consumoTarde = 0;
        double ventaMañana = 0;
        double ventaTarde = 0;
        double ingresoMañana = 0;
        double ingresoTarde = 0;
        double costoCompra = 0;
        double stockGr = 0;
        double stockFrascos = 0;
        double stockGrAcu = 0;
        double stockFrascosAcu = 0;
        double cantFaltaMañana = 0;
        double cantFaltaTarde = 0;
        double cantFaltanteAcu = 0;
        double porcHorasPerd = 0;
        double promCantGr = 0;
        double promCantFrasco = 0;
        double promCantFaltante = 0;
        double costoFalta = 0;

        // datos parametrizados
        double cantComprada = 0;
        double cadaCuantoComprar = 0;
        double cantMaxAlmacenar = 0;
        double precioCompra = 0;
        double precioVenta = 0;
        double gramosxFrasco = 0;
        double horasxTurno = 0;

        //generador
        private Generador generador;
        List<NroRandom> lst= new List<NroRandom>();
        NroRandom rnd;

        public TP4()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
        public void getPoliticasCompra()
        {
            if (pol_10Fras.Checked)
            {
                cantMaxAlmacenar = 10;
            }
            if (pol_20fras.Checked)
            {
                cantMaxAlmacenar = 20;
            }
            if (pol_2dias.Checked)
            {
                cadaCuantoComprar = 2;
            }
            if (pol_3dias.Checked)
            {
                cadaCuantoComprar = 3;
            }
            if (pol_2Fras.Checked)
            {
                cantComprada = 2;
            }
            if (pol_3Fras.Checked)
            {
                cantComprada = 3;
            }
        }

        private void demoraEntregaPedido(double RND)
        {

            if (RND >= 0.00 && RND < 0.50)
            {
                demora = 0;
                return;
            }
            if (RND >= 0.50 && RND < 0.75)
            {
                demora = 1;
                return;
            }
            if (RND >= 0.75)
            {
                demora = 2;
                return;
            }

        }

        private void calcularConsumoMañana(double RND)
        {

            if (RND >= 0.00 && RND < 0.50)
            {
                consumoMañana = 50;
                return;
            }
            else
            {
                //TODO aplicar formula correcta
                consumoMañana = Math.Round(60 +(RND *30), 4);
                return;
            }

        }

        private void calcularConsumoTarde(double RND)
        {
            if (RND == 1)
            {
                consumoTarde = Math.Round(-70 * (Math.Log(1 - 0.9999)), 4);
            }
            else
            {
                consumoTarde = Math.Round(-70 * (Math.Log(1 - RND)), 4);
            }

        }

        private void btn_generarSimulacion_Click(object sender, EventArgs e)
        {
            // tomar datos precios
            precioCompra = Convert.ToDouble(txt_precCompra.Text);
            precioCompra = Math.Round(precioCompra, 2);
            precioVenta = Convert.ToDouble(txt_precVenta.Text)/100;
            precioVenta = Math.Round(precioVenta, 2);
            horasxTurno = Convert.ToDouble(txt_horasTurno.Text);
            horasxTurno = Math.Round(horasxTurno, 2);
            gramosxFrasco = Convert.ToDouble(txt_gramosFrasco.Text);
            gramosxFrasco = Math.Round(gramosxFrasco, 2);

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
            double diaLlegadaPedido = 0;
            DataTable dt = getColumnName();
            Random RND = new Random();
            //variab auxiliar para los randoms congruenciales
            int aux = 0;
            // Inicio Fila 0 (cero)
           
            double RNDDem0 = 0;
            if (pol_Leng.Checked)
            {
                RNDDem0 = Math.Round(RND.NextDouble(), 4);
            }
            else
            {
                if (aux == 0)
                {
                    generador = new Generador(int.Parse(txtA.Text), int.Parse(txtC.Text), int.Parse(txtM.Text));
                    rnd = generador.mixto(int.Parse(txtX.Text));
                    rnd.Posicion = lst.Count + 1;
                    lst.Add(rnd);
                    RNDDem0 = Math.Round(rnd.Random, 4);
                    aux = 1;
                }
                else
                {
                    rnd = generador.mixto(lst.Last().Siguiente);
                    rnd.Posicion = lst.Count + 1;
                    lst.Add(rnd);
                    RNDDem0 = Math.Round(rnd.Random, 4);
                }

            }

            demoraEntregaPedido(RNDDem0);
            costoCompra = cantComprada * precioCompra;
            if (demora == 0)
            {
                actualizarStock();
            } else
            {
                diaLlegadaPedido = demora;
            }
            if (desde == 0)
            {
                DataRow dr0 = dt.NewRow();
                dr0["NroDia"] = 0;
                dr0["RND compra"] = RNDDem0;
                dr0["Demora Compra"] = demora;
                dr0["Costo Compra"] = costoCompra;
                dr0["Stock Gr"] = stockGr;
                dr0["Stock Frasco"] = stockFrascos;
                dt.Rows.Add(dr0);
            }
            // Fin de fila 0 y comienzo de las demas filas

            for (int i = 1; i <= cantDias; i++)
            {
                if (i == diaLlegadaPedido)
                {
                    actualizarStock();
                }
                
                double RNDDem = 0;
                double RNDConMa = 0;
                double RNDConTa = 0;

                if (pol_Leng.Checked)
                {
                    RNDDem = Math.Round(RND.NextDouble(), 4);
                    RNDConMa = Math.Round(RND.NextDouble(), 4);
                    RNDConTa = Math.Round(RND.NextDouble(), 4);
                }
                else
                {
                    if (aux == 0)
                    {
                        generador = new Generador(int.Parse(txtA.Text), int.Parse(txtC.Text), int.Parse(txtM.Text));
                        rnd = generador.mixto(int.Parse(txtX.Text));
                        rnd.Posicion = lst.Count + 1;
                        lst.Add(rnd);
                        RNDDem  = Math.Round(rnd.Random, 4);
                        rnd = generador.mixto(lst.Last().Siguiente);
                        rnd.Posicion = lst.Count + 1;
                        lst.Add(rnd);
                        RNDConMa = Math.Round(rnd.Random, 4);
                        rnd = generador.mixto(lst.Last().Siguiente);
                        rnd.Posicion = lst.Count + 1;
                        lst.Add(rnd);
                        RNDConTa = Math.Round(rnd.Random, 4);
                        aux = 1;
                    }
                    else
                    {
                        rnd = generador.mixto(lst.Last().Siguiente);
                        rnd.Posicion = lst.Count + 1;
                        lst.Add(rnd);
                        RNDDem = Math.Round(rnd.Random, 4);
                        rnd = generador.mixto(lst.Last().Siguiente);
                        rnd.Posicion = lst.Count + 1;
                        lst.Add(rnd);
                        RNDConMa = Math.Round(rnd.Random, 4);
                        rnd = generador.mixto(lst.Last().Siguiente);
                        rnd.Posicion = lst.Count + 1;
                        lst.Add(rnd);
                        RNDConTa = Math.Round(rnd.Random, 4);
                    }

                }
                Boolean sepide = false;
                if (i % cadaCuantoComprar == 0)
                {
                    sepide = true;
                    demoraEntregaPedido(RNDDem);
                    costoCompra = cantComprada * precioCompra;
                    if (demora == 0)
                    {
                        actualizarStock();
                    }
                    else
                    {
                        diaLlegadaPedido = i + demora;
                    }
                }

               
                
                calcularConsumoMañana(RNDConMa);
                calcularConsumoTarde(RNDConTa);
                calcularVentaMañana();
                calcularVentaTarde();
                costoYAcuFaltante();
                calcularHorasPerdidas(i);
                calcularPromediosAlamcen(i);


                if (i >= desde && i <= hasta)
                {
                    DataRow dr = dt.NewRow();
                    // Carga datos
                    dr["NroDia"] = i;
                    if (sepide)
                    {
                        dr["RND compra"] = RNDDem;
                        dr["Demora Compra"] = demora;
                        dr["Costo Compra"] = costoCompra;
                    }
                    dr["RND consu M"] = RNDConMa;
                    dr["Consumo Mañana (gr)"] = consumoMañana;
                    dr["Cantidad vendida M (gr)"] = ventaMañana;
                    dr["Ingreso Mañana $"] = ingresoMañana;
                    dr["Cant faltante mañana"] = cantFaltaMañana;
                    dr["RND consu T"] = RNDConTa;
                    dr["Consumo Tarde (gr)"] = consumoTarde;
                    dr["Cantidad Vendida T (gr)"] = ventaTarde;
                    dr["Ingreso Tarde $"] = ingresoTarde;
                    dr["Cant faltante tarde"] = cantFaltaTarde;
                    dr["Stock Gr"] = stockGr;
                    dr["Stock Frasco"] = stockFrascos;
                    dr["Costo Faltante Total"] = costoFalta;
                    dr["Porcentaje Hs perdidas"] = porcHorasPerd;
                    dr["Prom Cant Cafe almacen Gr"] = promCantGr;
                    dr["Prom Cant Cafe almacen Frascos"] = promCantFrasco;
                    dr["Prom Cant faltante Gr"] = promCantFaltante;
                    //TODO columnas faltantes
                    /*dr["Ingreso Prom"] = "";
                    dr["Beneficio Diario"] = "";
                    dr["Beneficio Prom"] = "";
                    dr["Cant dias con faltantes"] = "";
                    dr["% dias con faltantes"] = "";
                    dr["cant sobrante <2"] = "";
                    dr["% sobrante <2"] = "";
                    dr["cant sobrante 2<x<5"] = "";
                    dr["% sobrante 2<x<5"] = "";
                    dr["cant sobrante 5<x<8"] = "";
                    dr["% sobrante 5<x<8"] = "";
                    dr["cant sobrante >8"] = "";
                    dr["% sobrante >8"] = "";
                    */
                    dt.Rows.Add(dr);
                    
                }
                costoCompra = 0;
            }
           
            lbl_resultados.Text = "Promedio de cafe faltante: " + promCantFaltante + " gr" + ", Promedio de cafe Almacenado: " + promCantFrasco + " frascos";
            lbl_resultados_D.Text = "Porcentaje de horas perdidas: " + porcHorasPerd + " hs";

            this.dgv_simulacion.DataSource = dt;
            //this.colorColumnas();
        }

        public void calcularVentaMañana()
        {
            if (stockGr >= consumoMañana)
            {
                ventaMañana = consumoMañana;
                ingresoMañana = Math.Round(consumoMañana * precioVenta, 4);
                stockGr = stockGr - consumoMañana;
                stockFrascos = Math.Round(stockGr /gramosxFrasco, 4);
            }
            else
            {
                cantFaltaMañana = Math.Round(consumoMañana - stockGr, 4);
                ventaMañana = stockGr;
                ingresoMañana = Math.Round(stockGr * precioVenta, 4);
                stockGr = 0;
                stockFrascos = 0;
            }
        }

        public void calcularVentaTarde()
        {
            if (stockGr >= consumoTarde)
            {
                ventaTarde = consumoTarde;
                ingresoTarde = Math.Round(consumoTarde * precioVenta, 4);
                stockGr = Math.Round(stockGr - consumoTarde, 4);
                stockFrascos = Math.Round(stockGr / gramosxFrasco, 4);
                stockGrAcu += stockGr;
                stockFrascosAcu += stockFrascos;
            }
            else
            {
                cantFaltaTarde = Math.Round(consumoTarde - stockGr, 4);
                ventaTarde = stockGr;
                ingresoTarde = Math.Round(stockGr * precioVenta, 4);
                stockGr = 0;
                stockFrascos = 0;
                stockGrAcu += stockGr;
                stockFrascosAcu += stockFrascos;
            }
        }

        public void actualizarStock()
        {
            if ((stockFrascos + cantComprada) <= cantMaxAlmacenar)
            {
                stockFrascos += cantComprada;
                stockGr += Math.Round(cantComprada * gramosxFrasco, 4);
            } else
            {
                stockFrascos = cantMaxAlmacenar;
                stockGr = Math.Round(cantMaxAlmacenar * gramosxFrasco, 4);
            }
        }

        public void costoYAcuFaltante()
        {
            //El costo faltante es $1 x gramo
            costoFalta += Math.Round(cantFaltaTarde + cantFaltaMañana, 4);
            cantFaltanteAcu += Math.Round(cantFaltaTarde + cantFaltaMañana, 4);
        }

        public void calcularHorasPerdidas(int i)
        {
            if ((cantFaltaTarde + cantFaltaMañana) > 0)
            {
                //faltante *16 /consumo total
                //TODO validar si se debe agregar acumulados de faltante y consumo
                porcHorasPerd = (cantFaltaTarde + cantFaltaMañana) * (horasxTurno * 2)  / (consumoMañana + consumoTarde);
                porcHorasPerd = Math.Round(porcHorasPerd, 4);
            }
        }

        public void calcularPromediosAlamcen(int i)
        {
            promCantGr = Math.Round(stockGrAcu / i, 4);
            promCantFrasco = Math.Round(stockFrascosAcu / i, 4);
            promCantFaltante = Math.Round(cantFaltanteAcu / i, 4);
        }

        public void limpiarDatos()
        {
            desde = 0;
            hasta = 0;
            demora = 0;
            cantDias = 0;
            consumoMañana = 0;
            consumoTarde = 0;
            ventaMañana = 0;
            ventaTarde = 0;
            ingresoMañana = 0;
            ingresoTarde = 0;
            costoCompra = 0;
            stockGr = 0;
            stockFrascos = 0;
            stockGrAcu = 0;
            stockFrascosAcu = 0;
            cantFaltaMañana = 0;
            cantFaltaTarde = 0;
            cantFaltanteAcu = 0;
            porcHorasPerd = 0;
            promCantGr = 0;
            promCantFrasco = 0;
            promCantFaltante = 0;
            costoFalta = 0;
        }

        private void colorColumnas()
        {
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
            if (cantComprada <= 0 || cadaCuantoComprar <=0 || cantMaxAlmacenar <= 0)
            {
                MessageBox.Show("Debe elegir alguna politica");
                return false;
            }


            if (txt_cantDias.Text == "")
            {
                MessageBox.Show("Debe ingresar la cantidad de dias");
                return false;
            }
            if (txt_desde.Text == "")
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

            if (desde >= hasta)
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
            if (txt_precVenta.Enabled == true)
            {
                txt_precVenta.Enabled = false;
                txt_gramosFrasco.Enabled = false;
                txt_precCompra.Enabled = false;
                txt_horasTurno.Enabled = false;
            }
            else
            {
                txt_precVenta.Enabled = true;
                txt_gramosFrasco.Enabled = true;
                txt_precCompra.Enabled = true;
                txt_horasTurno.Enabled = true;
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

        private DataTable getColumnName() {
            DataTable dt = new DataTable();
            dt.Columns.Add("NroDia");
            dt.Columns.Add("RND compra");
            dt.Columns.Add("Demora Compra");
            dt.Columns.Add("Costo Compra");
            dt.Columns.Add("RND consu M");
            dt.Columns.Add("Consumo Mañana (gr)");
            dt.Columns.Add("Cantidad vendida M (gr)");
            dt.Columns.Add("Ingreso Mañana $");
            dt.Columns.Add("Cant faltante mañana");
            dt.Columns.Add("RND consu T");
            dt.Columns.Add("Consumo Tarde (gr)");
            dt.Columns.Add("Cantidad Vendida T (gr)");
            dt.Columns.Add("Ingreso Tarde $");
            dt.Columns.Add("Cant faltante tarde");
            dt.Columns.Add("Stock Gr");
            dt.Columns.Add("Stock Frasco");
            dt.Columns.Add("Costo Faltante Total");
            dt.Columns.Add("Porcentaje Hs perdidas");
            dt.Columns.Add("Prom Cant Cafe almacen Gr");
            dt.Columns.Add("Prom Cant Cafe almacen Frascos");
            dt.Columns.Add("Prom Cant faltante Gr");
            /*
            dt.Columns.Add("Ingreso Prom");
            dt.Columns.Add("Beneficio Diario");
            dt.Columns.Add("Beneficio Prom");
            dt.Columns.Add("Cant dias con faltantes");
            dt.Columns.Add("% dias con faltantes");
            dt.Columns.Add("cant sobrante <2");
            dt.Columns.Add("% sobrante <2");
            dt.Columns.Add("cant sobrante 2<x<5");
            dt.Columns.Add("% sobrante 2<x<5");
            dt.Columns.Add("cant sobrante 5<x<8");
            dt.Columns.Add("% sobrante 5<x<8");
            dt.Columns.Add("cant sobrante >8");
            dt.Columns.Add("% sobrante >8");
            */
            return dt;
        }
    }
}

