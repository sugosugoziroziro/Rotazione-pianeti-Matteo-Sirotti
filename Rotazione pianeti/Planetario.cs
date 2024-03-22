using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rotazione_pianeti
{
    internal class Planetario
    {
       public List<Pianeta> Pianeti { get; set; }
       public Planetario(List<Pianeta> lista) 
        {
            Pianeti = lista;
        }
        public Planetario() 
        { 
            Pianeti=new List<Pianeta>();    
        }
        public void Muovi()
             {
                foreach (Pianeta pianeta in Pianeti)
                {
                    
                    CalcolaForza();
                    pianeta.Posizione += pianeta.Velocita *DeltaT + 0.5 * pianeta.Accelerazione * DeltaT * DeltaT;
                    pianeta.Velocita += pianeta.Accelerazione* DeltaT;
      
                }
               
            }
        public  double DeltaT { get { return 0.000002; } }

        public void CalcolaForza()
        {
            double gk = 1E-4;

            foreach (Pianeta p1 in Pianeti) //  per ogni pianeta nel planetario
            {
                foreach (Pianeta p2 in Pianeti) // confrontiamolo con gli altri pianeti per calcolare la forza
                {
                    if(p1==p2)
                    {
                        continue;
                    }

                    p1.Forza += ((gk * p1.Massa * p2.Massa) / ((p2.Posizione - p1.Posizione).Modulo() * (p2.Posizione - p1.Posizione).Modulo())) * (p2.Posizione - p1.Posizione).Versore();     // definisci G    
                }
            }
        }
    }
}

