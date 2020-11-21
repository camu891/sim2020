using System;
using System.Windows.Forms;

namespace TP7Panaderia
{
    public partial class EcDiferencial : Form
    {
        public EcDiferencial()
        {
            InitializeComponent();

        }

        private void generarDemoraCoccion(double h, int cantProductos, double relHMin, double Temp0, double tiempoCoccionTempMax)
        {
            //dT/dt=-0.5T + 900/cantProductos
            // h=1 igual a 1 min
            double T0 = Temp0, T1 = 0;
            double t = 0;
            double coccion = 0;

            while (coccion < tiempoCoccionTempMax)
            {
                double derivada = (-0.5 * T0) + (900 / cantProductos);
                T1 = Math.Round(Euler.calEuler(T0, derivada, h),1);

                int j = dgvResult.Rows.Add();
                dgvResult.Rows[j].Cells["colMin"].Value = Math.Round(t / relHMin, 2);
                dgvResult.Rows[j].Cells["colTiempo"].Value = Math.Round(t,2);
                dgvResult.Rows[j].Cells["colTemp"].Value = T0;
                dgvResult.Rows[j].Cells["colDT"].Value = Math.Round(derivada,4);

                t += h;
                if (T0 == T1)
                    coccion += h / relHMin;
                T0 = T1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvResult.Rows.Clear();
            double h = Convert.ToDouble(txtH.Value);
            int productos = Convert.ToInt32(txtProductos.Value);
            double relHMIn = Convert.ToDouble(this.txtRelHmin.Value);
            double T0 = Convert.ToDouble(txtT0.Value);
            double tiempoCoccionTempMax = Convert.ToDouble(this.txtTiempoCoccionTempMax.Value);
            generarDemoraCoccion(h, productos, relHMIn, T0, tiempoCoccionTempMax);
        }
    }
}
