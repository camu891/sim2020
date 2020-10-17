using System;

namespace Pizzeria
{
	public class Estados
	{
		public enum _EstadoPedido
		{
			Esperando_Atencion,
			En_Preparacion,
			En_delivery
		}

		public enum _EstadoEmpleado
		{
			Libre,
			Ocupado
		}

		public enum _TipoPedido
		{
			DocSandwich,
			Pizza,
			Empanadas,
			Hamburguesa,
			Lomito
		}

		public enum _TipoTurno
		{
			Mañana,
			Tarde
		}
	}
}
