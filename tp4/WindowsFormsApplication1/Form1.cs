using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        double desde = 0;
        double hasta = 0;
        double demora = 0;
        double cantDias = 0;
        double consumoMañana = 0;
        double consumoTarde = 0;
        double gananciaPromedio = 0;
        double gananciaPromedio_D = 0;
        double ventaMañana = 0;
        double ventaTarde = 0;
        double ingresoMañana = 0;
        double ingresoTarde = 0;
        double gananciaTotal = 0;
        double costoCompra = 0;
        double costoTotal = 0;
        double gananciaDiaria = 0;
        double acumGananciaDiaria = 0;
        double promedio = 0;
        double stockGr = 0;
        double stockFrascos = 0;
        double cantFaltaMañana = 0;
        double cantFaltaTarde = 0;
        double cantHorasPerdidas = 0;
        double porcHorasPerd = 0;

        // datos parametrizados
        double cantComprada = 0;
        double cadaCuantoComprar = 0;
        double cantMaxAlmacenar = 0;
        double precioCompra = 250;
        double precioVenta = 0;
        double costoFalta = 0;
        double gramosxFrasco = 0;
        double horasxTurno = 0;

        public Form1()
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
            if (RND >= 0.75 && RND < 1)
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
                consumoMañana = 60+(RND *30);
                return;
            }

        }

        private void calcularConsumoTarde(double RND)
        {
            consumoTarde = -70 * (Math.Log(1 - RND));

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
            double RNDDem0 = Math.Round(RND.NextDouble(), 4);
            demoraEntregaPedido(RNDDem0);
            costoCompra = cantComprada * precioCompra;
            if (demora == 0)
            {
                stockFrascos += cantComprada;
                stockGr += cantComprada * gramosxFrasco;
            } else
            {
                diaLlegadaPedido = demora;
            }
            DataRow dr0 = dt.NewRow();
            dr0["NroDia"] = 0;
            dr0["RND compra"] = RNDDem0;
            dr0["Demora Compra"] = demora;
            dr0["Costo Compra"] = costoCompra;
            dr0["Stock Gr"] = stockGr;
            dr0["Stock Frasco"] = stockFrascos;
            dt.Rows.Add(dr0);
            for (int i = 1; i <= cantDias; i++)
            {
                if (i == diaLlegadaPedido)
                {
                    stockFrascos += cantComprada;
                    stockGr += cantComprada * gramosxFrasco;
                }
                double RNDDem = Math.Round(RND.NextDouble(), 4);
                Boolean sepide = false;
                if (i % cadaCuantoComprar == 0)
                {
                    sepide = true;
                    demoraEntregaPedido(RNDDem);
                    costoCompra = cantComprada * precioCompra;
                    if (demora == 0)
                    {
                        stockFrascos += cantComprada;
                        stockGr += cantComprada * gramosxFrasco;
                    }
                    else
                    {
                        diaLlegadaPedido = i + demora;
                    }
                }

                double RNDConMa = Math.Round(RND.NextDouble(), 4);
                double RNDConTa = Math.Round(RND.NextDouble(), 4);
                calcularConsumoMañana(RNDConMa);
                calcularConsumoTarde(RNDConTa);
                calcularVentaMañana();
                calcularVentaTarde();
                costoFaltante();
                calcularHorasPerdidas(i);
                    // suma costos
                    costoTotal = costoCompra + costoFalta;
                    // obtener la ganancia diaria, segun lo que obtuve de costos y ganancias
                    gananciaDiaria = gananciaTotal - costoTotal;
                    gananciaDiaria = Math.Round(gananciaDiaria, 2);
                    // acumular la ganancia diaria , para sacar un promedio

                    acumGananciaDiaria = gananciaDiaria + acumGananciaDiaria;

                if (i >= desde && i <= hasta)
                {

                        gananciaPromedio = (acumGananciaDiaria / i);
                        gananciaPromedio = Math.Round(gananciaPromedio, 2);
                        string gananP;
                        gananP = Convert.ToString(gananciaPromedio);


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
                    dr["Costo Faltante Ac"] = costoFalta;
                    dr["Porcentaje Hs perdidas"] = porcHorasPerd;
                    //TODO columnas faltantes
                        dr["Prom Cant Cafe almacen Gr"] = gananP;
                        dr["Prom Cant Cafe almacen Frascos"] = gananP;
                        dr["Prom Cant faltante"] = gananP;
                        dr["Ingreso Prom"] = gananP;
                        dr["Beneficio Diario"] = gananP;
                        dr["Beneficio Prom"] = gananP;
                        dr["Cant dias con faltantes"] = gananP;
                        dr["% dias con faltantes"] = gananP;
                        dr["% sobrante <2"] = gananP;
                        dr["cant sobrante 2<x<5"] = gananP;
                        dr["% sobrante 2<x<5"] = gananP;
                        dr["cant sobrante 5<x<8"] = gananP;
                        dr["% sobrante 5<x<8"] = gananP;
                        dr["cant sobrante >8"] = gananP;
                        dr["% sobrante >8"] = gananP;
                        dt.Rows.Add(dr);
                }

            }
           
            obtenerPromedio();
            lbl_resultados.Text = lbl_resultados.Text + "$" + promedio;
            lbl_resultados_D.Text = "  la ganancia promedio en el pto D es: ";
            lbl_resultados_D.Text = lbl_resultados_D.Text;

            this.dgv_simulacion.DataSource = dt;
            this.colorColumnas();
        }

        public void calcularVentaMañana()
        {
            if (stockGr >= consumoMañana)
            {
                ventaMañana = consumoMañana;
                ingresoMañana = consumoMañana * precioVenta;
                stockGr = stockGr - consumoMañana;
                stockFrascos = stockGr/gramosxFrasco;
            }
            else
            {
                cantFaltaMañana = consumoMañana - stockGr;
                ventaMañana = stockGr;
                ingresoMañana = stockGr * precioVenta;
                stockGr = 0;
                stockFrascos = 0;
            }
        }

        public void calcularVentaTarde()
        {
            if (stockGr >= consumoTarde)
            {
                ventaTarde = consumoTarde;
                ingresoTarde = consumoTarde * precioVenta;
                stockGr = stockGr - consumoTarde;
                stockFrascos = stockGr / gramosxFrasco;
            }
            else
            {
                cantFaltaTarde = consumoTarde - stockGr;
                ventaTarde = stockGr;
                ingresoTarde = stockGr * precioVenta;
                stockGr = 0;
                stockFrascos = 0;
            }
        }

        public void costoFaltante()
        {
            //El costo faltante es $1 x gramo
            costoFalta += cantFaltaTarde + cantFaltaMañana;
        }

        public void calcularHorasPerdidas(int i)
        {
            if ((cantFaltaTarde + cantFaltaMañana) > 0)
            {
                //faltante *16 /consumo total
                //TODO validar si se debe agregar acumulados de faltante y consumo
                porcHorasPerd = (cantFaltaTarde + cantFaltaMañana) * (horasxTurno * 2)  / (consumoMañana + consumoTarde);
            }
        }

        public void obtenerPromedio()
        {
            if (cantDias > 0)
            { promedio = acumGananciaDiaria / cantDias;

                promedio = Math.Round(promedio, 2);
            }
        }
        public void limpiarDatos()
        {
            desde = 0;
            hasta = 0;
            cantDias = 0;
            ventaMañana = 0;
            ventaTarde = 0;
            gananciaTotal = 0;
            costoCompra = 0;
            costoTotal = 0;
            gananciaDiaria = 0;
            acumGananciaDiaria = 0;
            promedio = 0;
            gananciaPromedio = 0;
            cantFaltaTarde = 0;
            cantFaltaMañana = 0;
            consumoMañana = 0;
            consumoTarde = 0;
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
            if (cantComprada <= 0 || cadaCuantoComprar <=0 || cantMaxAlmacenar <= 0)
            {
                MessageBox.Show("Debe elegir alguna politica");
                return false;
            }


            if (txt_cantDias.Text == "")
            {
                MessageBox.Show("Debe ingresar la cantida de dias");
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
            dt.Columns.Add("Costo Faltante Ac");
            dt.Columns.Add("Porcentaje Hs perdidas");
            dt.Columns.Add("Prom Cant Cafe almacen Gr");
            dt.Columns.Add("Prom Cant Cafe almacen Frascos");
            dt.Columns.Add("Prom Cant faltante");
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
            return dt;
        }
    }
}

