using Pizzeria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzeriaTP5
{
    public partial class EulerForm : Form
    {
        public EulerForm(double random, double h)
        {
            InitializeComponent();
            initEulerGrilla(random, h);
        }

    

		private void initEulerGrilla(double random, double h)
		{
			// return Distribuciones.Uniforme(this.desdePizza, this.hastaPizza, random);

			//dE/dt=-k*E-1,99+0.0001t
			//K distribucion uniforme (0.3 - 0.8)
			//E siempre inicia en 100% y cuando llega a 0 finaliza
			// h=0.05 igual a 1 minuto
			Double E = 1;
			Double k = Distribuciones.Uniforme(0.3, 0.8, random);
			Double acuh = 0;
			double derivada = 0;

			//init grilla
			int j = this.dataGridViewEuler.Rows.Add();
			dataGridViewEuler.Rows[j].Cells["colC"].Value = E;
			dataGridViewEuler.Rows[j].Cells["colT"].Value = acuh / 0.05;
			dataGridViewEuler.Rows[j].Cells["colDerivada"].Value = "";

			while (E > 0)
			{
				derivada = -k * E - 1.99 + 0.0001 * acuh;
				E = caleuler(E, derivada, h);
				acuh += h;

				//cargamos grilla
				int i = this.dataGridViewEuler.Rows.Add();
				dataGridViewEuler.Rows[i].Cells["colC"].Value = E;
				dataGridViewEuler.Rows[i].Cells["colT"].Value = acuh / 0.05;
				dataGridViewEuler.Rows[i].Cells["colDerivada"].Value = derivada;
			}

		}

		private double caleuler(double xi, double xderivada, double hciclo)
		{
			// xi+1=xi+h*derivada de xi
			return xi + (hciclo * xderivada);
		}

	}
}
