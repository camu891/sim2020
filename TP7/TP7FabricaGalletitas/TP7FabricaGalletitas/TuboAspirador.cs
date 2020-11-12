using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7FabricaGalletitas
{
    class TuboAspirador
    {
        private string estado;

        public TuboAspirador()
        {
            this.estado = "Libre";
        }

        public string Estado { get => estado; set => estado = value; }
    }
}
