﻿using System;
using System.Linq;

namespace Pizzeria
{
	public class LlegadaPedido : Evento
	{
		private double rndTiempoLlegada;
		private double tiempoEntreLlegadas;
		private Reloj proximaLlegada;
		private string nombreEvento = "llegada_Pedido";
		private double mu;
		private Pedido pedido;
		private double rndTipoPedido;
		private double minutosTurno;
		/*
		private string tipoPedido;
		private int cantidad;
		*/
		private double precioVenta; // Agregar en grilla para calculo de Var est.

		public LlegadaPedido()
		{

		}

		public LlegadaPedido(double mu, int cantHoras)
		{
			this.mu = mu;
			proximaLlegada = new Reloj();
			minutosTurno = cantHoras * 60;
		}

		public override string getNombreEvento()
		{
			return this.nombreEvento;
		}

		public double getRandom()
		{
			return this.rndTiempoLlegada;
		}

		public double getRandomTipoPed()
		{
			return this.rndTipoPedido;
		}
		public void setRandomTipoPed(double rnd)
		{
			this.rndTipoPedido = rnd;
		}
		public double getTiempoEntreLlegada()
		{
			return this.tiempoEntreLlegadas;
		}

		public override Reloj getProximaLlegada()
		{
			return this.proximaLlegada;
		}

		public Pedido getPedido()
		{
			return pedido;
		}

		public void setPedido(Pedido p)
		{
			pedido = p;
		}
		public override void simular(Reloj reloj, double random)
		{
			if (reloj.getReloj() == 0.00)
			{
				this.rndTiempoLlegada = random;
				this.tiempoEntreLlegadas = Distribuciones.poisson(this.mu, this.rndTiempoLlegada);
				setProximaLlegada(tiempoEntreLlegadas, reloj);
			}
			else
			{
				this.rndTiempoLlegada = random;
				this.tiempoEntreLlegadas = Distribuciones.poisson(this.mu, this.rndTiempoLlegada);
				setProximaLlegada(tiempoEntreLlegadas, reloj);
				Random rand = new Random();
				this.setRandomTipoPed(rand.NextDouble());
				string tipoPedido = seleccionTipoPedido(rndTipoPedido);
				double rndCant = 0.0;
				if (tipoPedido.Equals("Empanadas"))
					rndCant = rand.NextDouble();
				int cantidad = cantidadPedido(tipoPedido, rndCant);
				pedido = new Pedido("En preparacion", tipoPedido, cantidad, reloj, rndCant);
			}


		}

		public void setProximaLlegada(double entreLlegada, Reloj reloj)
		{
			double prox = this.tiempoEntreLlegadas + reloj.getReloj();
			if (prox > minutosTurno)
			{
				if (reloj.getTurno().Equals(Estados._TipoTurno.Tarde))
				{
					proximaLlegada.cambioTurno();
					proximaLlegada.addDia();
					proximaLlegada.setReloj(prox - minutosTurno);
				}
				else
				{
					proximaLlegada.cambioTurno();
					proximaLlegada.setReloj(prox - minutosTurno);
				}
			}
			else
			{
				proximaLlegada.setReloj(prox);
			}
		}

		private string seleccionTipoPedido(double rnd)
		{
			double aux = (double)Math.Round(rnd, 2);
			if (aux >= 0 && aux <= 0.19)
				return "DocSandwich";
			if (aux >= 0.20 && aux <= 0.59)
				return "Pizza";
			if (aux >= 0.60 && aux <= 0.89)
				return "Empanadas";
			if (aux >= 0.90 && aux <= 0.94)
				return "Hamburguesa";
			if (aux >= 0.95 && aux <= 0.99)
				return "Lomito";
			return "";
		}

		private int cantidadPedido(string pedido, double rnd)
		{
			int cant = 0;
			switch (pedido)
			{
				case "Empanadas":
					{
						cant = Distribuciones.poisson(3, rnd);
						break;
					}
				default:
					{
						cant = 1;
						break;
					}

			}
			return cant;
		}

		public override void simularDemora(Reloj reloj, double random, LlegadaPedido llegP) { }

	}
}
