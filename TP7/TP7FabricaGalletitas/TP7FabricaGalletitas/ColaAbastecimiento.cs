using System;
using System.Collections.Generic;

namespace TP7FabricaGalletitas
{
    public class ColaAbastecimiento
    {
        private Queue<Silo> cola;

        public ColaAbastecimiento()
        {
            cola = new Queue<Silo>();
        }

        public void setCola(Silo c)
        {
            cola.Enqueue(c);
        }

        public void decrementarCola()
        {
            cola.Dequeue();
        }

        public Queue<Silo> getCola()
        {
            return cola;
        }

        public bool cambiarEstadoSilo(Silo c)
        {
            foreach (Silo ca in cola)
            {
                if (ca == c)
                {
                    ca.setEstado(Constantes.ESTADO_SILO_ABASTECIENDO); //ver esto
                    return true;
                }
            }
            return false;
        }

    }
}
