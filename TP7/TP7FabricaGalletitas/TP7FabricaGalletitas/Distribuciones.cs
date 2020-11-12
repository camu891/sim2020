using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7FabricaGalletitas
{
    class Distribuciones
    {
        public static double Uniforme(int a, int b, double rnd)
        {
            return (double)a + (b - a) * rnd;
        }

    }
}
