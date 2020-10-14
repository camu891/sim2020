using System;

namespace Pizzeria
{
	public class FinCoccionEmpleado : Evento
	{
		private double rndTiempo;
		private double demora;
		private double proximoFin;
		private string nombreEvento = "fin_Coccion";
		private double desde;
		private double hasta;
		private int idEmpleado;
		//private 
		
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
			double demoraPedido = 0.0;

			switch (tipoPedido)
			{
				case "DocSandwich":
					{
						//Nor(u 10, r 5)
						demoraPedido = 20;
						break;
					}
				case "Pizza":
					{
						//Uni[15-18]
						demoraPedido = 15;
						break;
					}
				case "Empanadas":
					{
						//2,5 o 3,5
						demoraPedido = getDemoraEmpanadas(cantidad);
						break;
					}
				case "Hamburguesa":
				case "Lomito":
					{
						// 8
						demoraPedido = 8;
						break;
					}

			}

			this.demora = demoraPedido;
			this.proximoFin = this.demora + reloj;
		}

		public override void simular(double reloj, double random) { }


		private double getDemoraEmpanadas(int cantidad) {

			double division = cantidad / 3;
			double calculo = 0;
			while (division > 0)
			{
				calculo += 3.5;
				division--;
			}
			if (cantidad%3 != 0)
			{
				calculo += 2.5;
			}

			return calculo;

		}
	}
}
