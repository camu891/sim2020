using static Pizzeria.Estados;

namespace Pizzeria
{
    public class Pedido
    {
        private string id;
        private _EstadoPedido estado;
        private _TipoPedido tipoServicio;
        private double horaInicioEspera;

        public Pedido(string id, _EstadoPedido estado, _TipoPedido tipo, double horaInicioEspera)
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
            return horaInicioEspera;
        }

        public _TipoPedido Tipo
        {
            get { return tipoServicio; }
            set { tipoServicio = value; }
        }

        public _EstadoPedido Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
