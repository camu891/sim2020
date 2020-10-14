using System;

namespace Pizzeria
{
	public abstract class Evento
	{
		public abstract double getProximaLlegada();

		public abstract string getNombreEvento();

		public abstract void simular(double reloj, double random);

		public abstract void simularDemora(double reloj, double random, string tipoPedido, int cantidad);
	}
}
