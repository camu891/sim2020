using System;

namespace Pizzeria
{
	public class Pedido
	{
		private string id;
		private Estados._EstadoPedido estado;
		private Estados._TipoPedido tipoServicio;
		private double horaInicioEspera;

		public Estados._TipoPedido Tipo
		{
			get
			{
				return this.tipoServicio;
			}
			set
			{
				this.tipoServicio = value;
			}
		}

		public Estados._EstadoPedido Estado
		{
			get
			{
				return this.estado;
			}
			set
			{
				this.estado = value;
			}
		}

		public string Id
		{
			get
			{
				return this.id;
			}
			set
			{
				this.id = value;
			}
		}

		public Pedido(string id, Estados._EstadoPedido estado, Estados._TipoPedido tipo, double horaInicioEspera)
		{
			this.id = id;
			this.estado = estado;
			this.tipoServicio = tipo;
			this.horaInicioEspera = horaInicioEspera;
		}

		public void setHoraInicioEspera(double horaInicioEspera)
		{
			this.horaInicioEspera = horaInicioEspera;
		}

		public double getInicioEspera()
		{
			return this.horaInicioEspera;
		}
	}
}
