using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacion_tp1
{
    class NroRandom
    {
        private int semilla;
        private int siguiente;
        private int posicion;
        private double random;

        public NroRandom(int x, int xi, double r)
        {
            semilla = x;
            siguiente = xi;
            random = r;
        }

        public int Semilla
        {
            set { semilla = value; }
            get { return semilla; }
        }

        public int Siguiente
        {
            set { siguiente = value; }
            get { return siguiente; }
        }

        public int Posicion
        {
            set { posicion = value; }
            get { return posicion; }
        }

        public double Random
        {
            set { random = value; }
            get { return random; }
        }
    }
}
