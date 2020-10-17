using System;
using System.Collections.Generic;

namespace Pizzeria
{
	public class Delivery
	{
		private string estado;
		private Queue<Pedido> cola;
		private double horaInicioOcio;
		private double acumTiempoOcio;
		

		public Estados._EstadoEmpleado Estado
		{
			get;
			set;
		}

		public Estados._TipoPedido TipoServicio
		{
			get;
			set;
		}

		public Delivery(int id, double horaInicioOcio)
		{
			this.estado = "Libre";
			this.cola = new Queue<Pedido>();
			this.horaInicioOcio = horaInicioOcio;
			this.acumTiempoOcio = 0.0;
		
		}

	

		public void ponerEnCola(Pedido vehiculo)
		{
			this.cola.Enqueue(vehiculo);
		}

		public Pedido sacarDeCola()
		{
			return this.cola.Dequeue();
		}

		public void setEstado(string nombre)
		{
			estado = nombre;
		}

		public string getEstado()
		{
			return estado;
		}
		public int tamañoCola()
		{
			return this.cola.Count;
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

		public Queue<Pedido> getCola()
		{
			return this.cola;
		}
	}
}
