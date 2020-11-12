using System;

namespace TP7FabricaGalletitas
{
    class FinDescarga : Evento
    {
        private string nombreEvento = Constantes.EVENTO_FIN_DESCARGA;
        private double rndTiempo;
        private double tiempoEntreLlegadas;
        private Reloj proximoFin;
        private Silo silo;
        private double demora;
        private int tasaDescarga;
        private double h;

        public FinDescarga(Silo silo, double h, int tasaDescarga)
        {
            this.silo = silo;
            this.tasaDescarga = tasaDescarga;
            this.h = h;

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

            if (this.tasaDescarga > 0)
            {
                //tasa por defecto 5 tn/hs
                this.demora = ((double)this.silo.getToneladasADescargar() / (double)this.tasaDescarga).TruncateDouble(2);
            }
            else {
                //Ecuacion diferencial
                this.demora = getDemoraDescarga(this.h, this.silo.getToneladasADescargar()); // USAR ECUACION DIFERENCIAL
            }
           
            
            this.proximoFin.setReloj(this.demora + reloj.getReloj());

            this.silo.setEstado(Constantes.ESTADO_SILO_SIENDO_LLENADO);
            this.silo.setDemora(this.demora);
            this.silo.setFinDescarga(this.proximoFin);
        }

        private double getDemoraDescarga(double h, int toneladasADescargar)
        { 
            //y'' = 4(y')^2+6y+8t
            // h=1 igual a 1 hora
            Double x1 = 0, x2 = 0;
            Double acuh = 0;
            while (x1 < toneladasADescargar)
            {
                double derivada = 4 * Math.Pow(x1, 2) + 6 * x2 + 8 * acuh;
                x1 = Euler.calEuler(x1, x2, h);
                x2 = Euler.calEuler(x2, derivada, h);
                acuh += h;
            }
            return acuh; 
        }

        public void setHoraFin(Reloj horaFin)
        {
            this.proximoFin = horaFin;
        }

        public double getTiempoEntreLlegada()
        {
            return this.demora;
        }

        public Silo getSilo() {
            return this.silo;
        }

        public void setSilo(Silo silo)
        {
            this.silo = silo;
        }

        public double getRandom()
        {
            return this.rndTiempo;
        }

    }
}
