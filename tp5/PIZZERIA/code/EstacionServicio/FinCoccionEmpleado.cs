using System;
using System.Collections.Generic;
using System.Linq;

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
		private Empleado e;
		private LlegadaPedido llegadaP;

		public Empleado Empleado { get => e; set => e = value; }

		public FinCoccionEmpleado(double a, double b, int id, Empleado empleado)
		{
			this.desde = a;
			this.hasta = b;
			this.idEmpleado = id;
			this.e = empleado;
		}

		public override string getNombreEvento()
		{
			return this.nombreEvento;
		}

		public LlegadaPedido getLlegada()
		{
			return llegadaP;
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

		public override void simularDemora(double reloj, double random, LlegadaPedido llegP)
		{

			// pregutar si hay stock para calcular o no la demora
			this.rndTiempo = random;
			double demoraPedido = 0.0;
			llegadaP = llegP;
			switch (llegP.getPedido().Tipo)
			{
				case "DocSandwich":
					{
						//Nor(u 10, r 5)
						demoraPedido = getDemoraSandwich(random);
						break;
					}
				case "Pizza":
					{
						//Uni[15-18]
						demoraPedido = getDemoraPizza(random);
						break;
					}
				case "Empanadas":
					{
						//2,5 o 3,5
						demoraPedido = getDemoraEmpanadas(llegP.getPedido().Cantidad);
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
			// actualiza empleado
			e.setEstado("Ocupado");
			e.setDemora(this.demora);
			e.setgetFinCoccion(this.proximoFin);
		}

		public override void simular(double reloj, double random) { }

		private double getDemoraSandwich(double random) {
			return Distribuciones.normal(10, 5).First();
		}

		private double getDemoraPizza(double random)
		{
			return Distribuciones.Uniforme(15, 8, random);
		}


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
