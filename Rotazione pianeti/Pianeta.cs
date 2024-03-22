using System;

using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rotazione_pianeti
{
    internal class Pianeta
    {
        public double Massa { get; set; }
        public Vettore Velocita { get; set; }
        public Vettore Posizione { get; set; }
        public Vettore Forza { get; set; }
        public Vettore Accelerazione { get { return Forza / Massa; }}
        public Pianeta(double m, Vettore v, Vettore p)
        {
            Massa = m;
            Velocita = v;
            Posizione = p;
            Forza = new Vettore();
        }
      
        public override string ToString()
        {
            return $"m={Massa}, v={Velocita}, p={Posizione}"; // 1,3,5
        }
        public static Pianeta Parse(string s) // prova il Parse e fai TryParse del pianeta?? serve davvero?
        {
            char[] separatori = { '=',','};
            string[] b = new string[3];
            b=s.Split(separatori);
            return new Pianeta(double.Parse(b[1]), Vettore.Parse(b[3]), Vettore.Parse(b[5])) ;
        }
       
        
    }
}
