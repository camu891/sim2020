using System;

namespace Pizzeria
{
	public abstract class Evento
	{
		public abstract Reloj getProximaLlegada();

		public abstract string getNombreEvento();

		public abstract void simular(Reloj reloj, double random);

		public abstract void simularDemora(Reloj reloj, double random, LlegadaPedido lp);
	}
}
