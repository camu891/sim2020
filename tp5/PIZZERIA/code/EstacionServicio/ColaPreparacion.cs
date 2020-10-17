using Pizzeria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstacionServicio
{
   public class ColaPreparacion
    {
        private Queue<Pedido> cola;

        public ColaPreparacion() {
            cola = new Queue<Pedido>();
        }

        public void setCola(Pedido p) {
            cola.Enqueue(p);
        }

        public void decrementarCola()
        {
            cola.Dequeue();
        }

        public Queue<Pedido> getCola()
        {
            return cola;
        }

        public bool cambiarEstadoPedido(Pedido p)
        {
            foreach ( Pedido pe in cola)
            {
                if (pe == p)
                {
                    pe.Estado = "Preparado";
                    return true;
                }
            }
            return false;
        }
      
    }
}
