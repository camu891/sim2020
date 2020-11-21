using System;

namespace TP7Panaderia
{
    public class Reloj : IComparable, IEquatable<Reloj>
    {
        private double reloj;
        private double comparable;

        public Reloj(double reloj)
        {
            this.reloj = reloj;
            comparable = reloj;
        }

        public Reloj()
        {
            this.reloj = 0.0;
            comparable = 0;
        }

        public double getReloj()
        {
            return this.reloj.TruncateDouble(2);
        }

        public void setReloj(double reloj)
        {
            this.reloj = reloj;
            setComparable(reloj);
        }

        public void setComparable(double hora)
        {
            this.comparable = hora;
        }

        public int CompareTo(object obj)
        {
            Reloj otherReloj = obj as Reloj;
            return this.comparable.CompareTo(otherReloj.comparable);
        }

        public double getComparable()
        {
            return comparable;
        }

        public bool Equals(Reloj other)
        {
            return this.reloj.Equals(other.reloj);
        }
    }
}
