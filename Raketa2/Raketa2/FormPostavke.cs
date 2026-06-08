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
    public partial class FormPostavke : Form
    {
        public FormPostavke()
        {
            InitializeComponent();
            StartForm.PridruziIzgledBrodu(izgled);
            DoubleBuffered = true;
            timer1.Start();
        }

        
        private void gumbNatrag_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StartForm.PomakniPozadinu();
            Invalidate();
        }

        private void FormPostavke_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 2; ++i)
            {
                e.Graphics.DrawImage(StartForm.pozadina, 0, StartForm.koordPozadina[i], StartForm.sirina, StartForm.visina + 5);
            }
        }

        private void listaZasicenost_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcija = Convert.ToString(listaZasicenost.SelectedItem);
            if (opcija == "slaba")
                Form1.zasicenost = 500;
            
            if (opcija == "jaka")
                Form1.zasicenost = 20;

            else
                Form1.zasicenost = 100;
            
        }

        private void listaBrzina_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcija = Convert.ToString(listaBrzina.SelectedItem);
            if (opcija == "sporo")
            {
                Form1.brzinaPrepreke = 0.5f;
            }
            if (opcija == "brzo")
            {
                Form1.brzinaPrepreke = 4;
            }
            else
            {
                Form1.brzinaPrepreke = 2;
            }
        }

        private void gumbPromijeniIzgled_Click(object sender, EventArgs e)
        {
            Brodovi brodovi = new Brodovi();
            brodovi.ShowDialog();
            if (StartForm.odabir == 1)
                izgled.Image = Properties.Resources.brod;
            if (StartForm.odabir == 2)
                izgled.Image = Properties.Resources.brod2;
            if (StartForm.odabir == 3)
                izgled.Image = Properties.Resources.brod3;
            if (StartForm.odabir == 4)
                izgled.Image = Properties.Resources.brod4;
            if (StartForm.odabir == 5)
                izgled.Image = Properties.Resources.brod5;
        }

        
    }
}
