using System;
using System.Collections.Generic;
using System.Linq;

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

        public int[] GenerateCSharpRandomsPoisson(int cantidad, double lambda)
        {
            int[] lstRnd = new int[cantidad];
            double a = Math.Exp(-lambda);
            var rnd = new Random();
            double aux = 0;
            for (int i = 0; i < cantidad; i++)
            {
                double P = 1;
                int X = -1;
                do
                {
                    aux = rnd.NextDouble();
                    P = P * aux;
                    X++;
                } while (P >= a);
                lstRnd[i] = X;
            }
            return lstRnd;
        }

        public static double[] normal(double media, double desviacion)
        {
            List<double[]> randoms = GenerateCSharpRandomsList(5, 10);
            return randoms.Select(x => ((x.Sum() - 6) * desviacion) + media).ToArray();
        }

        public static List<double[]> GenerateCSharpRandomsList(int semilla, uint cantidad)
        {
            // Normal de convolucion
            // Por cada 12 nros aleatorios genera 1 con dist normal

            var rnd = new Random(semilla);
            return new double[cantidad].Select(x =>
                new double[12]
                {
                    rnd.NextDouble().TruncateDouble(4),
                    rnd.NextDouble().TruncateDouble(4),
                    rnd.NextDouble().TruncateDouble(4),
                    rnd.NextDouble().TruncateDouble(4),
                    rnd.NextDouble().TruncateDouble(4),
                    rnd.NextDouble().TruncateDouble(4),
                    rnd.NextDouble().TruncateDouble(4),
                    rnd.NextDouble().TruncateDouble(4),
                    rnd.NextDouble().TruncateDouble(4),
                    rnd.NextDouble().TruncateDouble(4),
                    rnd.NextDouble().TruncateDouble(4),
                    rnd.NextDouble().TruncateDouble(4)
                }
            ).ToList();
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
