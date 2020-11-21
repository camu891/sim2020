using System;

namespace TP7Panaderia
{
    class LlegadaCliente : Evento
    {
        private string nombreEvento = Constantes.EVENTO_LLEGADA;
        private static int id;
        private double rndTiempoLlegada;
        private double rndCantProductos;
        private double tiempoEntreLlegadas;
        private Reloj proximaLlegada;

        private Cliente cliente;

        private int a;
        private int b;
        private double mediaLlegadas;
        private int cantProductos;

        public LlegadaCliente()
        {
        }

        public LlegadaCliente(int a, int b, double mediaLlegadas)
        {
            id++;
            proximaLlegada = new Reloj();
            this.a = a;
            this.b = b;
            this.mediaLlegadas = mediaLlegadas;
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

        public override void simular(Reloj reloj, double randomLlegada)
        {

            this.rndTiempoLlegada = randomLlegada;
            this.tiempoEntreLlegadas = Distribuciones.Exponencial(this.mediaLlegadas, randomLlegada);
            setProximaLlegada(tiempoEntreLlegadas, reloj);

            //seteo catidad de produtos
            rndCantProductos = new Random((int)DateTime.Now.Ticks).NextDouble().TruncateDouble(2); ;
            cantProductos = (int) Math.Round(Distribuciones.Uniforme(a, b, rndCantProductos));
            // TODO sacar lo de Camion
            setCliente(new Cliente(cantProductos));

        }

        public int getCantProd()
        {
            return cantProductos;
        }

        public double getRandomCant()
        {
            return rndCantProductos;
        }

        public double getRandom()
        {
            return this.rndTiempoLlegada.TruncateDouble(2);
        }

        public int getId() {
            return id;
        }

        public void setCliente(Cliente cliente)
        {
            this.cliente = cliente;
        }

        public Cliente getCliente()
        {
            return cliente;
        }
    }
}
