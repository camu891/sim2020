using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;

namespace Pizzeria
{
    class Distribuciones
    {

        public static double Exponencial(double media, double rnd)
        {
            return (double) Math.Log(1 - rnd) * (-media);
            
        }
        public static double Uniforme(double a, double b, double rnd)
        {
            return (double)a + (b - a) * rnd;
        }

        public static int poisson(double media, double rnd)
        {
            int seed = (int)(rnd * 100);
            if (seed == 0)
                seed = 1;
            Random rndm = new Random(seed);
            double p = 1.0, L = Math.Exp(-media);
            int k = 0;
            do
            {
                k++;
                p *= rndm.NextDouble();
            }
            while (p > L);
            return k - 1;
        }

        public static double normal(double media, double desv, double rnd)
        {
            int seed = (int)(rnd * 100);
            if (seed == 0)
                seed = 1;
            Random rndm = new Random(seed);
            double rnd1 = rndm.NextDouble(); //uniform(0,1] random doubles
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(rnd)) *
                         Math.Sin(2.0 * Math.PI * rnd1); //random normal(0,1)
            return media + desv * randStdNormal; //random normal(mean,stdDev^2)
        }
    }

    public static class Helpers
    {
        public static double TruncateDouble(this double value, double precision)
        {
            var val = Math.Pow(10, precision);
            return (Math.Truncate(val * value)) / val;
        }

        public static double CantidadEnIntervalo(this double[] values, double min, double max)
        {
            return values.Count(x => x >= min && x < max);
        }
    }

}
