using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP7FabricaGalletitas
{
    class Validaciones
    {

        public static bool estaVacio(NumericUpDown txt)
        {
            return txt.Text.Equals(String.Empty);
        }

    }
}
