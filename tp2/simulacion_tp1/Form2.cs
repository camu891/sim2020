﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace simulacion_tp1
{
    public partial class Form2 : Form
    {
        List<Intervalo> intervalos;
        List<int> lstNros;
        int cantIntervalos = 0;
        double caAcumulado = 0;
        public Form2()
        {
            InitializeComponent();
            cmbIntervalo.Items.Add("10");
            cmbIntervalo.Items.Add("15");
            cmbIntervalo.Items.Add("20");
            cmbDistribucion.Items.Add("Normal");
            cmbDistribucion.Items.Add("Exponencial Negativa");
            cmbDistribucion.Items.Add("Uniforme");
            chrGrafico.Titles.Add("Histograma de Frecuencias");
            chrGrafico.ChartAreas[0].AxisX.Title = "Intervalos";
            chrGrafico.ChartAreas[0].AxisY.Title = "Variable en estudio";
            chrGrafico.Series[0].LegendText = "Fo";
        }

        public void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnFile = new OpenFileDialog();
            opnFile.ShowDialog();
            asignarArchivo(opnFile.FileName);
            lstNros = leerDatosDesdeArchivo(opnFile.FileName);
        }

        private void asignarArchivo(string nombreArchivo)
        {
            if (nombreArchivo != "")
            {
                txtRuta.Text = nombreArchivo;
            }
            else
            {
                txtRuta.Text = "Seleccionar Archivo de datos";
            }
        }

        private List<int> leerDatosDesdeArchivo(string nombreArchivo)
        {
            List<int> lista = new List<int>();
            string linea = "";
            int observacion;
            try
            {
                //Leemos desde el archivo
                StreamReader archivo = new StreamReader(nombreArchivo);
                while ((linea = archivo.ReadLine()) != null)
                {
                    //para cada linea se intenta convertir a entero
                    if (int.TryParse(linea, out observacion))
                        lista.Add(observacion);
                    else
                        txtRuta.Text = "Valor inválido: " + linea;
                }
            }
            catch
            {
                //txtRuta.MostrarError("No se puede leer el archivo");
            }

            return lista;
        }


        private void generarGrafico()
        {
            chrGrafico.Visible = true;
            ArrayList serieFo = new ArrayList();
            //ArrayList serieFe = new ArrayList();
            ArrayList fo = new ArrayList();
            //ArrayList fe = new ArrayList();

            for (int i = 0; i < intervalos.Count; i++)
            {

                serieFo.Add(intervalos[i].Inf.ToString() + "-" + intervalos[i].Sup.ToString());
                
                fo.Add(intervalos[i].Fo);
                //serieFe.Add(intervalos[i].Inf.ToString() + "-" + intervalos[i].Sup.ToString());
                //fe.Add(intervalos[i].Fe);
            }
            chrGrafico.Series[0].Points.DataBindXY(serieFo, fo);
            // chrGrafico.Series[1].Points.DataBindXY(serieFe, fe);
        }


        private void btnHistograma_Click(object sender, EventArgs e)
        {
            //lblGradosLibertad.Text = ""; 
            bool hayError = false;
            
            try
            {
                cantIntervalos = int.Parse(cmbIntervalo.Text);

                if (cantIntervalos > lstNros.Count)
                {
                    MessageBox.Show("Número de muestra debe ser mayor que la cantidad de intervalos.");
                    hayError = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar el tamaño del intervalo.");
                hayError = true;
            }
            if (!hayError)
            {

                //lblGradosLibertad.Text = "Grados de libertad: " + (cantIntervalos - 1);

                double inf = lstNros.Min();
                double sup = lstNros.Max();
                double mc = 0;
                double ancho = (sup - inf  )/ cantIntervalos;
                intervalos = new List<Intervalo>();
                
               for (int i = 0; i < cantIntervalos; i++)
                {
                    if (i != cantIntervalos - 1)
                        sup = inf + ancho;
                    else
                        sup = lstNros.Max();
                    mc = (sup + inf) / 2;
                    intervalos.Add(new Intervalo(inf, sup, mc));
                    inf = sup;
                }
            
                for (int i = 0; i < lstNros.Count; i++)
                {
                    for (int j = 0; j < intervalos.Count; j++)
                    {
                        if (intervalos[j].Inf <= lstNros[i] && lstNros[i] < intervalos[j].Sup)
                        {
                            intervalos[j].Fo++;
                            break;
                        }
                    }
                }

                //dgvTablaFecuencia.DataSource = intervalos;
                llenarTablaIntervalos(intervalos);
                generarGrafico();

            }
        }

        private void llenarTablaIntervalos(List<Intervalo> lst)
        {
            dgvTablaFecuencia.Rows.Clear();
            for (var i = 0; i < lst.Count; i++)
            {
                dgvTablaFecuencia.Rows.Add(lst[i].Inf, lst[i].Sup, lst[i].Fo);
            }
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            int aux = 0;
            double media = 0;
            double var = 0;
            string distribucion="";
            //bool hayError = false;
            try
            {
                distribucion= cmbDistribucion.Text;
                for (int i = 0; i < lstNros.Count; i++)
                {
                    aux += lstNros[i];
                }
                media = aux / lstNros.Count;
                for (int i = 0; i < lstNros.Count; i++)
                {
                    var += Math.Pow(lstNros[i] - media, 2);
                }
                var = var / lstNros.Count;
                txtMedia.Text = Convert.ToString(media);
                txtVarianza.Text = Convert.ToString(var);

                switch (distribucion)
                {                    
                    case "Normal":
                        double po = 0;
                        double desv = Math.Sqrt(var);
                        double expaux = 0;
                        for (int i = 0; i < intervalos.Count; i++)
                        {
                            // (1/(desv * raiz 2pi)) * exp (-1/2*((mc-u)/desv)^2)
                            expaux = Math.Pow(((intervalos[i].Mc - media) / desv),2);
                            double b = -0.5 * expaux;
                            double aa = Math.Exp(b);
                            po = (1/(desv * Math.Sqrt(2 * Math.PI))) * aa ;
                            intervalos[i].Fe = po * lstNros.Count ;
                        }
                        break;

                    case "Exponencial Negativa":
                        double po_exp = 0;
                        double lambda = 1 / media;             
                        double expaux_a = 0;
                        double expaux_b = 0;
                        for (int i = 0; i < intervalos.Count; i++)
                        {
                            // Falta especificar la formula de la exponencial
                            expaux_a = 1-Math.Pow(Math.E, (-lambda*intervalos[i].Sup));
                            expaux_b = 1-Math.Pow(Math.E, (-lambda*intervalos[i].Inf));
                            po_exp = (expaux_a - expaux_b) ;
                            intervalos[i].Fe = po_exp * lstNros.Count ;
                        }
                        break;

                    case "Uniforme":
                        for (int i = 0; i < intervalos.Count; i++)
                        {
                            // Falta especificar la formula de la exponencial
                            intervalos[i].Fe = lstNros.Count/intervalos.Count ;
                        }
                        break;
                }
                //Chi cuadrado y KS
                double maxKS = 0;
                double acuO = 0;
                double acuE = 0;
                caAcumulado = 0;
                for (int i = 0; i < intervalos.Count; i++)
                {
                    intervalos[i].calcularC();
                    caAcumulado += intervalos[i].C;
                    intervalos[i].Ca = Math.Round(caAcumulado, 2, MidpointRounding.AwayFromZero);
                    intervalos[i].Po = Convert.ToDouble(intervalos[i].Fo) / Convert.ToDouble(lstNros.Count);
                    intervalos[i].Pe = Convert.ToDouble(intervalos[i].Fe) / Convert.ToDouble(lstNros.Count);

                    acuO += intervalos[i].Po;
                    acuE += intervalos[i].Pe;
                    intervalos[i].PAo = acuO;
                    intervalos[i].PAe = acuE;
                    intervalos[i].KS = intervalos[i].PAo - intervalos[i].PAe;

                    maxKS = maxKS > intervalos[i].KS ? maxKS :  intervalos[i].KS;
                }

                double v = cantIntervalos - 1;
                MathNet.Numerics.Distributions.ChiSquared chiCuadrado =
                    new MathNet.Numerics.Distributions.ChiSquared(v);    
                double ksTabla = 1.36/Math.Sqrt(lstNros.Count);            
                double ChiCalculado = intervalos.Last().Ca;
      
                if (tabControl1.SelectedTab.Name == "tabChi") {
                    txtCalculado.Text = Convert.ToString(ChiCalculado);
                    txtTabulado.Text = Convert.ToString(chiCuadrado.Median);
                } else {
                    txtCalculado.Text = Convert.ToString(maxKS);
                    txtTabulado.Text = Convert.ToString(ksTabla);
                }
                //dgvChi.DataSource = intervalos;
                //dgvKs.DataSource = intervalos;
                llenarTablaChi(intervalos);
                llenarTablaKS(intervalos);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar el tamaño del intervalo.");
                //hayError = true;
            }
        }

        private void llenarTablaChi(List<Intervalo> lst)
        {
            dgvChi.Rows.Clear();
            for (var i = 0; i < lst.Count; i++)
            {
                dgvChi.Rows.Add(lst[i].Inf, lst[i].Sup, lst[i].Fo, lst[i].Fe, lst[i].C, lst[i].Ca);
            }
        }

        private void llenarTablaKS(List<Intervalo> lst)
        {
            dgvKs.Rows.Clear();
            for (var i = 0; i < lst.Count; i++)
            {
                dgvKs.Rows.Add(lst[i].Inf, lst[i].Sup, lst[i].Fo, lst[i].Fe, lst[i].Po, lst[i].Pe, lst[i].PAo, lst[i].PAe, lst[i].KS);
            }
        }
        private void tabChi_Click(object sender, EventArgs e)
        {

        }

        private void dgvChi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
