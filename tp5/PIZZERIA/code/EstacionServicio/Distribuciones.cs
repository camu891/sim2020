using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

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

    }
}
