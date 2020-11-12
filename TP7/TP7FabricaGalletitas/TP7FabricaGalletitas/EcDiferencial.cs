using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP7FabricaGalletitas
{
    public partial class EcDiferencial : Form
    {
        public EcDiferencial()
        {
            InitializeComponent();

        }

        private void generarDemoraDescarga(double h, int toneladasADescargar)
        {  
            //y'' = 4(y')^2+6y+8t
            // h=1 igual a 1 hora
            Double x1 = 0, x2 = 0;
            Double acuh = 0;

            //primer fila
            int i = dgvResult.Rows.Add();
            dgvResult.Rows[i].Cells["colT"].Value = h;
            dgvResult.Rows[i].Cells["colX1"].Value = x1;
            dgvResult.Rows[i].Cells["colDx1"].Value = x2;
            dgvResult.Rows[i].Cells["colDx2"].Value = 0;

            while (x1 < toneladasADescargar)
            {
                double derivada = 4 * Math.Pow(x1, 2) + 6 * x2 + 8 * acuh;
                x1 = Euler.calEuler(x1, x2, h);
                x2 = Euler.calEuler(x2, derivada, h);
                acuh += h;

                int j = dgvResult.Rows.Add();
                dgvResult.Rows[j].Cells["colT"].Value = acuh;
                dgvResult.Rows[j].Cells["colX1"].Value = x1;
                dgvResult.Rows[j].Cells["colDx1"].Value = x2;
                dgvResult.Rows[j].Cells["colDx2"].Value = derivada;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvResult.Rows.Clear();
            double h = Convert.ToDouble(txtHDescarga.Value);
            int toneladas = Convert.ToInt32(txtToneladas.Value);
            generarDemoraDescarga(h, toneladas);
        }
    }
}
