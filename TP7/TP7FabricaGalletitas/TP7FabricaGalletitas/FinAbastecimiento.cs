using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TP7FabricaGalletitas
{
    class FinAbastecimiento : Evento
    {
        private string nombreEvento = Constantes.EVENTO_FIN_ABASTECIMIENTO;
        private double rndTiempo;
        private double tiempoEntreLlegadas;
        private Reloj proximoFin;
        private Silo silo;
        private double demora;

        private double tasaAbastecimiento;

        public FinAbastecimiento(Silo silo, double tasaAbastecimiento)
        {
            this.silo = silo;
            this.tasaAbastecimiento = tasaAbastecimiento;
            proximoFin = new Reloj();
        }

        public override string getNombreEvento()
        {
            return this.nombreEvento;
        }

        public override Reloj getProximoTiempo() //prox fin
        {
            return this.proximoFin;
        }

        public override void simular(Reloj reloj, double random)
        {
            this.rndTiempo = random;
            this.demora = getDemoraAbastecimiento();
            this.proximoFin.setReloj(this.demora + reloj.getReloj());

            this.silo.setEstado(Constantes.ESTADO_SILO_ABASTECIENDO);
            this.silo.setDemora(this.demora);
            this.silo.setFinAbastecimiento(this.proximoFin);
        }

        private double getDemoraAbastecimiento()
        {
            return this.silo.getToneladasAcum() / this.tasaAbastecimiento;
        }

        public void setHoraFin(Reloj horaFin)
        {
            this.proximoFin = horaFin;
        }

        public double getTiempoEntreLlegada()
        {
            return this.demora;
        }

        public Silo GetSilo() {
            return this.silo;
        }

        public void setSilo(Silo silo)
        {
            this.silo = silo;
        }


    }
}
