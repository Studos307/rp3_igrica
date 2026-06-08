namespace Raketa2
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.gumbPokreni = new System.Windows.Forms.Button();
            this.gumbZatvori = new System.Windows.Forms.Button();
            this.gumbPostavke = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gumbUpute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gumbPokreni
            // 
            this.gumbPokreni.BackColor = System.Drawing.Color.Lime;
            this.gumbPokreni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gumbPokreni.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbPokreni.ForeColor = System.Drawing.Color.Black;
            this.gumbPokreni.Location = new System.Drawing.Point(150, 100);
            this.gumbPokreni.Name = "gumbPokreni";
            this.gumbPokreni.Size = new System.Drawing.Size(250, 100);
            this.gumbPokreni.TabIndex = 0;
            this.gumbPokreni.Text = "Pokreni igru";
            this.gumbPokreni.UseVisualStyleBackColor = false;
            this.gumbPokreni.Click += new System.EventHandler(this.gumbPokreni_Click);
            // 
            // gumbZatvori
            // 
            this.gumbZatvori.BackColor = System.Drawing.Color.Red;
            this.gumbZatvori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gumbZatvori.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbZatvori.ForeColor = System.Drawing.Color.Black;
            this.gumbZatvori.Location = new System.Drawing.Point(150, 400);
            this.gumbZatvori.Name = "gumbZatvori";
            this.gumbZatvori.Size = new System.Drawing.Size(250, 100);
            this.gumbZatvori.TabIndex = 2;
            this.gumbZatvori.Text = "Zatvori";
            this.gumbZatvori.UseVisualStyleBackColor = false;
            this.gumbZatvori.Click += new System.EventHandler(this.gumbZatvori_Click);
            // 
            // gumbPostavke
            // 
            this.gumbPostavke.BackColor = System.Drawing.Color.Yellow;
            this.gumbPostavke.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gumbPostavke.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbPostavke.ForeColor = System.Drawing.Color.Black;
            this.gumbPostavke.Location = new System.Drawing.Point(150, 250);
            this.gumbPostavke.Name = "gumbPostavke";
            this.gumbPostavke.Size = new System.Drawing.Size(250, 100);
            this.gumbPostavke.TabIndex = 1;
            this.gumbPostavke.Text = "Postavke igre";
            this.gumbPostavke.UseVisualStyleBackColor = false;
            this.gumbPostavke.Click += new System.EventHandler(this.gumbPostavke_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gumbUpute
            // 
            this.gumbUpute.BackColor = System.Drawing.Color.Aquamarine;
            this.gumbUpute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gumbUpute.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbUpute.Location = new System.Drawing.Point(12, 12);
            this.gumbUpute.Name = "gumbUpute";
            this.gumbUpute.Size = new System.Drawing.Size(75, 29);
            this.gumbUpute.TabIndex = 3;
            this.gumbUpute.Text = "Upute";
            this.gumbUpute.UseVisualStyleBackColor = false;
            this.gumbUpute.Click += new System.EventHandler(this.gumbUpute_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 553);
            this.Controls.Add(this.gumbUpute);
            this.Controls.Add(this.gumbPostavke);
            this.Controls.Add(this.gumbZatvori);
            this.Controls.Add(this.gumbPokreni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Početni izbornik";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.StartForm_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gumbPokreni;
        private System.Windows.Forms.Button gumbZatvori;
        private System.Windows.Forms.Button gumbPostavke;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button gumbUpute;
    }
}