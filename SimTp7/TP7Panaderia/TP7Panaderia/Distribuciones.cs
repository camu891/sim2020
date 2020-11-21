using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7Panaderia
{
    class Distribuciones
    {
        public static double Uniforme(int a, int b, double rnd)
        {
            return (double)a + (b - a) * rnd;
        }

        public static double Uniforme(double a, double b, double rnd)
        {
            return (double)a + (b - a) * rnd;
        }

        public static double Exponencial(double media, double rnd)
        {
            return (double)Math.Log(1 - rnd) * (-media);

        }

    }
}
