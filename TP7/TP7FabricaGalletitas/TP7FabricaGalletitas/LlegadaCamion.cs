using System;

namespace TP7FabricaGalletitas
{
    class LlegadaCamion : Evento
    {
        private string nombreEvento = Constantes.EVENTO_LLEGADA_CAMION;
        private static int id;
        private double rndTiempoLlegada;
        private double tiempoEntreLlegadas;
        private Reloj proximaLlegada;

        private Camion camion;

        private int a;
        private int b;
        private double probTipoCamion;

        public LlegadaCamion()
        {
        }

        public LlegadaCamion(int a, int b, double probTipoCamion)
        {
            id++;
            proximaLlegada = new Reloj();
            this.a = a;
            this.b = b;
            this.probTipoCamion = probTipoCamion;
        }

        public override string getNombreEvento()
        {
            return this.nombreEvento;
        }

        public override Reloj getProximoTiempo()
        {
            return this.proximaLlegada;
        }

        public void setProximaLlegada(double entreLlegada, Reloj reloj)
        {
            double prox = entreLlegada + reloj.getReloj();
            proximaLlegada.setReloj(prox);
        }

        public double getTiempoEntreLlegada()
        {
            return this.tiempoEntreLlegadas.TruncateDouble(2);
        }

        public override void simular(Reloj reloj, double random)
        {

            this.rndTiempoLlegada = random;
            this.tiempoEntreLlegadas = Distribuciones.Uniforme(this.a, this.b, random);
            setProximaLlegada(tiempoEntreLlegadas, reloj);

            //seteo tipo camion
            double r = new Random((int)DateTime.Now.Ticks).NextDouble().TruncateDouble(2);
            setCamion(new Camion(r, this.probTipoCamion));

        }

        public double getRandom()
        {
            return this.rndTiempoLlegada.TruncateDouble(2);
        }

        public int getId() {
            return id;
        }

        public void setCamion(Camion camion)
        {
            this.camion = camion;
        }

        public Camion getCamion()
        {
            return camion;
        }
    }
}
