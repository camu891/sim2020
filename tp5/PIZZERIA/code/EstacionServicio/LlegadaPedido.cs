using System;

namespace Pizzeria
{
	internal class LlegadaPedido : Evento
	{
		private double rndTiempoCombustible;
		private double tiempoEntreLlegadas;
		private double proximaLlegada;
		private string nombreEvento = "llegada_Pedido";
		private double mu;

		public LlegadaPedido(double mu)
		{
			this.mu = mu;
		}

		public override string getNombreEvento()
		{
			return this.nombreEvento;
		}

		public double getRandom()
		{
			return this.rndTiempoCombustible;
		}

		public double getTiempoEntreLlegada()
		{
			return this.tiempoEntreLlegadas;
		}

		public override double getProximaLlegada()
		{
			return this.proximaLlegada;
		}

		public override void simular(double reloj, double random)
		{
			this.rndTiempoCombustible = random;
			this.tiempoEntreLlegadas = Distribuciones.Exponencial(this.mu, this.rndTiempoCombustible);
			this.proximaLlegada = this.tiempoEntreLlegadas + reloj;
		}
	}
}
