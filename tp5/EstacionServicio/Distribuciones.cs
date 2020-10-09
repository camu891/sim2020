using System;

namespace Pizzeria
{
    class Distribuciones
    {

        public static double  Exponencial(double media, double rnd)
        {
            return (double) Math.Log(1 - rnd) * (-media);
            
        }
        public static double Uniforme(double a, double b, double rnd)
        {
            return (double)a + (b - a) * rnd;
            
        }
       


    }
}
