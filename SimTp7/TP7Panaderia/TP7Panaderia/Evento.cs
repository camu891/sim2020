using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7Panaderia
{
    public abstract class Evento
    {
        public abstract Reloj getProximoTiempo();

        public abstract string getNombreEvento();

        public abstract void simular(Reloj reloj, double random);
    }
}
