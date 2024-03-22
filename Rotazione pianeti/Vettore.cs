using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotazione_pianeti
{
    internal class Vettore
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Vettore(double x, double y) { X = x; Y = y; }
        public Vettore() { }

        public double Modulo()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
      
        public Vettore Versore()
        {
            return this / Modulo();

        }
     
        public static Vettore operator *(Vettore v, double d)
        {
            return new Vettore(v.X * d, v.Y * d);
        }
        public static Vettore operator *(double d, Vettore v)
        {
            return new Vettore(v.X * d, v.Y * d);
        }
        public static Vettore operator +(Vettore v1, Vettore v2)
        {
            return new Vettore(v1.X + v2.X, v1.Y + v2.Y);
        }
        public static Vettore operator -(Vettore v1, Vettore v2)
        {
            return new Vettore(v1.X - v2.X, v1.Y - v2.Y);
        }
        public static Vettore operator /(Vettore v, double d)
        {
            return new Vettore(v.X / d, v.Y / d);

        }
       
        public override string ToString()
        {
            return $"{X},{Y}";
        }
        public static Vettore Parse(string s)
        {
            string[] b = new string[2];
            b = s.Split(',');
            return new Vettore(double.Parse(b[0]), double.Parse(b[1]));
        }
        public static bool TryParse(string s,out Vettore v)// tryparse
        {
            try
            {
                v = Vettore.Parse(s);
                    return true;
             

            }
            catch 
            {
                v = null;
                return false;

            }
           
        }
        public static bool operator ==(Vettore v1, Vettore v2)
        {
            if (Object.ReferenceEquals(v1, null))
            {
                if (Object.ReferenceEquals(v2, null))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (Object.ReferenceEquals(v2, null))
                return false;
            else
            {
                if (v1.X == v2.X && v2.Y == v1.Y) { return v1.Equals(v2); }
                else return false;
            }
        }
        public static bool operator !=(Vettore v1, Vettore v2)
        {
            if (v1 == v2)
                return false;
            else
                return true;
        }

    }
}
