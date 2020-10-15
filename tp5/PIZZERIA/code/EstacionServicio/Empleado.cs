using System;
using System.Collections.Generic;

namespace Pizzeria
{
	public class Empleado
	{
		private string estado;

		private double horaInicioOcio;
		private double acumTiempoOcio;

		private double demora;
		private double finCoccion;
		private bool pierdeCliente;

		//public Estados._EstadoEmpleado Estado
		//{
		//	get;
		//	set;
		//}

		public Empleado(int id, double horaInicioOcio)
		{
			this.estado = "Libre";
			this.horaInicioOcio = horaInicioOcio;
			this.acumTiempoOcio = 0.0;
			//this.tipoServicio = tipo;
			//this.cola = new Queue<Pedido>();
			//this.nombreEstado = nombre;
		}

		public Empleado(string estado, double demora)
		{
			this.estado = estado;
			this.demora = demora;
						
		}


		public double getDemora()
		{
			return this.demora;
		}

		public void setDemora(double demora)
		{
			this.demora = demora;
		}

		public double getFinCoccion()
		{
			return this.finCoccion;
		}

		public void setgetFinCoccion(double finCoccion)
		{
			this.finCoccion = finCoccion;
		}

		public string getEstado()
		{
			return this.estado;
		}

		public void setEstado(string estado)
		{
			this.estado = estado;
		}

		public void setHoraInicioOcio(double horaInicio)
		{
			this.horaInicioOcio = horaInicio;
		}

		public double getHoraInicioOcio()
		{
			return this.horaInicioOcio;
		}

		public void acumularTiempoOcio(double tiempoOcio)
		{
			this.acumTiempoOcio += tiempoOcio;
		}

		//public Queue<Pedido> getCola()
		//{
		//	return this.cola;
		//}
	}
}
