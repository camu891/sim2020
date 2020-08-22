using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacion_tp1
{
    class Intervalo
    {
        private double inf;
        private double sup;
        private double mc;

        private int fo;
        private double fe;
        private double c;
        private double ca;

        public Intervalo(double inf, double sup)
        {
            this.inf = inf;
            this.sup = sup;
            fo = 0;
            fe = 0;
            c = 0;
            ca = 0;
        }

        public Intervalo(double inf, double sup, double mc)
        {
            this.inf = inf;
            this.sup = sup;
            this.mc = mc;
            fo = 0;
            fe = 0;
            c = 0;
            ca = 0;
        }
        public double Mc
        {
            get { return mc; }
            set { mc = value; }
        }
        public double Inf
        {
            get { return inf; }
            set { inf = value; }
        }

        public double Sup
        {
            get { return sup; }
            set { sup = value; }
        }

        public int Fo
        {
            get { return fo; }
            set { fo = value; }
        }

        public double Fe
        {
            get { return fe; }
            set { fe = value; }
        }

        public double C
        {
            get { return c; }
            set { c = value; }
        }

        public double Ca
        {
            get { return ca; }
            set { ca = value; }
        }

        public void calcularC()
        {
            c = Math.Round(Math.Pow((fo - fe), 2) / fe, 2, MidpointRounding.AwayFromZero);
        }


    }
}
