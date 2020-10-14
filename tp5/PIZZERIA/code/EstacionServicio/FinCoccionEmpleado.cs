using System;

namespace Pizzeria
{
	internal class FinCoccionEmpleado : Evento
	{
		private double rndTiempo;
		private double demora;
		private double proximoFin;
		private string nombreEvento = "fin_Coccion";
		private double desde;
		private double hasta;
		private int idEmpleado;

		public FinCoccionEmpleado(double a, double b, int id)
		{
			this.desde = a;
			this.hasta = b;
			this.idEmpleado = id;
		}

		public override string getNombreEvento()
		{
			return this.nombreEvento;
		}

		public int getIdEmpleado()
		{
			return this.idEmpleado;
		}

		public double getRandom()
		{
			return this.rndTiempo;
		}

		public double getTiempoEntreLlegada()
		{
			return this.demora;
		}

		public void setHoraFin(double horaFin)
		{
			this.proximoFin = horaFin;
		}

		public override double getProximaLlegada()
		{
			return this.proximoFin;
		}

		public override void simularDemora(double reloj, double random, string tipoPedido, int cantidad)
		{

			// pregutar si hay stock para calcular o no la demora
			this.rndTiempo = random;

			switch (tipoPedido)
			{
				case "Sandwich":
					{
						//Nor(u 10, r 5)
						break;
					}
				case "Pizza":
					{
						//Uni[15-18]
						break;
					}
				case "Empanadas":
					{
						//2,5 o 3,5
						break;
					}
				case "Hamburguesa":
					{
						// 8
						break;
					}
				case "Lomito":
					{
						// 8
						break;
					}

			}

			//this.demora = Distribuciones.Uniforme(this.desde, this.hasta, this.rndTiempo);
			this.demora = 1;
			this.proximoFin = this.demora + reloj;
		}

		public override void simular(double reloj, double random) { }
	}
}
