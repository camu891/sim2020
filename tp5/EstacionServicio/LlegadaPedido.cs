namespace Pizzeria
{
    class LlegadaPedido : Evento
    {
        private double rndTiempoCombustible;
        private double tiempoEntreLlegadas;
        private double proximaLlegada;
        private string nombreEvento = "llegada_combustible";
        private double mu;


        public LlegadaPedido(double mu)
        {
            this.mu = mu;
            
        }
        public override string getNombreEvento()
        {
            return nombreEvento;
        }

        public double getRandom()
        {
            return rndTiempoCombustible;
        }
        public double getTiempoEntreLlegada()
        {
            return tiempoEntreLlegadas;
        }
        public override double getProximaLlegada()
        {
            return proximaLlegada;
        }

        public override void simular(double reloj, double random)
        {
            
            rndTiempoCombustible = random;
            tiempoEntreLlegadas = Distribuciones.Exponencial(mu, rndTiempoCombustible);
            proximaLlegada = tiempoEntreLlegadas + reloj;
        }
    }
}
