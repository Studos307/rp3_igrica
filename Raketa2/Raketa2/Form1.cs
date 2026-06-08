using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raketa2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            StartForm.PridruziIzgledBrodu(brod);
            //labelaBodovi.Parent = prepreka1;
            //labelaBodovi1.Parent = prepreka2;
            //labelaBodovi.Location = labelaBodovi1.Location = new Point(4, 4);
            labelaBodovi.Visible = labelaBodovi1.Visible = false;
            progressBar1.Parent = prepreka1;
            progressBar2.Parent = prepreka2;
            progressBar1.Location = progressBar2.Location = new Point(10, 10);
            labelaOznaka.Parent = prepreka2;
            labelaOznaka.Location = new Point(
                prepreka2.Width - labelaOznaka.Width - 5,
                prepreka2.Height / 2 - labelaOznaka.Height / 2
                );
            labelaOznaka.Visible = false;
            sirina = ClientSize.Width;
            visina = ClientSize.Height - statusStrip1.Height;
            PocetnePostavke();
            DoubleBuffered = true;
            timer1.Start();
            this.KeyPreview = true;

        }
        public static int zasicenost = 100;
        public static float brzinaPrepreke = 2;
        Image pozadina = Properties.Resources.pozadina2;
        Image zid = Properties.Resources.zid2;
        float sirina, visina;
        float brzinaPozadine, brzinaZida,
            brzinaBroda;
        float[] koordPozadina, koordZid;
        bool kretanje, lijevo, desno, krajIgre, prepreka1_desno, prepreka2_desno, izvrsivo = true;
        int bodovi, zivoti, brojprepreka;
        Random random = new Random();
        SoundPlayer zvukUdar = new SoundPlayer(@"boom.wav");
        SoundPlayer zvukKraj = new SoundPlayer(@"gameover.wav");
        SoundPlayer zvukZivot = new SoundPlayer(@"zivot.wav");
        SoundPlayer zvukBod = new SoundPlayer(@"bod.wav");

        

        private void StvoriKomet()
        {
            PictureBox komet = new PictureBox();
            komet.Size = new Size(20, 20);
            komet.BackColor = Color.Transparent;
            komet.Image = Properties.Resources.komet;
            komet.SizeMode = PictureBoxSizeMode.StretchImage;
            komet.BorderStyle = BorderStyle.None;
            komet.Top = -komet.Height;
            komet.Left = (int)(0.1 * sirina + 1)
                + random.Next(0, (int)(0.8 * sirina - komet.Width));
            komet.Tag = "komet";
            Controls.Add(komet);
            komet.BringToFront();
        }

        private void StvoriRaketu()
        {
            PictureBox raketa = new PictureBox();
            raketa.Size = new Size(20, 20);
            raketa.BackColor = Color.Transparent;
            raketa.Image = Properties.Resources.raketa;
            raketa.SizeMode = PictureBoxSizeMode.StretchImage;
            raketa.BorderStyle = BorderStyle.None;
            raketa.Top = (int)visina - brod.Size.Height - 5 - raketa.Height;
            raketa.Left = (brod.Left + brod.Right) / 2 - raketa.Width / 2;
            raketa.Tag = "raketa";
            Controls.Add(raketa);
            raketa.BringToFront();
        }

        private void StvoriZivot()
        {
            PictureBox zivot = new PictureBox();
            zivot.Size = new Size(20, 20);
            zivot.BackColor = Color.Transparent;
            zivot.Image = Properties.Resources.zivot;
            zivot.SizeMode = PictureBoxSizeMode.StretchImage;
            zivot.BorderStyle = BorderStyle.None;
            zivot.Top = -zivot.Height;
            zivot.Left = (int)(0.1 * sirina + 1)
                + random.Next(0, (int)(0.8 * sirina - zivot.Width));
            zivot.Tag = "zivot";
            Controls.Add(zivot);
            zivot.BringToFront();
        }

        private void StvoriSatelit()
        {
            PictureBox satelit = new PictureBox();
            satelit.Size = new Size(20, 20);
            satelit.BackColor = Color.Transparent;
            satelit.Image = Properties.Resources.satelit;
            satelit.SizeMode = PictureBoxSizeMode.StretchImage;
            satelit.BorderStyle = BorderStyle.None;
            satelit.Top = -satelit.Height;
            satelit.Left = (int)(0.1 * sirina + 1)
                + random.Next(0, (int)(0.8 * sirina - satelit.Width));
            satelit.Tag = "satelit";
            Controls.Add(satelit);
            satelit.BringToFront();
        }

        private void StvoriBudilicu()
        {
            PictureBox budilica = new PictureBox();
            budilica.Size = new Size(20, 20);
            budilica.BackColor = Color.Transparent;
            budilica.Image = Properties.Resources.budilica;
            budilica.SizeMode = PictureBoxSizeMode.StretchImage;
            budilica.BorderStyle = BorderStyle.None;
            budilica.Top = -budilica.Height;
            budilica.Left = (int)(0.1 * sirina + 1)
                + random.Next(0, (int)(0.8 * sirina - budilica.Width));
            budilica.Tag = "budilica";
            Controls.Add(budilica);
            budilica.BringToFront();
        }

        private void povecajBodove(int dobiveniBodovi)
        {
            if (dobiveniBodovi > 0) zvukBod.Play();
            bodovi += dobiveniBodovi;
            labelaBodovi.Text = labelaBodovi1.Text = "Bodovi: " + bodovi;
            labelaBodoviSS.Text = "Bodovi: " + bodovi;
        }

        private void povecajPrepreke()
        {
            brojprepreka += 1;

            if ((brojprepreka + 2) % 10 == 0)
            {

                labelaOznaka.Text = "" + (brojprepreka + 2);
                labelaOznaka.Visible = true;
                if ((brojprepreka + 2) % 20 == 0)
                {
                    prepreka2.Image = Properties.Resources.prepreka5;
                }
                else
                {
                    prepreka2.Image = Properties.Resources.prepreka4;
                }
            }

            else if ((brojprepreka + 1) % 10 == 0)
            {
                labelaOznaka.Text = "" + (brojprepreka + 1);
                labelaOznaka.Visible = true;
                if ((brojprepreka + 1) % 20 == 0)
                {
                    prepreka1.Image = Properties.Resources.prepreka5;
                }
                else
                {
                    prepreka1.Image = Properties.Resources.prepreka4;
                }
            }

            else
                labelaOznaka.Visible = false;


        }

        private void smanjiZivote(int kolicina)
        {
            
            zivoti -= kolicina;
            if (zivoti == 3)
            {
                labelaZivotiSS.Text = "♥♥♥";
                return;
            }

            if (zivoti == 2)
            {
                labelaZivotiSS.Text = "♥♥";
                return;
            }

            if (zivoti == 1)
            {
                labelaZivotiSS.Text = "♥";
                return;
            }

            if (zivoti == 0)
            {
                labelaZivotiSS.Text = "";
                return;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            izvrsivo = true;
            timer2.Stop();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if(!krajIgre)
            {
                timer1.Start();
                labelaPauza.Visible = false;
            }
        }
        private void Form1_Deactivate(object sender, EventArgs e)
        {
            if(!krajIgre)
            {
                timer1.Stop();
                if (kretanje || lijevo || desno)
                    kretanje = lijevo = desno = false;
                labelaPauza.Visible = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && !kretanje)
                kretanje = true;
            if (e.KeyCode == Keys.Left)
                lijevo = true;
            if (e.KeyCode == Keys.Right)
                desno = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && kretanje)
                kretanje = false;
            if (e.KeyCode == Keys.Left)
                lijevo = false;
            if (e.KeyCode == Keys.Right)
                desno = false;
            if (e.KeyCode == Keys.R && krajIgre)
            {
                PocetnePostavke();
                timer1.Start();
            }
            //3. pauziranje pritiskom na P
            if (e.KeyCode == Keys.P && !krajIgre)
            {
                if (!labelaPauza.Visible)
                {
                    timer1.Stop();
                    kretanje = lijevo = desno = false;
                    labelaPauza.Visible = true;
                }
                else
                {
                    timer1.Start();
                    labelaPauza.Visible = false;
                }
            }
            //ispaljivanje rakete
            if (e.KeyCode == Keys.Space && !krajIgre 
                && !labelaPauza.Visible && izvrsivo)
            {
                izvrsivo = false;
                StvoriRaketu();
                timer2.Start();
            }
        }

        private void PocetnePostavke()
        {
            progressBarVrijeme.Value = progressBarVrijeme.Maximum; //1000
            progressBar1.Value = progressBar1.Maximum;
            progressBar2.Value = progressBar2.Maximum; 
            brzinaPozadine = 0.5f;
            brzinaZida = 4;
            brzinaBroda = 5;
            //brzinaPrepreke = 2; 
            koordPozadina = new float[] { -visina, 0 };
            koordZid = new float[] { -visina, 0 };
            brod.Location = new Point(
                (int)sirina / 2 - brod.Size.Width / 2,
                (int)visina - brod.Size.Height - 5
            );
            kretanje = lijevo = desno = false;
            prepreka1_desno = prepreka2_desno = true;
            bodovi = 0;
            zivoti = 3;
            povecajBodove(0);
            smanjiZivote(0);
            brojprepreka = 0;
            krajIgre = false;
            labelaRestartPoruka.Visible = false;
            prepreka1.Location = new Point(10, 205);
            prepreka2.Location = new Point(205, 10);
            labelaPauza.Visible = false;
            labelaOznaka.Visible = false;
            prepreka1.Image = Properties.Resources.prepreka5;
            prepreka2.Image = Properties.Resources.prepreka5;
        }

        private void PomakniPozadinu()
        {
            for (int i = 0; i < 2; ++i)
            {
                if (koordPozadina[i] > visina)
                    koordPozadina[i] -= 2 * visina;
                if (kretanje)
                {
                    koordPozadina[i] += brzinaPozadine;
                }
            }
        }

        private void PomakniZid()
        {
            for (int i = 0; i < 2; ++i)
            {
                if (koordZid[i] > visina)
                    koordZid[i] -= 2 * visina;
                if (kretanje)
                    koordZid[i] += brzinaZida;
            }
        }
        
        private void PomakniPrepreke()
        {
            //prepreka1
            if (prepreka1.Left > 0 && !prepreka1_desno)
                prepreka1.Left -= (int)brzinaPrepreke;

            if (prepreka1.Right < sirina && prepreka1_desno)
                prepreka1.Left += (int)brzinaPrepreke;

            if (prepreka1.Left <= 0 && !prepreka1_desno)
            {
                prepreka1_desno = true;
                prepreka1.Left += (int)brzinaPrepreke;
            }
            
            if (prepreka1.Right >= sirina && prepreka1_desno)
            {
                prepreka1_desno = false;
                prepreka1.Left -= (int)brzinaPrepreke;
            }
            //prepreka2
            if (prepreka2.Left > 0 && !prepreka2_desno)
                prepreka2.Left -= (int)brzinaPrepreke;

            if (prepreka2.Right < sirina && prepreka2_desno)
                prepreka2.Left += (int)brzinaPrepreke;

            if (prepreka2.Left <= 0 && !prepreka2_desno)
            {
                prepreka2_desno = true;
                prepreka2.Left += (int)brzinaPrepreke;
            }

            if (prepreka2.Right >= sirina && prepreka2_desno)
            {
                prepreka2_desno = false;
                prepreka2.Left -= (int)brzinaPrepreke;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PomakniPozadinu();
            PomakniZid();
            PomakniPrepreke();
            if (lijevo && !desno &&
                brod.Left - (int)brzinaBroda >= 0.1 * sirina)
                brod.Left -= (int)brzinaBroda;
            if (desno && !lijevo &&
                brod.Right + (int)brzinaBroda <= 0.9 * sirina)
                brod.Left += (int)brzinaBroda;
            progressBarVrijeme.Value -= 1;
            if (kretanje)
            {
                prepreka1.Top += (int)brzinaZida;
                prepreka2.Top += (int)brzinaZida;
                if (prepreka1.Top > visina)
                {
                    povecajPrepreke();
                    prepreka1.Top = -prepreka1.Height;
                    if (progressBar1.Value > 0) povecajBodove(1); //ako prepreka nije uništena
                    progressBarVrijeme.Value = Math.Min
                        (progressBarVrijeme.Value + 60, 1000);
                    progressBar1.Value = progressBar1.Maximum;
                    prepreka1.Visible = true; //ako smo uništili prepreku, da nova bude vidljiva
                }

                if (prepreka2.Top > visina)
                {
                    povecajPrepreke();
                    prepreka2.Top = -prepreka2.Height;
                    if (progressBar2.Value > 0) povecajBodove(1);
                    progressBarVrijeme.Value = Math.Min
                        (progressBarVrijeme.Value + 60, 1000);
                    progressBar2.Value = progressBar2.Maximum;
                    prepreka2.Visible = true; //ako smo uništili prepreku, da nova bude vidljiva
                }

            }
            if (random.Next() % zasicenost == 0) //veci vise kometa ili manji manje kometa 
                StvoriKomet();
            if (random.Next() % 1000 == 0) //ne prečesto stvarati
                StvoriZivot();
            if (random.Next() % 200 == 0)
                StvoriSatelit();
            if (random.Next() % 500 == 0)
                StvoriBudilicu();


            foreach (Control kontrola in Controls)
            {
                if (kontrola is PictureBox x)
                {
                    if ((string)x.Tag == "komet")
                    {
                        x.Top += (int)(kretanje ?
                        brzinaZida + brzinaBroda : brzinaZida);
                        if (x.Top > visina)
                        {
                            Controls.Remove(kontrola);
                            x.Dispose(); //unistavanje
                        }
                    }

                    if ((string)x.Tag == "zivot")
                    {
                        x.Top += (int)(kretanje ?
                            brzinaZida + brzinaBroda : brzinaZida);
                        if (x.Top > visina)
                        {
                            Controls.Remove(kontrola);
                            x.Dispose(); //unistavanje
                        }

                    }

                    if ((string)x.Tag == "satelit")
                    {
                        x.Top += (int)(kretanje ?
                            brzinaZida + brzinaBroda : brzinaZida);
                        if (x.Top > visina)
                        {
                            Controls.Remove(kontrola);
                            x.Dispose(); //unistavanje
                        }
                    }

                    if ((string)x.Tag == "budilica")
                    {
                        x.Top += (int)(kretanje ?
                            brzinaZida + brzinaBroda : brzinaZida);
                        if (x.Top > visina)
                        {
                            Controls.Remove(kontrola);
                            x.Dispose(); //unistavanje
                        }
                    }

                    if ((string)x.Tag == "raketa")
                    {
                        x.Top -= (int)(brzinaBroda + brzinaZida + 1);
                        if (x.Top < -x.Height)
                        {
                            Controls.Remove(kontrola);
                            x.Dispose(); //unistavanje
                        }
                    }
                }
            }
            //sudar rakete i kometa
            foreach (Control kontrola in Controls)
            {
                if (kontrola is PictureBox x
                    && (string)x.Tag == "raketa")
                {
                    foreach (Control kontrola2 in Controls)
                    {
                        if (kontrola2 is PictureBox y
                            && (string)y.Tag == "komet"
                            && x.Bounds.IntersectsWith(y.Bounds) )
                        {
                            povecajBodove(1);
                            Controls.Remove(kontrola);
                            Controls.Remove(kontrola2);
                            x.Dispose();
                            y.Dispose();
                        }
                    }
                }
            }

            Invalidate();
            //isteklo vrijeme
            if (progressBarVrijeme.Value == 0)
            {
                smanjiZivote(zivoti);
                GameOver();
            }
            //sudari s preprekama
            if (brod.Bounds.IntersectsWith(prepreka1.Bounds) && prepreka1.Visible)
            {
                if (zivoti == 1)
                {
                    smanjiZivote(1);
                    GameOver();
                }

                else
                {
                    zvukUdar.Play();
                    prepreka1.Visible = false;
                    smanjiZivote(1);
                }    
                return;
            }

            if (!brod.Bounds.IntersectsWith(prepreka1.Bounds) && !prepreka1.Visible 
                && progressBar1.Value > 0)
            {
                prepreka1.Visible = true;
            }

            if (brod.Bounds.IntersectsWith(prepreka2.Bounds) && prepreka2.Visible)
            {
                if (zivoti == 1)
                {
                    smanjiZivote(1);
                    GameOver();
                }
                    
                else
                {

                    zvukUdar.Play();
                    prepreka2.Visible = false;
                    smanjiZivote(1);
                }
                return;
            }

            if (!brod.Bounds.IntersectsWith(prepreka2.Bounds) && !prepreka2.Visible
                &&progressBar2.Value > 0)
            {
                prepreka2.Visible = true;
            }

            foreach (Control kontrola in Controls)
            {
                if (kontrola is PictureBox x
                    && brod.Bounds.IntersectsWith(x.Bounds))
                {
                    if ((string)x.Tag == "komet")
                    {
                        zvukUdar.Play();
                        
                        if (zivoti == 1)
                        {
                            smanjiZivote(1);
                            GameOver();
                        }
                            
                        else 
                        {
                            smanjiZivote(1);
                            Controls.Remove(kontrola);
                            x.Dispose();
                        }
                    }

                    if ((string)x.Tag == "zivot")
                    {
                        zvukZivot.Play();
                        if (zivoti < 3)
                        {
                            smanjiZivote(-1);
                        }
                        Controls.Remove(kontrola);
                        x.Dispose();
                    }

                    if ((string)x.Tag == "satelit")
                    {
                        povecajBodove(2);
                        Controls.Remove(kontrola);
                        x.Dispose();
                    }

                    if ((string)x.Tag == "budilica")
                    {
                        zvukZivot.Play();
                        progressBarVrijeme.Value = Math.Min
                        (progressBarVrijeme.Value + 200, 1000);
                        Controls.Remove(kontrola);
                        x.Dispose();
                    }
                }
                //kolizija rakete i prepreke
                if (kontrola is PictureBox y
                    && (string)y.Tag == "raketa")
                {
                    if (prepreka1.Bounds.IntersectsWith(y.Bounds) && prepreka1.Visible)
                    {
                        Controls.Remove(kontrola);
                        y.Dispose();
                        //max je na 60 tako da je djeljivo s 2, 3, 4, 5, 6
                        progressBar1.Value -= progressBar1.Maximum / 5; // 5 raketa potrebno za uništenje, lako promijenimo 
                        if (progressBar1.Value == 0)
                        {
                            zvukUdar.Play();
                            povecajBodove(2);
                            prepreka1.Visible = false;
                        }
                    }

                    if (prepreka2.Bounds.IntersectsWith(y.Bounds) && prepreka2.Visible)
                    {
                        Controls.Remove(kontrola);
                        y.Dispose();
                        progressBar2.Value -= progressBar2.Maximum / 5; // 5 raketa potrebno za uništenje, lako promijenimo 
                        if (progressBar2.Value == 0)
                        {
                            zvukUdar.Play();
                            povecajBodove(2);
                            prepreka2.Visible = false;
                        }
                    }
                }

            }

        }

        private void GameOver()
        {
            zvukKraj.Play();
            timer1.Stop();
            krajIgre = true;
            labelaRestartPoruka.Visible = true;
            MessageBox.Show("Osvojeni bodovi: " + bodovi, 
                "Igra je završila!");
            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                if (Controls[i] is PictureBox x
                    && ((string)x.Tag == "komet"
                    || (string)x.Tag == "zivot"
                    || (string)x.Tag == "satelit"
                    || (string)x.Tag == "budilica"
                    || (string)x.Tag == "raketa"))
                {
                    x.Visible = false;
                    Controls.Remove(Controls[i]);
                    x.Dispose();
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 2; ++i)
            {
                e.Graphics.DrawImage(pozadina, 0, koordPozadina[i], sirina, visina + 5);
            }

            for (int i = 0; i < 2; ++i)
            {
                e.Graphics.DrawImage(zid, 0, koordZid[i], 0.1f * sirina, visina);
                e.Graphics.DrawImage(zid, 0.9f * sirina, koordZid[i], 0.1f * sirina, visina);
            }
        }
    }
}
