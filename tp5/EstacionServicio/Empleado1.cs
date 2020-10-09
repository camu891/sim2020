using System.Collections.Generic;
using static Pizzeria.Estados;

namespace Pizzeria
{
    public class Empleado1
    {
        private _EstadoEmpleado estado;
        private _TipoPedido tipoServicio;
        private int idSurtidor;
        private Queue<Pedido> cola;
        private double horaInicioOcio;
        private double acumTiempoOcio;
        private string nombreEstado;


        public Empleado1(int id, _TipoPedido tipo, double horaInicioOcio, string nombre)
        {
            estado = _EstadoEmpleado.Libre;
            tipoServicio = tipo;
            cola = new Queue<Pedido>();
            idSurtidor = id;
            this.horaInicioOcio = horaInicioOcio;
            acumTiempoOcio = 0.00;
            nombreEstado = nombre;

        }
        public _EstadoEmpleado Estado { get; set; }

        public _TipoPedido TipoServicio { get; set; }
        
        public string getNombreEstado()
        {
            return nombreEstado;
        }

        public void ponerEnCola(Pedido vehiculo)
        {
            cola.Enqueue(vehiculo);
        }

        public Pedido sacarDeCola()
        {
            return cola.Dequeue();
        }

        public void setNombreEstado(string nombre)
        {
            nombreEstado = nombre;
        }

        public int tamañoCola()
        {
            return cola.Count;
        }

        public void setIdSurtidor(int id)
        {
            this.idSurtidor = id;
        }

        public int getIdSurtidor()
        {
            return idSurtidor;
        }

        public void setHoraInicioOcio(double horaInicio)
        {
            this.horaInicioOcio = horaInicio;
        }

        public double getHoraInicioOcio()
        {
            return horaInicioOcio;
        }

        public void acumularTiempoOcio(double tiempoOcio)
        {
            acumTiempoOcio += tiempoOcio;
        }
        public Queue<Pedido> getCola()
        {
            return cola;
        }

    }
}
