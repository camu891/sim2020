using Pizzeria;
using System;
using System.Collections.Generic;
using static Pizzeria.Estados;

namespace Pizzeria
{
    public class Reloj : IComparable, IEquatable<Reloj>
    {
        private double reloj;
        private _TipoTurno turno;
        private int dia;
        private double comparable;
        private int minutosXDia = 1440;

        public Reloj(double reloj, _TipoTurno turno, int dia)
        {
            this.reloj = reloj;
            this.turno = turno;
            this.dia = dia;
            comparable = reloj;
        }

        public Reloj()
        {
            this.reloj = 0.0;
            this.turno = _TipoTurno.Mañana;
            this.dia = 0;
            comparable = 0;
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
            setComparable(reloj);
        }

        public void setComparable(double hora)
        {
            if (this.dia > 0)
            {
                this.comparable = (dia * minutosXDia) + hora;
            } else
            {
                this.comparable = hora;
            }
              
        }

        public int CompareTo(object obj)
        {
            Reloj otherReloj = obj as Reloj;
            return this.comparable.CompareTo(otherReloj.comparable);
        }

        public bool Equals(Reloj other)
        {
            // return this.dia.Equals(other.dia) && this.reloj.Equals(other.reloj);
            return this.reloj.Equals(other.reloj);
        }
    }
}
