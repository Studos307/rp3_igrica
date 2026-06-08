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
    public partial class FormUpute : Form
    {
        public FormUpute()
        {
            InitializeComponent();
            DoubleBuffered = true;
            progressBarVrijeme.Value = 600;
            progressBar1.Value = 20;
            progressBar2.Value = 40;

        }

        private void FormUpute_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 2; ++i)
            {
                e.Graphics.DrawImage(StartForm.pozadina, 0, StartForm.koordPozadina[i], StartForm.sirina, StartForm.visina + 5);
            }
        }

        private void gumbNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
