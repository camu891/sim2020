using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace SIM_GR_TP3.Models
{
    public class RandomGenra2
    {

        public RandomGenra2()
        {
        }

        public double[] GenerateCSharpRandoms(int semilla, uint cantidad)
        {
            var rnd = new Random(semilla);
            return new double[cantidad].Select(x => rnd.NextDouble().TruncateDouble(4)).ToArray();
        }

        public List<double[]> GenerateCSharpRandomsList(int semilla, uint cantidad)
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

        public double[] GenerateCSharpRandomsPoisson(int semilla, uint cantidad, double lambda)
        {
            double[] lstRnd = new double[cantidad];
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
            public double[] GenerateUniformDistribution(double a, double b, double[] randoms)
        {
            return randoms.Select(x => (a + x * (b - a)).TruncateDouble(4)).ToArray();
        }

        public double[] GenerateExponentialDistribution(double lambda, double[] randoms)
        {
            return randoms.Select(x => ((Math.Log(1 - x)) / -lambda).TruncateDouble(4)).ToArray();
        }

        public double[] GenerateNormalDistribution(double media, double desviacion, List<double[]> randoms)
        {
            return randoms.Select(x => ((x.Sum() - 6) * desviacion) + media).ToArray();
        }

        public List<double[]> GeneratePoissonFrecuencies( double[] randoms, double lambda, uint nroN)
        {
            /*
            var min = randoms.Min();
            var max = randoms.Max() ;
            var intervalRange = (max - min) / cantIntervalos;
            */
            var a = new List<double[]>();
            double calcEstAcum = 0;
            //var intervalStart = 0;
            //var intervalEnd = 0;
            
            for (int i = 0; i < randoms.Length; i++)
            {
                var valor = 0;
                var frecObs = 0;
                bool aux = false;
                for (int j = 0; j < randoms.Length; j++)
                {
                    if (randoms[j] == randoms[i])
                        frecObs++;
                }

                for(int j = 0; j < randoms.Length; j++)
                {

                if (randoms[j] == randoms[i] && aux == false)
                {
                    valor = Convert.ToInt32(randoms[i]);
                    aux = true;
                    var frecEsperada = ((lambda * randoms[i] * Math.Exp(-lambda)) / factorial(Convert.ToInt32(frecObs)) * nroN);
                    var c = Math.Round(Math.Pow(frecObs - frecEsperada, 2) / frecEsperada, 4);
                    calcEstAcum += c;
                    a.Add(
                            new double[5]
                            {
                            valor,  //min intervalo
                            //intervalEnd,   //max intervalo
                            frecObs,   //frec observada
                            frecEsperada,   //frec esperada
                            c,   // c
                            calcEstAcum  // c acum
                            }
                            );
                    }
               
            }
                
            }

            return a;
        }

        public static int factorial(int nro)
        {
            if (nro == 0)
                return 1;
            else
                return (nro * factorial(nro - 1));
        }
        public List<double[]>  GenerateUniformFrecuencies(uint cantIntervalos, double[] randoms, double A, double B)
        {

            var min = A; //intervalo min
            var max = B; //intervalo max

            var intervalRange = Math.Round((max - min) / cantIntervalos, 4);
            var frecEsperada = Math.Round((double)(randoms.Length / cantIntervalos), 4);

            var a = new List<double[]>();

            double calcEstAcum = 0;

            for (var i = 0; i < cantIntervalos; i++)
            {
                var interval_start = min + (intervalRange * i);
                var interval_end = interval_start + intervalRange;
                var frec_obs = randoms.CantidadEnIntervalo(interval_start, interval_end);
                var c = Math.Round(Math.Pow(frec_obs - frecEsperada, 2) / frecEsperada, 4);  
                calcEstAcum += c;
                a.Add(
                    new double[6]
                        {
                            interval_start ,  //min intervalo
                            interval_end,   //max intervalo
                            frec_obs,   //frec observada
                            frecEsperada,   //frec esperada
                            c,   // c
                            calcEstAcum  // c acum
                        }
                    );
            }

            return a;
        }

        public List<double[]>  GenerateExponentialFrecuencies(uint cantIntervalos,double lambda, double[] randoms)
        {
            var min = randoms.Min();
            var max = randoms.Max() + 0.01;
            var intervalRange = Math.Round((max - min) / cantIntervalos, 4);

            var a = new List<double[]>();
            double calcEstAcum = 0;

            for (var i = 0; i < cantIntervalos; i++)
            {
                var intervalStart = min + intervalRange * i;
                var intervalEnd = intervalStart + intervalRange;
                var frecObs = randoms.CantidadEnIntervalo(intervalStart, intervalEnd);
                var frecEsperada = (((1 - Math.Exp(-lambda * (intervalEnd))) - (1 - Math.Exp(-lambda * (intervalStart)))) * randoms.Length).TruncateDouble(4);
                var c = Math.Round(Math.Pow(frecObs - frecEsperada, 2) / frecEsperada, 4);
                calcEstAcum += c;
                a.Add(
                    new double[6]
                        {
                            intervalStart ,  //min intervalo
                            intervalEnd,   //max intervalo
                            frecObs,   //frec observada
                            frecEsperada,   //frec esperada
                            c,   // c
                            calcEstAcum  // c acum
                        }
                    );
            }

            return a;
        }

        public List<double[]>  GenerateNormalFrecuencies(uint cantIntervalos, double media, double desvEstandar, double[] randoms)
        {
            var min = randoms.Min();
            var max = randoms.Max() + 0.01;
            var intervalRange = Math.Round((max - min) / cantIntervalos, 4);


            var a = new List<double[]>();
            double calcEstAcum = 0;

            for (var i = 0; i < cantIntervalos; i++)
            {
                var intervalStart = (min + intervalRange * i).TruncateDouble(4);
                var intervalEnd = (intervalStart + intervalRange).TruncateDouble(4);
                var frecObs = randoms.CantidadEnIntervalo(intervalStart, intervalEnd);

                var marcaClase = (intervalEnd + intervalStart) / 2;

                var probabilidad = (Math.Exp(-0.5 * (Math.Pow((marcaClase - media) / desvEstandar, 2))) / (desvEstandar * Math.Sqrt(2 * Math.PI))) * intervalRange;

                var frecEsperada = (probabilidad * randoms.Length).TruncateDouble(4);

                var c = Math.Round(Math.Pow(frecObs - frecEsperada, 2) / frecEsperada, 4);
                calcEstAcum += c;
                a.Add(
                    new double[6]
                        {
                            intervalStart ,  //min intervalo
                            intervalEnd,   //max intervalo
                            frecObs,   //frec observada
                            frecEsperada,   //frec esperada
                            c,   // c
                            calcEstAcum  // c acum
                        }
                    );
            }

            return a;
        }

    }

    public static class Helpers
    {
        public static double TruncateDouble(this double value, double precision)
        {
            var val = Math.Pow(10, precision);
            return (Math.Truncate(val * value))/ val;
        }

        public static double CantidadEnIntervalo(this double[] values, double min, double max)
        {
            return values.Count(x => x >= min && x < max);
        }
    }
}
