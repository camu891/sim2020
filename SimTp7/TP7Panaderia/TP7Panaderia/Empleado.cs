
namespace TP7Panaderia
{
    public class Empleado
    {
        private int id;
        private string estado; //LIBRE, SIENDO_ATENDIDO
        private Reloj finAtencion;
        private double demora;
        private double rndDemora;

        public Empleado(int id)
        {
            this.id = id;
            this.estado = Constantes.ESTADO_LIBRE;
            this.finAtencion = new Reloj();
        }

        public Empleado()
        {
            this.estado = Constantes.ESTADO_LIBRE;
        }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }


        public double getDemora()
        {
            return this.demora;
        }

        public void setDemora(double demora)
        {
            this.demora = demora;
        }

        public double getRNDDemora()
        {
            return this.rndDemora;
        }

        public void setRNDDemora(double rnd)
        {
            this.rndDemora = rnd;
        }

        public Reloj getFinAtencion()
        {
            return this.finAtencion;
        }

        public void setFinAtencion(Reloj finAtencion)
        {
            this.finAtencion = finAtencion;
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
