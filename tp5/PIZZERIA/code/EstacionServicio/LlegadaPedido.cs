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
		private double rndTipoPedido;
		private string tipoPedido;
		private int cantidad;

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

		public double getRandomTipoPed()
		{
			return this.rndTiempoCombustible;
		}
		public void setRandomTipoPed(double rnd)
		{
			this.rndTipoPedido=rnd ;
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
			Random rand = new Random();
			this.setRandomTipoPed(rand.NextDouble());
			this.tipoPedido = seleccionTipoPedido(rndTipoPedido);
			this.cantidad = cantidadPedido(tipoPedido);
		}
		
		private string seleccionTipoPedido(double rnd)
		{
			string tipo = "";
			double aux =Math.Round(rnd,2);
			if (aux >= 0 && aux < 0.19)
				tipo = "Sanduwich";
			if (aux >= 0.2 && aux < 0.59)
				tipo = "Pizza";
			if(aux >= 0.6 && aux < 0.89)
				tipo = "Empanadas";
			if (aux >= 0.9 && aux < 0.94)
				tipo = "Amburguesa";
			if (aux >= 0.95 && aux < 0.99)
				tipo = "Lomito";
			return tipo;

		}

		private int cantidadPedido(string pedido)
		{
			int cant = 0;
			switch (pedido)
			{
				case "Sanduwich":
					{ 
						cant= 12;
						break;
					}
				case "Pizza":
					{
						cant = 1;
						break;
					}
				case "Empanadas":
					{
						cant = 3;// Poisson 
						break;
					}
				case "Amburguesa":
					{
						cant = 1;
						break;
					}
				case "Lomito":
					{
						cant = 1;
						break;
					}


			}
			return cant;
		}

		public string getTipoPedido()
		{
			return seleccionTipoPedido(rndTipoPedido);
		}

		public void setTipoPedido(string tP)
		{
			tipoPedido = tP;
		}
		public void setCantidad(int cant)
		{
			cantidad = cant;
		}
		public int getCantidad()
		{
			return cantidad;
		}
	}
}
