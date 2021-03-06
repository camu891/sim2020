﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Pizzeria
{
	public class FinCoccionEmpleado : Evento
	{
		private double rndTiempo;
		private double demora;
		private Reloj proximoFin;
		private string nombreEvento = "fin_Coccion";
		private double promSandwich;
		private double desvSandwich;
		private double desdePizza;
		private double hastaPizza;
		private double demoraEmpanadax3;
		private double demoraEmpanadax2;
		private double demoraHamburguesa;
		private double demoraLomo;
		private double demora_acu;
		private int idEmpleado;
		private Reloj entroped;
		private Empleado e;
		private LlegadaPedido llegadaP;
		private double minutosH;

		public FinCoccionEmpleado(double promSandwich, double desvSandwich, double desdePizza, double hastaPizza, double demoraEmpanadax3, double demoraEmpanadax2, double demoraHamburguesa, double demoraLomo, int idEmpleado, Empleado empleado, double minutosH)
		{
			this.promSandwich = promSandwich;
			this.desvSandwich = desvSandwich;
			this.desdePizza = desdePizza;
			this.hastaPizza = hastaPizza;
			this.demoraEmpanadax3 = demoraEmpanadax3;
			this.demoraEmpanadax2 = demoraEmpanadax2;
			this.demoraHamburguesa = demoraHamburguesa;
			this.demoraLomo = demoraLomo;
			this.idEmpleado = idEmpleado;
			this.e = empleado;
			proximoFin = new Reloj();
			this.minutosH = minutosH;
		}

		public Empleado Empleado { get => e; set => e = value; }

		public override string getNombreEvento()
		{
			return this.nombreEvento;
		}
		public Reloj getEntPed()
		{
			return entroped;
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

		public double getDemora_Acu()
		{
			return this.demora_acu;
		}

		public double getTiempoEntreLlegada()
		{
			return this.demora;
		}

		public void setHoraFin(Reloj horaFin)
		{
			this.proximoFin = horaFin;
		}

		public override Reloj getProximaLlegada()
		{
			return this.proximoFin;
		}

		public override void simularDemora(Reloj reloj, double random, LlegadaPedido llegP)
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
					{
						// 8
						demoraPedido = demoraHamburguesa;
						break;
					}
				case "Lomito":
					{
						// 8
						demoraPedido = demoraLomo;
						break;
					}

			}

			this.demora = demoraPedido;
			this.proximoFin.setDia(reloj.getDia());
			this.proximoFin.setTurno(reloj.getTurno());
			this.proximoFin.setReloj(this.demora + reloj.getReloj());
			this.entroped = llegP.getPedido().getInicioEspera();
			this.demora_acu = demoraPedido + (reloj.getReloj() - llegP.getPedido().getInicioEspera().getReloj());


			// actualiza empleado
			e.setEstado("Ocupado");
			e.setDemora(this.demora);
			e.setFinCoccion(this.proximoFin);

		}

		public override void simular(Reloj reloj, double random) { }

		private double getDemoraSandwich(double random) {
			return Distribuciones.normal(this.promSandwich, this.desvSandwich, random);
		}

		private double getDemoraPizza(double random)
		{
			// return Distribuciones.Uniforme(this.desdePizza, this.hastaPizza, random);

			//dE/dt=-k*E-1,99+0.0001t
			//K distribucion uniforme (0.3 - 0.8)
			//E siempre inicia en 100% y cuando llega a 0 finaliza
			// h=0.05 igual a 1 minuto
			Double E = this.hastaPizza;
			Double k = Distribuciones.Uniforme(0.3, 0.8, random);
			Double h = this.desdePizza;
			Double acuh = 0;
			int corridas = 0;
			while (E > 0)
			{ 
				corridas++;
				double derivada = -k * E - 1.99 + 0.0001*acuh;
				E = caleuler(E, derivada, h);
				acuh += h;
			}
			Console.WriteLine("k: " + k + " Euler: " + acuh / minutosH);
			return acuh/ minutosH; //Representa que un minuto es 0,05 de H
		}

		private double caleuler(double xi, double xderivada, double hciclo)
		{
			// xi+1=xi+h*derivada de xi
			return xi + (hciclo * xderivada);	
		}

		private double getDemoraEmpanadas(int cantidad) {

			double division = cantidad / 3;
			double calculo = 0;
			while (division > 0)
			{
				calculo += demoraEmpanadax3;
				division--;
			}
			if (cantidad%3 != 0)
			{
				calculo += demoraEmpanadax2;
			}

			return calculo;

		}
	}
}
