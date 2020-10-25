using System;
using System.Collections.Generic;

namespace Pizzeria
{
	public class Empleado
	{
		private string estado;
		private int id;
		private double horaInicioOcio;
		private double acumTiempoOcio;

		private double demora;
		private Reloj finCoccion;
		private bool pierdeCliente;

		//public Estados._EstadoEmpleado Estado
		//{
		//	get;
		//	set;
		//}

		public Empleado(int id, double horaInicioOcio)
		{
			this.id = id;
			this.estado = "Libre";
			this.horaInicioOcio = horaInicioOcio;
			this.acumTiempoOcio = 0.0;
			finCoccion = new Reloj();
		    //this.tipoServicio = tipo;
			//this.cola = new Queue<Pedido>();
			//this.nombreEstado = nombre;
		}

		public Empleado(string estado, double demora)
		{
			this.estado = estado;
			this.demora = demora;
						
		}

		public int getId() {
			return id;
		}

		public void setId(int id)
		{
			this.id = id;
		}

		public double getDemora()
		{
			return this.demora;
		}

		public void setDemora(double demora)
		{
			this.demora = demora;
		}

		public Reloj getFinCoccion()
		{
			return this.finCoccion;
		}

		public void setFinCoccion(Reloj finCoccion)
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
