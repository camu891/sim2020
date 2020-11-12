using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7FabricaGalletitas
{
    public class Camion
    {
        public static int id = -1;
        private string tipo;
        private double rndTipoCamion;
        private int toneladas;
        private string estado;

        public Camion(double rndTipoCamion, double probTipoCamion)
        {
            id++;
            this.rndTipoCamion = rndTipoCamion;
            this.calcularTipo(rndTipoCamion, probTipoCamion); 
        }

        public int Id { get => id; set => id = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public double RndTipoCamion { get => rndTipoCamion; set => rndTipoCamion = value; }

        public int Toneladas { get => toneladas; set => toneladas = value; }

        public string Estado { get => estado; set => estado = value; }

        private void calcularTipo(double rnd, double prob)
        {
            this.Tipo = rnd <= prob ? Constantes.TIPO_CAMION_1 : Constantes.TIPO_CAMION_2;
            this.Toneladas = this.tipo == Constantes.TIPO_CAMION_1 ? 10 : 12;
        }
    }
}
