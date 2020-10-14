using System;
using System.Collections.Generic;

namespace Pizzeria
{
	public class Empleado
	{
		private string estado;
		//private Estados._TipoPedido tipoServicio;
		public static Queue<Pedido> cola;
		private double horaInicioOcio;
		private double acumTiempoOcio;
		//private string nombreEstado;
		private double demora;
		private double finCoccion;
		private bool pierdeCliente;

		public Estados._EstadoEmpleado Estado
		{
			get;
			set;
		}

		public Empleado(int id, double horaInicioOcio)
		{
			this.estado = "Libre";
			//this.tipoServicio = tipo;
			//this.cola = new Queue<Pedido>();
			this.horaInicioOcio = horaInicioOcio;
			this.acumTiempoOcio = 0.0;
			//this.nombreEstado = nombre;
		}

		public Empleado(string estado, double demora)
		{
			this.estado = estado;
			this.demora = demora;
						
		}

		//public string getNombreEstado()
		//{
		//	return this.nombreEstado;
		//}

		//public void ponerEnCola(Pedido vehiculo)
		//{
		//	this.cola.Enqueue(vehiculo);
		//}

		//public Pedido sacarDeCola()
		//{
		//	return this.cola.Dequeue();
		//}

		//public int tamañoCola()
		//{
		//	return this.cola.Count;
		//}

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
