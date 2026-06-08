namespace Raketa2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelaBodovi = new System.Windows.Forms.Label();
            this.labelaBodovi1 = new System.Windows.Forms.Label();
            this.labelaRestartPoruka = new System.Windows.Forms.Label();
            this.labelaPauza = new System.Windows.Forms.Label();
            this.progressBarVrijeme = new System.Windows.Forms.ProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelaZivotiSS = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelaBodoviSS = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.labelaOznaka = new System.Windows.Forms.Label();
            this.brod = new System.Windows.Forms.PictureBox();
            this.prepreka1 = new System.Windows.Forms.PictureBox();
            this.prepreka2 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepreka1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepreka2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelaBodovi
            // 
            this.labelaBodovi.AutoSize = true;
            this.labelaBodovi.BackColor = System.Drawing.Color.Transparent;
            this.labelaBodovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelaBodovi.ForeColor = System.Drawing.Color.White;
            this.labelaBodovi.Location = new System.Drawing.Point(71, 273);
            this.labelaBodovi.Name = "labelaBodovi";
            this.labelaBodovi.Size = new System.Drawing.Size(133, 32);
            this.labelaBodovi.TabIndex = 1;
            this.labelaBodovi.Text = "Bodovi: 0";
            // 
            // labelaBodovi1
            // 
            this.labelaBodovi1.AutoSize = true;
            this.labelaBodovi1.BackColor = System.Drawing.Color.Transparent;
            this.labelaBodovi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelaBodovi1.ForeColor = System.Drawing.Color.White;
            this.labelaBodovi1.Location = new System.Drawing.Point(327, 48);
            this.labelaBodovi1.Name = "labelaBodovi1";
            this.labelaBodovi1.Size = new System.Drawing.Size(133, 32);
            this.labelaBodovi1.TabIndex = 4;
            this.labelaBodovi1.Text = "Bodovi: 0";
            // 
            // labelaRestartPoruka
            // 
            this.labelaRestartPoruka.AutoSize = true;
            this.labelaRestartPoruka.BackColor = System.Drawing.Color.Yellow;
            this.labelaRestartPoruka.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelaRestartPoruka.Location = new System.Drawing.Point(165, 201);
            this.labelaRestartPoruka.Name = "labelaRestartPoruka";
            this.labelaRestartPoruka.Size = new System.Drawing.Size(199, 72);
            this.labelaRestartPoruka.TabIndex = 5;
            this.labelaRestartPoruka.Text = "Pritisnite R za\r\nponovnu igru.";
            // 
            // labelaPauza
            // 
            this.labelaPauza.AutoSize = true;
            this.labelaPauza.BackColor = System.Drawing.Color.Red;
            this.labelaPauza.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelaPauza.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelaPauza.Location = new System.Drawing.Point(145, 153);
            this.labelaPauza.Name = "labelaPauza";
            this.labelaPauza.Size = new System.Drawing.Size(244, 36);
            this.labelaPauza.TabIndex = 6;
            this.labelaPauza.Text = "Igra je pauzirana!";
            // 
            // progressBarVrijeme
            // 
            this.progressBarVrijeme.Location = new System.Drawing.Point(12, 12);
            this.progressBarVrijeme.Maximum = 1000;
            this.progressBarVrijeme.Name = "progressBarVrijeme";
            this.progressBarVrijeme.Size = new System.Drawing.Size(192, 23);
            this.progressBarVrijeme.TabIndex = 7;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Black;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelaZivotiSS,
            this.labelaBodoviSS});
            this.statusStrip1.Location = new System.Drawing.Point(0, 508);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(532, 45);
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelaZivotiSS
            // 
            this.labelaZivotiSS.AutoSize = false;
            this.labelaZivotiSS.BackColor = System.Drawing.Color.Black;
            this.labelaZivotiSS.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelaZivotiSS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelaZivotiSS.Name = "labelaZivotiSS";
            this.labelaZivotiSS.Size = new System.Drawing.Size(150, 39);
            this.labelaZivotiSS.Text = "♥♥♥";
            this.labelaZivotiSS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelaBodoviSS
            // 
            this.labelaBodoviSS.AutoSize = false;
            this.labelaBodoviSS.BackColor = System.Drawing.Color.Black;
            this.labelaBodoviSS.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelaBodoviSS.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelaBodoviSS.Name = "labelaBodoviSS";
            this.labelaBodoviSS.Size = new System.Drawing.Size(200, 39);
            this.labelaBodoviSS.Text = "Bodovi: 0";
            this.labelaBodoviSS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(41, 276);
            this.progressBar1.Maximum = 60;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(192, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(302, 48);
            this.progressBar2.Maximum = 60;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(192, 23);
            this.progressBar2.TabIndex = 10;
            // 
            // labelaOznaka
            // 
            this.labelaOznaka.AutoSize = true;
            this.labelaOznaka.BackColor = System.Drawing.Color.Transparent;
            this.labelaOznaka.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelaOznaka.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelaOznaka.ForeColor = System.Drawing.Color.Cyan;
            this.labelaOznaka.Location = new System.Drawing.Point(495, 42);
            this.labelaOznaka.Name = "labelaOznaka";
            this.labelaOznaka.Size = new System.Drawing.Size(28, 27);
            this.labelaOznaka.TabIndex = 11;
            this.labelaOznaka.Text = "0";
            this.labelaOznaka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // brod
            // 
            this.brod.BackColor = System.Drawing.Color.Transparent;
            this.brod.Image = ((System.Drawing.Image)(resources.GetObject("brod.Image")));
            this.brod.Location = new System.Drawing.Point(239, 408);
            this.brod.Name = "brod";
            this.brod.Size = new System.Drawing.Size(61, 97);
            this.brod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.brod.TabIndex = 0;
            this.brod.TabStop = false;
            // 
            // prepreka1
            // 
            this.prepreka1.Image = global::Raketa2.Properties.Resources.prepreka5;
            this.prepreka1.Location = new System.Drawing.Point(12, 266);
            this.prepreka1.Name = "prepreka1";
            this.prepreka1.Size = new System.Drawing.Size(243, 44);
            this.prepreka1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prepreka1.TabIndex = 2;
            this.prepreka1.TabStop = false;
            // 
            // prepreka2
            // 
            this.prepreka2.Image = ((System.Drawing.Image)(resources.GetObject("prepreka2.Image")));
            this.prepreka2.Location = new System.Drawing.Point(277, 36);
            this.prepreka2.Name = "prepreka2";
            this.prepreka2.Size = new System.Drawing.Size(243, 44);
            this.prepreka2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prepreka2.TabIndex = 3;
            this.prepreka2.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 250;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(532, 553);
            this.Controls.Add(this.labelaOznaka);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.progressBarVrijeme);
            this.Controls.Add(this.labelaPauza);
            this.Controls.Add(this.labelaRestartPoruka);
            this.Controls.Add(this.labelaBodovi1);
            this.Controls.Add(this.labelaBodovi);
            this.Controls.Add(this.brod);
            this.Controls.Add(this.prepreka1);
            this.Controls.Add(this.prepreka2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raketa";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepreka1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepreka2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox brod;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelaBodovi;
        private System.Windows.Forms.PictureBox prepreka1;
        private System.Windows.Forms.PictureBox prepreka2;
        private System.Windows.Forms.Label labelaBodovi1;
        private System.Windows.Forms.Label labelaRestartPoruka;
        private System.Windows.Forms.Label labelaPauza;
        private System.Windows.Forms.ProgressBar progressBarVrijeme;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelaZivotiSS;
        private System.Windows.Forms.ToolStripStatusLabel labelaBodoviSS;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label labelaOznaka;
        private System.Windows.Forms.Timer timer2;
    }
}

