using System;
using System.Collections.Generic;

namespace Pizzeria
{
	public class Delivery
	{
		private Estados._EstadoEmpleado estado;
		private Estados._TipoPedido tipoServicio;
		private int idSurtidor;
		private Queue<Pedido> cola;
		private double horaInicioOcio;
		private double acumTiempoOcio;
		private string nombreEstado;

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

		public Delivery(int id, Estados._TipoPedido tipo, double horaInicioOcio, string nombre)
		{
			this.estado = Estados._EstadoEmpleado.Libre;
			this.tipoServicio = tipo;
			this.cola = new Queue<Pedido>();
			this.idSurtidor = id;
			this.horaInicioOcio = horaInicioOcio;
			this.acumTiempoOcio = 0.0;
			this.nombreEstado = nombre;
		}

		public string getNombreEstado()
		{
			return this.nombreEstado;
		}

		public void ponerEnCola(Pedido vehiculo)
		{
			this.cola.Enqueue(vehiculo);
		}

		public Pedido sacarDeCola()
		{
			return this.cola.Dequeue();
		}

		public void setNombreEstado(string nombre)
		{
			this.nombreEstado = nombre;
		}

		public int tamañoCola()
		{
			return this.cola.Count;
		}

		public void setIdSurtidor(int id)
		{
			this.idSurtidor = id;
		}

		public int getIdSurtidor()
		{
			return this.idSurtidor;
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
