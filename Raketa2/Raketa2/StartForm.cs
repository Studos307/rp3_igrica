using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raketa2
{
    public partial class StartForm : Form
    {

        public static void PomakniPozadinu()
        {
            for (int i = 0; i < 2; ++i)
            {
                
                if (koordPozadina[i] > visina)
                    koordPozadina[i] -= 2 * visina;
                else koordPozadina[i] += brzinaPozadine;


            }
        }
        public StartForm()
        {
            InitializeComponent(); 
            
            sirina = ClientSize.Width;
            visina = ClientSize.Height;
            brzinaPozadine = 0.5f;
            koordPozadina = new float[] { -visina, 0 };
            DoubleBuffered = true;
            
            timer1.Start();
        }

        public static Image pozadina = Properties.Resources.pozadina2;
        public static float[] koordPozadina;
        public static float sirina, visina, brzinaPozadine;
        public static int odabir = 1;
        
        private void gumbZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PomakniPozadinu();
            Invalidate();
        }

        private void gumbPostavke_Click(object sender, EventArgs e)
        {

            FormPostavke formaZaPostavke = new FormPostavke();
            this.Visible = false;
            formaZaPostavke.ShowDialog();
            this.Visible = true;
               
        }

        public void StartForm_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 2; ++i)
            {
                e.Graphics.DrawImage(pozadina, 0, koordPozadina[i], sirina, visina + 5);
            }
        }

        private void gumbUpute_Click(object sender, EventArgs e)
        {
            FormUpute formaZaUpute = new FormUpute();
            this.Visible = false;
            formaZaUpute.ShowDialog();
            this.Visible = true;
        }

        private void gumbPokreni_Click(object sender, EventArgs e)
        {
            Form1 formaZaIgru = new Form1();
            this.Visible = false;
            formaZaIgru.ShowDialog();
            this.Visible = true;
        }

        public static void PridruziIzgledBrodu(PictureBox x)
        {
            if (StartForm.odabir == 1)
                x.Image = Properties.Resources.brod;
            if (StartForm.odabir == 2)
                x.Image = Properties.Resources.brod2;
            if (StartForm.odabir == 3)
                x.Image = Properties.Resources.brod3;
            if (StartForm.odabir == 4)
                x.Image = Properties.Resources.brod4;
            if (StartForm.odabir == 5)
                x.Image = Properties.Resources.brod5;
        }
    }
}
