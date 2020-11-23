using System;

namespace TP7Panaderia
{
    class FinAtencion : Evento
    {
        private string nombreEvento = Constantes.EVENTO_FIN_ATENCION;
        private double rndDemora;
        private Reloj proximoFin;
        private Empleado empleado;
        private double demora;
        private double demoraA;
        private double demoraB;

        public FinAtencion(Empleado empl, double a, double b)
        {
            this.empleado = empl;
            this.demoraA = a;
            this.demoraB = b;

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
            this.rndDemora = random.TruncateDouble(2);
            this.demora = Distribuciones.Uniforme(demoraA, demoraB, random).TruncateDouble(2);
            this.proximoFin.setReloj(this.demora + reloj.getReloj());
            this.empleado.setEstado(Constantes.ESTADO_ATENDIENDO);
            this.empleado.setRNDDemora(this.rndDemora);
            this.empleado.setDemora(this.demora);
            this.empleado.setFinAtencion(this.proximoFin);
        }

        public void setHoraFin(Reloj horaFin)
        {
            this.proximoFin = horaFin;
        }

        public void setDemoraHoraFin(double demora)
        {
            this.proximoFin.setReloj(this.proximoFin.getReloj() + demora); ;
        }

        public void setDemora(double demora)
        {
            this.demora = demora;
        }

        public double getDemora()
        {
            return this.demora;
        }

        public double getTiempoEntreLlegada()
        {
            return this.demora;
        }

        public Empleado getEmpleado() {
            return this.empleado;
        }

        public void setEmpleado(Empleado silo)
        {
            this.empleado = silo;
        }

        public double getRandom()
        {
            return this.rndDemora;
        }

    }
}
