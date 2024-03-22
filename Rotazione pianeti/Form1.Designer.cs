namespace Rotazione_pianeti
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstPianeti = new System.Windows.Forms.ListBox();
            this.txtPosizione = new System.Windows.Forms.TextBox();
            this.txtVelocita = new System.Windows.Forms.TextBox();
            this.txtMassa = new System.Windows.Forms.TextBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMuovi = new System.Windows.Forms.Button();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.btnSet1 = new System.Windows.Forms.Button();
            this.btnPulisci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPianeti
            // 
            this.lstPianeti.FormattingEnabled = true;
            this.lstPianeti.Location = new System.Drawing.Point(0, 0);
            this.lstPianeti.Name = "lstPianeti";
            this.lstPianeti.Size = new System.Drawing.Size(203, 95);
            this.lstPianeti.TabIndex = 0;
            // 
            // txtPosizione
            // 
            this.txtPosizione.Location = new System.Drawing.Point(287, 15);
            this.txtPosizione.Name = "txtPosizione";
            this.txtPosizione.Size = new System.Drawing.Size(70, 20);
            this.txtPosizione.TabIndex = 1;
            // 
            // txtVelocita
            // 
            this.txtVelocita.Location = new System.Drawing.Point(287, 41);
            this.txtVelocita.Name = "txtVelocita";
            this.txtVelocita.Size = new System.Drawing.Size(70, 20);
            this.txtVelocita.TabIndex = 2;
            // 
            // txtMassa
            // 
            this.txtMassa.Location = new System.Drawing.Point(287, 67);
            this.txtMassa.Name = "txtMassa";
            this.txtMassa.Size = new System.Drawing.Size(70, 20);
            this.txtMassa.TabIndex = 3;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(109, 101);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(94, 23);
            this.btnAggiungi.TabIndex = 4;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(228, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Posizione";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(228, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Velocità";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(228, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Massa";
            // 
            // btnMuovi
            // 
            this.btnMuovi.Location = new System.Drawing.Point(0, 101);
            this.btnMuovi.Name = "btnMuovi";
            this.btnMuovi.Size = new System.Drawing.Size(103, 23);
            this.btnMuovi.TabIndex = 8;
            this.btnMuovi.Text = "Muovi";
            this.btnMuovi.UseVisualStyleBackColor = true;
            this.btnMuovi.Click += new System.EventHandler(this.btnMuovi_Click);
            // 
            // tmr
            // 
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // btnSet1
            // 
            this.btnSet1.Location = new System.Drawing.Point(130, 130);
            this.btnSet1.Name = "btnSet1";
            this.btnSet1.Size = new System.Drawing.Size(49, 23);
            this.btnSet1.TabIndex = 9;
            this.btnSet1.Text = "Set";
            this.btnSet1.UseVisualStyleBackColor = true;
            this.btnSet1.Click += new System.EventHandler(this.btnSet1_Click);
            // 
            // btnPulisci
            // 
            this.btnPulisci.Location = new System.Drawing.Point(33, 130);
            this.btnPulisci.Name = "btnPulisci";
            this.btnPulisci.Size = new System.Drawing.Size(49, 23);
            this.btnPulisci.TabIndex = 10;
            this.btnPulisci.Text = "Pulisci";
            this.btnPulisci.UseVisualStyleBackColor = true;
            this.btnPulisci.Click += new System.EventHandler(this.btnPulisci_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.btnPulisci);
            this.Controls.Add(this.btnSet1);
            this.Controls.Add(this.btnMuovi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.txtMassa);
            this.Controls.Add(this.txtVelocita);
            this.Controls.Add(this.txtPosizione);
            this.Controls.Add(this.lstPianeti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ClientSizeChanged += new System.EventHandler(this.Form1_ClientSizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPianeti;
        private System.Windows.Forms.TextBox txtPosizione;
        private System.Windows.Forms.TextBox txtVelocita;
        private System.Windows.Forms.TextBox txtMassa;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMuovi;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Button btnSet1;
        private System.Windows.Forms.Button btnPulisci;
    }
}

