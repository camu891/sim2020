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

		public override void simular(double reloj, double random)
		{
			this.rndTiempo = random;
			this.demora = Distribuciones.Uniforme(this.desde, this.hasta, this.rndTiempo);
			this.proximoFin = this.demora + reloj;
		}
	}
}
