namespace Raketa2
{
    partial class FormPostavke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPostavke));
            this.gumbNatrag = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listaZasicenost = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listaBrzina = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gumbPromijeniIzgled = new System.Windows.Forms.Button();
            this.izgled = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.izgled)).BeginInit();
            this.SuspendLayout();
            // 
            // gumbNatrag
            // 
            this.gumbNatrag.BackColor = System.Drawing.Color.DarkGreen;
            this.gumbNatrag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gumbNatrag.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbNatrag.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gumbNatrag.Location = new System.Drawing.Point(333, 466);
            this.gumbNatrag.Name = "gumbNatrag";
            this.gumbNatrag.Size = new System.Drawing.Size(146, 61);
            this.gumbNatrag.TabIndex = 0;
            this.gumbNatrag.Text = "Natrag";
            this.gumbNatrag.UseVisualStyleBackColor = false;
            this.gumbNatrag.Click += new System.EventHandler(this.gumbNatrag_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listaZasicenost
            // 
            this.listaZasicenost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.listaZasicenost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listaZasicenost.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listaZasicenost.FormattingEnabled = true;
            this.listaZasicenost.ItemHeight = 38;
            this.listaZasicenost.Items.AddRange(new object[] {
            "slaba",
            "srednja",
            "jaka"});
            this.listaZasicenost.Location = new System.Drawing.Point(82, 79);
            this.listaZasicenost.Name = "listaZasicenost";
            this.listaZasicenost.Size = new System.Drawing.Size(169, 118);
            this.listaZasicenost.TabIndex = 1;
            this.listaZasicenost.SelectedIndexChanged += new System.EventHandler(this.listaZasicenost_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(26, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 41);
            this.label3.TabIndex = 5;
            this.label3.Text = "Zasićenost kometima";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(39, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 43);
            this.label2.TabIndex = 6;
            this.label2.Text = "Brzina prepreke";
            // 
            // listaBrzina
            // 
            this.listaBrzina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.listaBrzina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listaBrzina.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listaBrzina.ForeColor = System.Drawing.Color.Black;
            this.listaBrzina.FormattingEnabled = true;
            this.listaBrzina.ItemHeight = 38;
            this.listaBrzina.Items.AddRange(new object[] {
            "sporo",
            "umjereno",
            "brzo"});
            this.listaBrzina.Location = new System.Drawing.Point(82, 409);
            this.listaBrzina.Name = "listaBrzina";
            this.listaBrzina.Size = new System.Drawing.Size(156, 118);
            this.listaBrzina.TabIndex = 7;
            this.listaBrzina.SelectedIndexChanged += new System.EventHandler(this.listaBrzina_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(304, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 43);
            this.label1.TabIndex = 8;
            this.label1.Text = "Izgled broda";
            // 
            // gumbPromijeniIzgled
            // 
            this.gumbPromijeniIzgled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gumbPromijeniIzgled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gumbPromijeniIzgled.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbPromijeniIzgled.ForeColor = System.Drawing.Color.Black;
            this.gumbPromijeniIzgled.Location = new System.Drawing.Point(333, 346);
            this.gumbPromijeniIzgled.Name = "gumbPromijeniIzgled";
            this.gumbPromijeniIzgled.Size = new System.Drawing.Size(146, 61);
            this.gumbPromijeniIzgled.TabIndex = 10;
            this.gumbPromijeniIzgled.Text = "Promijeni";
            this.gumbPromijeniIzgled.UseVisualStyleBackColor = false;
            this.gumbPromijeniIzgled.Click += new System.EventHandler(this.gumbPromijeniIzgled_Click);
            // 
            // izgled
            // 
            this.izgled.BackColor = System.Drawing.Color.Transparent;
            this.izgled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.izgled.Image = global::Raketa2.Properties.Resources.brod;
            this.izgled.Location = new System.Drawing.Point(372, 222);
            this.izgled.Name = "izgled";
            this.izgled.Size = new System.Drawing.Size(61, 97);
            this.izgled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.izgled.TabIndex = 11;
            this.izgled.TabStop = false;
            // 
            // FormPostavke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 553);
            this.Controls.Add(this.izgled);
            this.Controls.Add(this.gumbPromijeniIzgled);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaBrzina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listaZasicenost);
            this.Controls.Add(this.gumbNatrag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPostavke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Postavke igre";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormPostavke_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.izgled)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gumbNatrag;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listaZasicenost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listaBrzina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gumbPromijeniIzgled;
        public System.Windows.Forms.PictureBox izgled;
    }
}