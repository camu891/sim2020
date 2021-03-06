﻿using System;

namespace Pizzeria
{
	public class Pedido
	{
		public static int id;
		private string estado;
		private string tipoServicio;
		private int cantidad;
		private double rndCantidad;
		private Reloj horaInicioEspera;

		public string Tipo
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

		public double RndCantidad
		{
			get
			{
				return this.rndCantidad;
			}
			set
			{
				this.rndCantidad = value;
			}
		}

		public string Estado
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

		public int Cantidad
		{
			get
			{
				return this.cantidad;
			}
			set
			{
				this.cantidad = value;
			}
		}

		public Pedido(string estado, string tipo,int cant, Reloj horaInicioEspera, double rndCant)
		{
			id++;
			this.estado = estado;
			this.tipoServicio = tipo;
			cantidad = cant;
			this.horaInicioEspera = horaInicioEspera;
			this.rndCantidad = rndCant;
		}

		public void setHoraInicioEspera(Reloj horaInicioEspera)
		{
			this.horaInicioEspera = horaInicioEspera;
		}

		public Reloj getInicioEspera()
		{
			return this.horaInicioEspera;
		}

		public int getId() {
			return id;
		}
	}
}
