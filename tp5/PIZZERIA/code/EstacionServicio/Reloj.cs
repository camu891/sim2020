using Pizzeria;
using System.Collections.Generic;
using static Pizzeria.Estados;

namespace Pizzeria
{
    public class Reloj
    {
        private double reloj = 0.0;
        private _TipoTurno turno = _TipoTurno.Mañana;
        private int dia = 0;

        public Reloj(double reloj, _TipoTurno turno, int dia)
        {
            this.reloj = reloj;
            this.turno = turno;
            this.dia = dia;
        }

        public Reloj()
        {
            this.reloj = 0.0;
            this.turno = _TipoTurno.Mañana;
            this.dia = 0;
        }

        public double getReloj()
        {
            return this.reloj;
        }

        public int getDia()
        {
            return this.dia;
        }

        public _TipoTurno getTurno()
        {
            return this.turno;
        }

        public void setDia(int dia)
        {
            this.dia = dia;
        }

        public void setTurno(_TipoTurno turno)
        {
            this.turno = turno;
        }

        public void addDia()
        {
            this.dia++;
        }

        public void cambioTurno()
        {
            if(this.turno == _TipoTurno.Mañana)
            {
                this.turno = _TipoTurno.Tarde;
            } else
            {
                this.turno = _TipoTurno.Mañana;
            }
        }

        public void setReloj(double reloj)
        {
            this.reloj = reloj;
        }
    }
}
