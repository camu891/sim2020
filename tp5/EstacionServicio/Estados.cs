namespace Pizzeria
{
    public class Estados
    {
        public enum _EstadoPedido
        {
            Esperando_Atencion_Conbustible,
            Esperando_Atencion_Gas,
            Siendo_Atendido_Conbustible,
            Siendo_Atendido_Gas
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
    }
}
