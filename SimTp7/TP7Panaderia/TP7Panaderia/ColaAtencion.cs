using System.Collections.Generic;

namespace TP7Panaderia
{
    public class ColaAtencion
    {
        private Queue<Cliente> cola;

        public ColaAtencion()
        {
            cola = new Queue<Cliente>();
        }

        public void setCola(Cliente c)
        {
            cola.Enqueue(c);
        }

        public Queue<Cliente> getCola()
        {
            return cola;
        }

    }
}
