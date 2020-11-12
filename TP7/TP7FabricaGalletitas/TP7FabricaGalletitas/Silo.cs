using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7FabricaGalletitas
{
    public class Silo
    {
        private int id;
        private int capacidadMax;
        private int toneladasAcumaladas;
        private int toneladasADescargar;
        private string estado; //LIBRE, SIENDO_LLENADO, ABASTECIENDO_PLANTA

        private Reloj finDescarga;
        private Reloj finAbastecimiento;
        private double demora;

        public Silo(int id, int capacidadMax)
        {
            this.id = id;
            this.capacidadMax = capacidadMax;

            this.estado = Constantes.ESTADO_SILO_LIBRE;
            this.finDescarga = new Reloj();
        }

        public Silo()
        {
            this.estado = Constantes.ESTADO_SILO_LIBRE;
        }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }


        public double getDemora()
        {
            return this.demora;
        }

        public void setDemora(double demora)
        {
            this.demora = demora;
        }

        public Reloj getFinDescarga()
        {
            return this.finDescarga;
        }

        public void setFinDescarga(Reloj finDescarga)
        {
            this.finDescarga = finDescarga;
        }

        public Reloj getFinAbastecimiento()
        {
            return this.finAbastecimiento;
        }

        public void setFinAbastecimiento(Reloj finAbastecimiento)
        {
            this.finAbastecimiento = finAbastecimiento;
        }

        public string getEstado()
        {
            return this.estado;
        }

        public void setEstado(string estado)
        {
            this.estado = estado;
        }

        public int getCapacidadMax()
        {
            return this.capacidadMax;
        }

        public void setCapacidadMax(int capacidadMax)
        {
            this.capacidadMax = capacidadMax;
        }

        public int getToneladasAcum()
        {
            return this.toneladasAcumaladas;
        }

        public void setToneladasAcum(int capacidadAcumalada)
        {
            this.toneladasAcumaladas = capacidadAcumalada;
        }

        public int getToneladasADescargar()
        {
            return this.toneladasADescargar;
        }

        public void setToneladasADescargar(int toneladasADescargar)
        {
            this.toneladasADescargar = toneladasADescargar;
        }

    }
}
