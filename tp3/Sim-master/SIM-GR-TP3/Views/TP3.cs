﻿using SIM_GR_TP3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Excel = Microsoft.Office.Interop.Excel;

namespace SIM_GR_TP3
{
    public partial class TP3 : Form
    {
        double[] randomNumbers;
        Stopwatch timer;
        List<double[]> frecuencies;
        string distName;
        bool poisson = false;
        public TP3()
        {
            InitializeComponent();
        }

        private void TP3_Load(object sender, EventArgs e)
        {
            SetCmbIntervalos();
            SetExcelIcon();
        }

        private void SetCmbIntervalos() {
            cmbIntervalo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIntervalo.Items.Add("10");
            cmbIntervalo.Items.Add("15");
            cmbIntervalo.Items.Add("20");
            cmbIntervalo.SelectedItem = "10";
            cmbIntervalo.SelectedText = "10";
        }

        private void SetExcelIcon()
        {
            // Assign an image to the button.
            btnGraficoExcel.Image = Image.FromFile("assets/excel-icon.png");
            // Align the image and text on the button.
            btnGraficoExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnGraficoExcel.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            switch (tabRandomMethods.SelectedIndex)
            {
                case 0:
                        GenerateExponentialDistrib();
                        distName = "Exponencial";
                        poisson = false;
                         break;

                case 1:
                        GenerateNormalDistrib();
                        distName = "Normal";
                        poisson = false;
                        break;
                case 2:
                        GeneratePoissonDistrib();
                        distName = "Poisson";
                        poisson = true;
                        break;
                    
            }

            timer.Stop();
            lblElapsedTimeGenerator.Text = timer.ElapsedMilliseconds.ToString();
        }

        private void GeneratePoissonDistrib()
        {

            if (!isValid()) {
                MessageBox.Show("Ingrese cantidad de números a generar.");
                return;
            }

            if (!isValidLambda())
            {
                MessageBox.Show("Ingrese el valor de lambda.");
                return;
            }
            // Variables tomadas de interfaz 
            var rndNumCount = Convert.ToUInt32(nudRandomNumbersCount.Value);
            var seed = Convert.ToInt32(nudUniformDistribSeed.Value);
            var lamnda = Convert.ToDouble(lblLambda.Value);
            //var numIntervals = Convert.ToUInt32(cmbIntervalo.Text);

            var rndGen = new RandomGenra2();
            this.Cursor = Cursors.WaitCursor;

            //calculo numero aletorios
            
            randomNumbers = rndGen.GenerateCSharpRandomsPoisson(seed, rndNumCount ,lamnda);
            FillDgNumbers(randomNumbers);
            this.Cursor = Cursors.Default;

            //calculo frecuencias
           // if (numIntervals <= 0) return;

            timer = Stopwatch.StartNew();
            frecuencies = rndGen.GeneratePoissonFrecuencies(randomNumbers, lamnda, rndNumCount);

            FillDbFrecuenciesPoisson(frecuencies);
            gradlib.Visible = true;
            var gradLib = frecuencies.Count - 1;
            gradlib.Text = String.Format("Grados de Libertad: {0}", gradLib);
            fillChart(frecuencies);
            var chi = frecuencies[frecuencies.Count - 1][4];
            messageResultado("Distribución de Poisson", chisquared(gradLib), chi, gradLib);
        }


        private void GenerateExponentialDistrib()
        {

            if (!isValid())
            {
                MessageBox.Show("Ingrese cantidad de números a generar.");
                return;
            }

            if (nudExponentialDistribLambda.Value == 0)
            {
                MessageBox.Show("Lambda tiene que ser mayor a 0.");
                return;
            }

            var rndNumCount = Convert.ToUInt32(nudRandomNumbersCount.Value);
            var seed = Convert.ToInt32(nudExponentialDistribSeed.Value);
            var lambda = Convert.ToDouble(nudExponentialDistribLambda.Value);
            var numIntervals = Convert.ToUInt32(cmbIntervalo.Text);

            var rndGen = new RandomGenra2();
            this.Cursor = Cursors.WaitCursor;

            //calculo numero aletorios
            randomNumbers = rndGen.GenerateExponentialDistribution(lambda, rndGen.GenerateCSharpRandoms(seed, rndNumCount));
            FillDgNumbers(randomNumbers);
            this.Cursor = Cursors.Default;

            //calculo frecuencias
            if (numIntervals <= 0) return;

            timer = Stopwatch.StartNew();
            frecuencies = rndGen.GenerateExponentialFrecuencies(numIntervals, lambda, randomNumbers);
            timer.Stop();
            lblElapsedTimeFrecuencies.Text = timer.ElapsedMilliseconds.ToString();
            FillDbFrecuencies(frecuencies);
            gradlib.Visible = true;
            var gradLib = frecuencies.Count - 1;
            gradlib.Text = String.Format("Grados de Libertad: {0}", gradLib);
            fillChart(frecuencies);
            var chi = frecuencies[frecuencies.Count - 1][5];
            messageResultado("Distribución Exponencial", chisquared(gradLib), chi, gradLib);
        }


        private void GenerateNormalDistrib()
        {
            if (!isValid())
            {
                MessageBox.Show("Ingrese cantidad de números a generar.");
                return;
            }

            if (nudNormalDistribMedia.Value == 0)
            {
                MessageBox.Show("Media tiene que ser mayor a 0.");
                return;
            }

            var rndNumCount = Convert.ToUInt32(nudRandomNumbersCount.Value);
            var seed = Convert.ToInt32(nudNormalDistribSeed.Value);
            var media = Convert.ToDouble(nudNormalDistribMedia.Value);
            var deviation = Convert.ToDouble(nudNormalDistribDeviation.Value);
            var numIntervals = Convert.ToUInt32(cmbIntervalo.Text);

            var rndGen = new RandomGenra2();
            this.Cursor = Cursors.WaitCursor;

            //calculo numero aletorios
            randomNumbers = rndGen.GenerateNormalDistribution(media, deviation, rndGen.GenerateCSharpRandomsList(seed, rndNumCount));
            FillDgNumbers(randomNumbers);
            this.Cursor = Cursors.Default;

            //calculo frecuencias
            if (numIntervals <= 0) return;

            timer = Stopwatch.StartNew();
            frecuencies = rndGen.GenerateNormalFrecuencies(numIntervals, media, deviation, randomNumbers);
            timer.Stop();
            lblElapsedTimeFrecuencies.Text = timer.ElapsedMilliseconds.ToString();
            FillDbFrecuencies(frecuencies);
            gradlib.Visible = true;
            var gradLib = frecuencies.Count - 1;
            gradlib.Text = String.Format("Grados de Libertad: {0}", gradLib);
            fillChart(frecuencies);
            var chi = frecuencies[frecuencies.Count-1][5];
            messageResultado("Distribución Normal", chisquared(gradLib), chi, gradLib);
        }


        private void FillDgNumbers(double[] num)
        {
            dtgNumeros.Rows.Clear();
            dtgIntervalos.Columns[0].HeaderText = "Intervalos";
            for (var i = 0; i < num.Length; i++)
            {
                dtgNumeros.Rows.Add(i + 1, num[i]);
            }
        }

        //Llena tabla frec
        private void FillDbFrecuencies(List<double[]> frecuencias)
        {
            dtgIntervalos.Rows.Clear();
            dtgIntervalos.Columns[0].HeaderText = "Intervalos";
            frecuencias.ForEach(x =>
                    dtgIntervalos.Rows.Add(String.Format("{0} - {1}", x[0], x[1]), x[2], x[3], x[4], x[5])
                );
        }

        private void FillDbFrecuenciesPoisson(List<double[]> frecuencias)
        {
            dtgIntervalos.Rows.Clear();
            dtgIntervalos.Columns[0].HeaderText = "Valor";
            frecuencias.ForEach(x =>
                    dtgIntervalos.Rows.Add( x[0], x[1], x[2], x[3], x[4])
                );
        }

        private void fillChart(List<double[]> frecuencias)
        {
            graficoObtenida.Series[0].Points.Clear();
            graficoObtenida.Series[1].Points.Clear();

            foreach (var frec in frecuencias)
            {
                graficoObtenida.Series["Observada"].Points.AddXY(frec[1], frec[2]);
                // graficoObtenida.Series["Esperada"].Points.AddXY(frec[1], frec[3]);
                graficoObtenida.Series["Observada"].Points[frec.Rank - 1].AxisLabel = String.Format("{0} - {1}", frec[1], frec[0]);
            }

            graficoObtenida.Series["Observada"].ChartType = SeriesChartType.Column;
            graficoObtenida.Series["Observada"].XValueType = ChartValueType.Double;
            graficoObtenida.Series["Observada"].YValueType = ChartValueType.Int32;
            //graficoObtenida.ChartAreas[0].AxisX.LabelStyle.Interval = ((frec[0, 1] - frec[0, 0])/2);
            graficoObtenida.ChartAreas[0].AxisX.LabelAutoFitStyle = LabelAutoFitStyles.LabelsAngleStep30;
            graficoObtenida.ChartAreas[0].AxisX.Interval = 0;
            graficoObtenida.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            graficoObtenida.Series["Observada"].IsVisibleInLegend = true;
            graficoObtenida.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Number;
            graficoObtenida.ChartAreas[0].AxisX.Minimum = frecuencias.First()[0];
            graficoObtenida.ChartAreas[0].AxisX.Maximum = frecuencias.Last()[1] + ((frecuencias.First()[1] - frecuencias.First()[0]) / 2);
        }

        private void fillExcelChart(bool poisson)
        {
            if (frecuencies == null)
            {
                return;
            }

            if (frecuencies.Count == 0)
            {
                return;
            }

            Excel.Application app = new Excel.Application();
            Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Excel.Worksheet worksheet = null;

            worksheet = workbook.Worksheets.get_Item(1) as Excel.Worksheet;
            worksheet.Name = "Gráfico Frecuencias";

            worksheet.Columns[1].NumberFormat = "@";

            for (int i = 1; i <= dtgIntervalos.ColumnCount; i++)
            {
                worksheet.Cells[1, i] = dtgIntervalos.Columns[i - 1].HeaderText.ToString();
            }

            var topLeft = "";
            var bottomRight = "";
            if (poisson == true)
            {
                for (int i = 0; i < frecuencies.Count; i++)
                {
                    worksheet.Cells[2 + i, 1] = (double)frecuencies.ElementAt(i)[0];
                    worksheet.Cells[2 + i, 2] = (double)frecuencies.ElementAt(i)[1];
                    worksheet.Cells[2 + i, 3] = (double)frecuencies.ElementAt(i)[2];
                    worksheet.Cells[2 + i, 4] = (double)frecuencies.ElementAt(i)[3];
                    worksheet.Cells[2 + i, 5] = (double)frecuencies.ElementAt(i)[4];
                }
                topLeft = "B2";
                bottomRight = "C" + (frecuencies.Count + 1);
            }
            else
            {
                for (int i = 0; i < frecuencies.Count; i++)
                {
                    worksheet.Cells[2 + i, 1] = String.Format("{0} - {1}", frecuencies.ElementAt(i)[0], frecuencies.ElementAt(i)[1]);
                    worksheet.Cells[2 + i, 2] = (double)frecuencies.ElementAt(i)[2];
                    worksheet.Cells[2 + i, 3] = (double)frecuencies.ElementAt(i)[3];
                    worksheet.Cells[2 + i, 4] = (double)frecuencies.ElementAt(i)[4];
                    worksheet.Cells[2 + i, 5] = (double)frecuencies.ElementAt(i)[5];
                }
                topLeft = "A2";
                bottomRight = "C" + (frecuencies.Count + 1);
            }

            

            // Add chart.
            var charts = worksheet.ChartObjects() as
                Microsoft.Office.Interop.Excel.ChartObjects;
            var chartObject = charts.Add(330, 10, 600, 400) as
                Microsoft.Office.Interop.Excel.ChartObject;
            var chart = chartObject.Chart;


            // Set chart range.
            var range = worksheet.get_Range(topLeft, bottomRight);
            chart.SetSourceData(range);

            var graphTitle = "Distribucion " + distName;
            const string xAxis = "Intervalos";
            const string yAxis = "Frecuencia";
            // Set chart properties.
            chart.ChartType = Microsoft.Office.Interop.Excel.XlChartType.xlColumnClustered;
            chart.ChartWizard(Source: range,
                Title: graphTitle,
                CategoryTitle: xAxis,
                ValueTitle: yAxis);

            // Set name series
            Excel.Series fo = chart.SeriesCollection(1);
            fo.Name = "Frecuencia observada";
            Excel.Series fe = chart.SeriesCollection(2);
            fe.Name = "Frecuencia esperada";

            var chartObj = worksheet.ChartObjects(1) as Microsoft.Office.Interop.Excel.ChartObject;
            chartObj.Activate();

            var chartGroup = workbook.ActiveChart.ChartGroups(1) as Microsoft.Office.Interop.Excel.ChartGroup;
            chartGroup.Overlap = 0;
            chartGroup.GapWidth = 0;
            chartGroup.HasSeriesLines = false;

            app.Visible = true;
            //app.Quit();
            app = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dtgNumeros.Rows.Clear();
            dtgIntervalos.Rows.Clear();
            graficoObtenida.Series[0].Points.Clear();
            graficoObtenida.Series[1].Points.Clear();
            gradlib.Visible = false;
            salidaPrueba.Text = "";
        }

        private void btnGraficoExcel_Click(object sender, EventArgs e)
        {
            fillExcelChart(poisson);
        }

        private Boolean isValid() {
            return nudRandomNumbersCount.Value != 0;
        }

        private Boolean isValidLambda()
        {
            return lblLambda.Value != 0;
        }

        private void distChange(object sender, TabControlEventArgs e)
        {
            if (tabRandomMethods.SelectedIndex == 2)
            {
                label10.Hide();
                cmbIntervalo.Hide();
            } 
            else
            {
                label10.Show();
                cmbIntervalo.Show();
            }
        }
        private void messageResultado(string tipo, double tabla, double calculado, int v)
        {
            if (calculado <= tabla)
            {
                salidaPrueba.Text = tipo + "\nCon un nivel de confianza de 95% no se rechaza la hipotesis nula!" + "\nValorCritico: " + calculado + "\nGrados de libertad: " + v + "\nValor prueba: " + tabla;
            }
            else
            {
                salidaPrueba.Text = tipo + "\nCon un nivel de confianza de 95% se rechaza la hipotesis nula!" + "\nValorCritico: " + calculado + "\nGrados de libertad: " + v + "\nValor tabla: " + tabla;
            }
        }
        private double chisquared(int v)
        {
            double[] chi = new double[37] { 3.84, 5.99, 7.81, 9.49, 11.1, 12.6, 14.1, 15.5, 16.9, 18.3, 19.7, 21.0, 22.4, 23.7, 25.0, 26.3, 27.6, 28.9, 30.1, 31.4, 32.7, 33.9, 35.2, 36.4, 37.7, 38.9, 40.1, 41.3, 42.6, 43.8, 55.8, 67.5, 79.1, 90.5, 101.9, 113.1, 124.3 };
            return (double)chi.GetValue(v);
        }
    }
}
