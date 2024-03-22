using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rotazione_pianeti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        Planetario planetario = new Planetario();
        SolidBrush PennelloPianeta = new SolidBrush(Color.OrangeRed);
        SolidBrush PennelloTraiettoria = new SolidBrush(Color.Aquamarine);
        Color coloreSfondo = (Color.MidnightBlue);
        SolidBrush PennelloSfondo = new SolidBrush(Color.MidnightBlue);
        int aumentaSpostamento =20;  
        

        private void button1_Click(object sender, EventArgs e)
        {
            double m;
            Vettore v;
            Vettore p;
            
            Graphics g = this.CreateGraphics();
            double centroX = ClientRectangle.Width / 2;
            double centroY = ClientRectangle.Height / 2;
            

           //lstPianeti.Items.Add(new Pianeta(100, new Vettore(0,0), new Vettore(0, 0)));// togli
            //planetario.Pianeti.Add(new Pianeta(100, new Vettore(0, 0), new Vettore(0, 0)));

            //lstPianeti.Items.Add(new Pianeta(40, new Vettore(0,10), new Vettore(10, 0)));
            //planetario.Pianeti.Add(new Pianeta(40, new Vettore(0,10), new Vettore(10, 0)));// togli

            //lstPianeti.Items.Add(new Pianeta(100, new Vettore(-10, 0), new Vettore(-10, 0)));// togli
            //planetario.Pianeti.Add(new Pianeta(100, new Vettore(-10, 0), new Vettore(-10, 0)));

             if (double.TryParse(txtMassa.Text, out m) && Vettore.TryParse(txtVelocita.Text,out v) && Vettore.TryParse(txtPosizione.Text,out p))
             {

             Pianeta pianeta = new Pianeta(m,v,p);
             lstPianeti.Items.Add(pianeta);
             planetario.Pianeti.Add(pianeta);
                DisegnaPianeta(pianeta);
             }
              else
             {
             MessageBox.Show("ERRORE", "I valori inseriti sono errati ");
             }


        }
        

        private void btnMuovi_Click(object sender, EventArgs e)
        {
            tmr.Start();
        }

       
        private void tmr_Tick(object sender, EventArgs e)
        {
            foreach (Pianeta p in planetario.Pianeti)
            {

                CancellaPianeta(p);
                
            }

            Graphics g = this.CreateGraphics();
            
            for (int i = 0; i < 900; i++)
            {
                planetario.Muovi();
            }
            

               foreach (Pianeta p in planetario.Pianeti)
            {
                DisegnaTraiettoria(p);
                DisegnaPianeta(p);
               
            }


        }
        double aumentaDimensionePianeta = 2;
        void DisegnaPianeta(Pianeta p)
        {
            Graphics g = this.CreateGraphics();
          
            double latoQuadratoPianeta = Math.Pow(p.Massa, 0.33) * aumentaDimensionePianeta;
            double centroX = ClientRectangle.Width / 2 - latoQuadratoPianeta / 2;
            double centroY = ClientRectangle.Height / 2 - latoQuadratoPianeta / 2;

            g.FillEllipse(PennelloPianeta, (float)(centroX + p.Posizione.X * aumentaSpostamento), (float)(centroY - p.Posizione.Y * aumentaSpostamento), (float)latoQuadratoPianeta, (float)latoQuadratoPianeta);


        }
        void CancellaPianeta(Pianeta p)
        {
            Graphics g = this.CreateGraphics();

            double latoQuadratoPianeta = Math.Pow(p.Massa, 0.33) * aumentaDimensionePianeta;
            double centroX = ClientRectangle.Width / 2 - latoQuadratoPianeta / 2;
            double centroY = ClientRectangle.Height / 2 - latoQuadratoPianeta / 2;

            g.FillEllipse(PennelloSfondo, (float)(centroX + p.Posizione.X * aumentaSpostamento), (float)(centroY - p.Posizione.Y * aumentaSpostamento), (float)latoQuadratoPianeta, (float)latoQuadratoPianeta);


        }
        void DisegnaTraiettoria(Pianeta p)
        {
            Graphics g = this.CreateGraphics();
            double latoQuadratoPianeta = Math.Pow(p.Massa, 0.33) * aumentaDimensionePianeta;
            double centroX = ClientRectangle.Width / 2 - latoQuadratoPianeta / 2;
            double centroY = ClientRectangle.Height / 2 - latoQuadratoPianeta / 2;
            g.FillEllipse(PennelloTraiettoria, (float)(centroX + p.Posizione.X * aumentaSpostamento), (float)(centroY - p.Posizione.Y * aumentaSpostamento),(float)( latoQuadratoPianeta*1.2), (float)(latoQuadratoPianeta*1.2) ); 


        }


        public void Form1_Load(object sender, EventArgs e)
        {
            
        }
        int Xa;
        int Ya;
        int Xb;
        int Yb;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Xa = e.X;
            Ya = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Xb = e.X;
            Yb = e.Y;
            txtVelocita.Text = new Vettore(Xb-Xa,-Yb+Ya).ToString();
            txtPosizione.Text= new Vettore((Xa- ClientRectangle.Width / 2)/aumentaSpostamento, (-Ya+ClientRectangle.Height / 2)/aumentaSpostamento).ToString();  
        }

        private void btnSet1_Click(object sender, EventArgs e)
        {
            lstPianeti.Items.Add(new Pianeta(100, new Vettore(0,0), new Vettore(0, 0)));// togli
            planetario.Pianeti.Add(new Pianeta(100, new Vettore(0, 0), new Vettore(0, 0)));

            lstPianeti.Items.Add(new Pianeta(40, new Vettore(0,10), new Vettore(10, 0)));
            planetario.Pianeti.Add(new Pianeta(40, new Vettore(0,10), new Vettore(10, 0)));// togli

            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(coloreSfondo);
        }

        private void btnPulisci_Click(object sender, EventArgs e)
        {
            lstPianeti.Items.Clear();
            tmr.Stop();
            Graphics g = this.CreateGraphics();
            g.Clear(coloreSfondo);
            planetario.Pianeti.Clear();


        }
    }
}

