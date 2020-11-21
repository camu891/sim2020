using System;

namespace TP7Panaderia
{
    class FinCoccion : Evento
    {
        private string nombreEvento = Constantes.ESTADO_FIN_COCCION;
        private Reloj proximoFin;
        private double demora;
        private double h;
        private double relHMin;
        private double Temp0;
        private double tiempoCoccionTempMax;

        public FinCoccion(double h, double relHMin, double T0, double tiempoCoccionTempMax)
        {
            this.h = h;
            this.relHMin = relHMin;
            this.Temp0 = T0;
            this.tiempoCoccionTempMax = tiempoCoccionTempMax;
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

        public override void simular(Reloj reloj, double cantProd)
        {
            this.demora = getDemoraCoccion(h, cantProd);
            this.proximoFin.setReloj(this.demora + reloj.getReloj());
        }

        private double getDemoraCoccion(double h, double cantProductos)
        {
            //dT/dt=-0.5T + 900/cantProductos
            // h=1 igual a 1 min
            double T0 = Temp0, T1 = 0;
            double t = 0;
            double coccion = 0;
            while (coccion < tiempoCoccionTempMax)
            {
                double derivada = (-0.5 * T0) + (900/cantProductos);
                T1 = Math.Round(Euler.calEuler(T0, derivada, h),1);
                t += h;
                if (T0 == T1)
                    coccion += h/relHMin;
                T0 = T1;
            }
            return Math.Round(t-h /relHMin,2);
        }

        public void setHoraFin(Reloj horaFin)
        {
            this.proximoFin = horaFin;
        }

        public double getTiempoEntreLlegada()
        {
            return this.demora;
        }

        public void setDemora(double demora)
        {
            this.demora = demora;
        }

        public double getDemora()
        {
            return this.demora;
        }

    }
}
