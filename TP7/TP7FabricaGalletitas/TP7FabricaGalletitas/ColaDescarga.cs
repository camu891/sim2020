using System;
using System.Collections.Generic;

namespace TP7FabricaGalletitas
{
    public class ColaDescarga
    {
        private Queue<Camion> cola;

        public ColaDescarga()
        {
            cola = new Queue<Camion>();
        }

        public void setCola(Camion c)
        {
            cola.Enqueue(c);
        }

        public void decrementarCola()
        {
            cola.Dequeue();
        }

        public Queue<Camion> getCola()
        {
            return cola;
        }

        public bool cambiarEstadoCamion(Camion c)
        {
            foreach (Camion ca in cola)
            {
                if (ca == c)
                {
                    ca.Estado = "Descargado";
                    return true;
                }
            }
            return false;
        }

    }
}
