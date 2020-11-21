
namespace TP7Panaderia
{
    public class Horno
    {
        private string estado; //Apagado, Encendido
        private Reloj finCoccion;
        private double demora;
        private int cantidad;

        public Horno()
        {
            this.cantidad = 0;
            this.estado = Constantes.ESTADO_APAGADO;
        }

        public Horno(int cantidad)
        {
            this.cantidad = cantidad;
            this.estado = Constantes.ESTADO_ENCENDIDO;
        }

        public int getCantidad()
        {
            return this.cantidad;
        }

        public double getDemora()
        {
            return this.demora;
        }

        public void setDemora(double demora)
        {
            this.demora = demora;
        }

        public Reloj getFinCoccion()
        {
            return this.finCoccion;
        }

        public void setFinCoccion(Reloj finCoccion)
        {
            this.finCoccion = finCoccion;
        }

        public string getEstado()
        {
            return this.estado;
        }

        public void setEstado(string estado)
        {
            this.estado = estado;
        }

    }
}
