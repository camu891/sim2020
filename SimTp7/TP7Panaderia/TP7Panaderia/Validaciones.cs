using System;
using System.Windows.Forms;

namespace TP7Panaderia
{
    class Validaciones
    {

        public static bool estaVacio(NumericUpDown txt)
        {
            return txt.Text.Equals(String.Empty);
        }

    }
}
