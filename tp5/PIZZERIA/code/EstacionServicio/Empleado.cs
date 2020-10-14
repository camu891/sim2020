using System;
using System.Collections.Generic;

namespace Pizzeria
{
	public class Empleado
	{
		private Estados._EstadoEmpleado estado;
		//private Estados._TipoPedido tipoServicio;
		public static Queue<Pedido> cola;
		private double horaInicioOcio;
		private double acumTiempoOcio;
		private string nombreEstado;
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
			this.estado = Estados._EstadoEmpleado.Libre;
			//this.tipoServicio = tipo;
			//this.cola = new Queue<Pedido>();
			this.horaInicioOcio = horaInicioOcio;
			this.acumTiempoOcio = 0.0;
			//this.nombreEstado = nombre;
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

		public void setEstado(Estados._EstadoEmpleado estado)
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
