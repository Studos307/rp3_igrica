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
    public partial class Brodovi : Form
    {
        public Brodovi()
        {
            InitializeComponent();
            DoubleBuffered = true;
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            StartForm.odabir = 1;
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            StartForm.odabir = 2;
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            StartForm.odabir = 3;
            Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            StartForm.odabir = 4;
            Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            StartForm.odabir = 5;
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StartForm.PomakniPozadinu();
            Invalidate();
        }

        private void Brodovi_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 2; ++i)
            {
                e.Graphics.DrawImage(StartForm.pozadina, 0, StartForm.koordPozadina[i], StartForm.sirina, StartForm.visina + 5);
            }
        }
    }
}
