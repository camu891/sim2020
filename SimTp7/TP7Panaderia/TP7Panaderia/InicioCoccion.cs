using System;

namespace TP7Panaderia
{
    class InicioCoccion : Evento
    {
        private string nombreEvento = Constantes.ESTADO_INICIO_COCCION;
        private Reloj proximoFin;
        private double demora;

        public InicioCoccion(double demora)
        {
            this.demora = demora;
            this.proximoFin = new Reloj();
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
            this.proximoFin.setReloj(this.demora + reloj.getReloj());
        }

        public void setHoraFin(Reloj horaFin)
        {
            this.proximoFin = horaFin;
        }

        public double getTiempoEntreLlegada()
        {
            return this.demora;
        }

        public double getDemora()
        {
            return this.demora;
        }
    }
}
