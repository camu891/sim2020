using System;

namespace Pizzeria
{
	internal class FinDelivery : Evento
	{
		private double rndTiempo;
		private double demora;
		private Reloj proximoFin;
		private string nombreEvento = "fin_delivery";
		private double desde;
		private double hasta;
		private double cteDemora;
		private Delivery delivery;


		public FinDelivery(double a, double b, int id, double cte)
		{
			this.desde = a;
			this.hasta = b;
			this.cteDemora = cte;
			proximoFin = new Reloj();
		}

		public void setDelivery(Delivery d)
		{
			delivery = d;
		}

		public Delivery GetDelivery()
		{
			return delivery;
		}

		public override string getNombreEvento()
		{
			return this.nombreEvento;
		}

		public double getRandom()
		{
			return this.rndTiempo;
		}
		public double getDemoraDel()
		{
			return this.demora;
		}
		public double getTiempoEntreLlegada()
		{
			return this.demora;
		}

		public void setHoraFin(Reloj horaFin)
		{
			this.proximoFin = horaFin;
		}

		public override Reloj getProximaLlegada()
		{
			return this.proximoFin;
		}

		public override void simular(Reloj reloj, double random)
		{
			this.rndTiempo = random;
			this.demora = Distribuciones.Exponencial(3, new Random().NextDouble());
			this.proximoFin.setDia(reloj.getDia());
			this.proximoFin.setTurno(reloj.getTurno());
		}

		public override void simularDemora(Reloj reloj, double random, LlegadaPedido llegP) { }
	}
}
