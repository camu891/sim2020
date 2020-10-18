using System;
using System.Linq;

namespace Pizzeria
{
	public class LlegadaPedido : Evento
	{
		private double rndTiempoCombustible;
		private double tiempoEntreLlegadas;
		private Reloj proximaLlegada;
		private string nombreEvento = "llegada_Pedido";
		private double mu;
		private Pedido pedido;
		private double rndTipoPedido;
		/*
		private string tipoPedido;
		private int cantidad;
		*/
		private double precioVenta; // Agregar en grilla para calculo de Var est.

		public LlegadaPedido()
		{
			
		}

		public LlegadaPedido(double mu)
		{
			this.mu = mu;
			proximaLlegada = new Reloj();
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

		public override Reloj getProximaLlegada()
		{
			return this.proximaLlegada;
		}

		public Pedido getPedido()
		{
			return pedido;
		}

		public void setPedido(Pedido p)
		{
			pedido= p;
		}
		public override void simular(Reloj reloj, double random)
		{
			if (reloj.getReloj() == 0.00)
			{
				this.rndTiempoCombustible = random;
				this.tiempoEntreLlegadas = Distribuciones.Exponencial(this.mu, this.rndTiempoCombustible);
				setProximaLlegada(tiempoEntreLlegadas, reloj);
			}
			else
			{
				this.rndTiempoCombustible = random;
				this.tiempoEntreLlegadas = Distribuciones.Exponencial(this.mu, this.rndTiempoCombustible);
				setProximaLlegada(tiempoEntreLlegadas, reloj);
				Random rand = new Random();
				this.setRandomTipoPed(rand.NextDouble());
				string tipoPedido = seleccionTipoPedido(rndTipoPedido);
				int cantidad = cantidadPedido(tipoPedido);
				pedido = new Pedido("En preparacion", tipoPedido, cantidad, reloj);
			}
	
			
		}

		public void setProximaLlegada(double entreLlegada, Reloj reloj)
        {
			/*
			if ((this.tiempoEntreLlegadas + reloj.getReloj()) > 360)
			{
				double diff = this.tiempoEntreLlegadas + reloj.getReloj() - 6;
				reloj.setReloj(diff);
				if (reloj.getTurno() == Estados._TipoTurno.Tarde)
                {
					reloj.addDia();
                }
                else
                {
					reloj.cambioTurno();
                }
            } else
            {
				double sum = this.tiempoEntreLlegadas + reloj.getReloj();
				reloj.setReloj(sum);
			}
			*/
			proximaLlegada.setReloj(this.tiempoEntreLlegadas + reloj.getReloj());
		}
		
		private string seleccionTipoPedido(double rnd)
		{
			string tipoP = "";
			double aux = (double) Math.Round(rnd,2);
			if (aux >= 0 && aux <= 0.19)
			tipoP = "DocSandwich";
			if (aux >= 0.20 && aux <= 0.59)
				tipoP = "Pizza";
			if (aux >= 0.60 && aux <= 0.89)
				tipoP = "Empanadas";
			if (aux >= 0.90 && aux <= 0.94)
				tipoP = "Hamburguesa";
			if (aux >= 0.95 && aux <= 0.99)
				tipoP = "Lomito";

			return tipoP;
		}

		private int cantidadPedido(string pedido)
		{
			int cant = 0;
			switch (pedido)
			{
				case "DocSandwich":
					{ 
						cant = 12;
						break;
					}
				case "Pizza":
					{
						cant = 1;
						break;
					}
				case "Empanadas":
					{
						Distribuciones dist = new Distribuciones();
						cant = dist.GenerateCSharpRandomsPoisson(1, 3).First<int>();// Poisson 
						break;
					}
				case "Hamburguesa":
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

	
		public override void simularDemora(Reloj reloj, double random, LlegadaPedido llegP) { }

	}
}
