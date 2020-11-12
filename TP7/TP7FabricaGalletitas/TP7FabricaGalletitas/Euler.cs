using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7FabricaGalletitas
{
    class Euler
    {

		public static double calEuler(double xi, double xderivada, double hciclo)
		{
			// xi+1=xi+h*derivada de xi
			return xi + (hciclo * xderivada);
		}

	}
}
