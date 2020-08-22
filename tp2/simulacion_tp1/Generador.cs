using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacion_tp1
{
    class Generador
    {
        private int k;
        private int g;
        private int c;
        private Random random = new Random();
        List<NroRandom> lista;

        public Generador()
        {
            
        }

        public Generador(int k, int g, int c)
        {
            this.k = k;
            this.g = g;
            this.c = c;
            this.lista = null;
        }

        public NroRandom mixto(int x)
        {
            //𝑥𝑛+1 ≡ (𝑎 ∙ 𝑥𝑛 + 𝑐)𝑚𝑜𝑑 m
            int a = 1 + (4 * k);
            double m = Math.Pow(2, g);
            int xi = Convert.ToInt32((a * x + c) % m);
            NroRandom nroRnd = new NroRandom(x, xi, dividir(xi, m));
            return nroRnd;
        }

        public List<NroRandom> mixtoLista(int semilla, int cantidadGenerar)
        {
            lista = new List<NroRandom>();
            NroRandom nroRandom;
            for (int i = 0; i < cantidadGenerar; i++)
            {
                nroRandom = mixto(semilla);
                nroRandom.Posicion = i + 1;
                lista.Add(nroRandom);
                semilla = nroRandom.Siguiente;
            }
            return lista;
        }

        public NroRandom multiplicativo(int x)
        {
            //X𝑛+1 ≡ (𝑎 ∙ 𝑥𝑛)𝑚𝑜𝑑 m
            int a = 3 + (8 * k);
            double m = Math.Pow(2, g);
            int xi = Convert.ToInt32((a * x) % m);
            NroRandom nroRnd = new NroRandom(x, xi, dividir(xi, m));
            return nroRnd;
        }

        public List<NroRandom> multiplicativoLista(int semilla, int cantidadGenerar)
        {

            lista = new List<NroRandom>();
            NroRandom nroRandom;
            for (int i = 0; i < cantidadGenerar; i++)
            {
                nroRandom = multiplicativo(semilla);
                nroRandom.Posicion = i + 1;
                lista.Add(nroRandom);
                semilla = nroRandom.Siguiente;
            }
            return lista;
        }

        public NroRandom lenguaje()
        {
            //Random random = new Random();
            double nro = Math.Round(random.NextDouble(), 4, MidpointRounding.AwayFromZero);
            NroRandom nroRnd = new NroRandom(0, 0, nro);
            return nroRnd;
        }

        public List<NroRandom> lenguajeLista(int cantidadGenerar)
        {
            List<NroRandom> lista = new List<NroRandom>();
            NroRandom nroRandom;
            for (int i = 0; i < cantidadGenerar; i++)
            {
                nroRandom = lenguaje();
                nroRandom.Posicion = i + 1;
                double nro = nroRandom.Random;
                lista.Add(nroRandom);
            }
            return lista;
        }

        private double dividir(int nro, double m)
        {
            double resultado = (double) nro / (m); // si se borra el 1 de le ecuacion no se incluye el 1 en la lista de randoms 
            return Math.Round(resultado, 4, MidpointRounding.AwayFromZero);
        }


        public List<NroRandom> SiguienteRND(string metodo)
        {
            NroRandom nroRandom;
            int semilla = lista.Last().Siguiente;
            if (metodo == "mixto")
            {
                nroRandom = mixto(semilla);
                nroRandom.Posicion = lista.Count + 1;
                lista.Add(nroRandom);
            } else {
                nroRandom = multiplicativo(semilla);
                nroRandom.Posicion = lista.Count + 1;
                lista.Add(nroRandom);
            }
            return lista;
        }


    }
}
