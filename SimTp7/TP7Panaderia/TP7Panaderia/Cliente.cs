using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7Panaderia
{
    public class Cliente
    {
        public static int id = -1;
        private int cantProductos;
        private string estado;

        public Cliente(int cantProductos)
        {
            id++;
            this.cantProductos = cantProductos;
        }

        public int Id { get => id; set => id = value; }

        public int CantProductos { get => cantProductos; set => cantProductos = value; }

        public string Estado { get => estado; set => estado = value; }
    }
}
