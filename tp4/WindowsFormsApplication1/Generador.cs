using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Generador
    {
        private int a;
        private int c;
        private int m;
        private Random random = new Random();
        List<NroRandom> lista;

        public Generador()
        {

        }

        public Generador(int a, int c, int m)
        {
            this.a = a;
            this.c = c;
            this.m = m;
            this.lista = null;
        }

        public NroRandom mixto(int x)
        {
            //𝑥𝑛+1 ≡ (𝑎 ∙ 𝑥𝑛 + 𝑐)𝑚𝑜𝑑 m
            int xi = Convert.ToInt32((a * x + c) % m);
            NroRandom nroRnd = new NroRandom(x, xi, dividir(xi, m));
            return nroRnd;
        }

        private double dividir(int nro, double m)
        {
            double resultado = (double)nro / (m); // si se borra el 1 de le ecuacion no se incluye el 1 en la lista de randoms 
            return Math.Round(resultado, 4, MidpointRounding.AwayFromZero);
        }
    }
}
