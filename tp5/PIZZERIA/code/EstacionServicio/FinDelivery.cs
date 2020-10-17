using System;

namespace Pizzeria
{
	internal class FinDelivery : Evento
	{
		private double rndTiempo;
		private double demora;
		private double proximoFin;
		private string nombreEvento = "fin_delivery";
		private double desde;
		private double hasta;
		private double cteDemora;

		public FinDelivery(double a, double b, int id, double cte)
		{
			this.desde = a;
			this.hasta = b;
			this.cteDemora = cte;
		}

		public override string getNombreEvento()
		{
			return this.nombreEvento;
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

		public override void simular(double reloj, double random)
		{
			this.rndTiempo = random;
			this.demora = Distribuciones.Uniforme(this.desde, this.hasta, this.rndTiempo) + this.cteDemora;
			this.proximoFin = this.demora + reloj;
		}

		public override void simularDemora(double reloj, double random, LlegadaPedido llegP) { }
	}
}
