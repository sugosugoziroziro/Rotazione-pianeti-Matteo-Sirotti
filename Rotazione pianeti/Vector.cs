using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotazione_pianeti
{
    internal class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Vector(double x, double y) { X = x; Y = y; }
        public double Module()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
        public double Angle()
        {
            return (double)Math.Atan2(Y, X);
        }
        public Vector Versor()
        {
            return this / Module();

        }
        public static double operator *(Vector v1, Vector v2)
        {
            if (v1.Angle() >= v2.Angle())
            {
                return v1.Module() * v2.Module() * Math.Cos(v1.Angle() - v2.Angle());
            }
            else
            {
                return v1.Module() * v2.Module() * Math.Cos(v2.Angle() - v1.Angle());
            }
        }
        public static Vector operator *(Vector v, double d)
        {
            return new Vector(v.X * d, v.Y * d);
        }
        public static Vector operator *(double d, Vector v)
        {
            return new Vector(v.X * d, v.Y * d);
        }
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y);
        }
        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.X - v2.X, v1.Y - v2.Y);
        }
        public static Vector operator /(Vector v, double d)
        {
            return new Vector(v.X / d, v.Y / d);

        }
        public static double operator +(Vector v)
        {
            return v.Module();
        }
        public static double operator -(Vector v)
        {
            return -v.Module();
        }
        public override string ToString()
        {
            return $"([X],[Y])";
        }
        public static Vector Parse(string s)
        {
            string[] b = new string[2];
            b = s.Split(',');
            return new Vector(double.Parse(b[0]), double.Parse(b[1]));
        }
        public static bool TryParse(string s)
        {
            try
            {
                if (Vector.Parse(s).ToString() == s)
                    return true;
                else
                    return false;

            }
            catch (Exception e)
            {
                return false;

            }

        }
        public static bool operator ==(Vector v1, Vector v2)
        {
            if (Object.ReferenceEquals(v1, v2))
                return true;
            else
                return false;
        }
        public static bool operator !=(Vector v1, Vector v2)
        {
            if (Object.ReferenceEquals(v1, v2))
                return false;
            else
                return true;
        }

    }
}
