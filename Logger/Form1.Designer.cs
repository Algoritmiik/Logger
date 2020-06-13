namespace Logger
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTarih = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxGiris = new System.Windows.Forms.TextBox();
            this.textBoxAciklama = new System.Windows.Forms.TextBox();
            this.buttonKayit = new System.Windows.Forms.Button();
            this.buttonDokum = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxAlici = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxAnaPara = new System.Windows.Forms.TextBox();
            this.buttonDegistir = new System.Windows.Forms.Button();
            this.buttonCari = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxGelir = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "TARİH";
            // 
            // textBoxTarih
            // 
            this.textBoxTarih.Location = new System.Drawing.Point(145, 37);
            this.textBoxTarih.Name = "textBoxTarih";
            this.textBoxTarih.Size = new System.Drawing.Size(100, 21);
            this.textBoxTarih.TabIndex = 1;
            this.textBoxTarih.TextChanged += new System.EventHandler(this.textBoxTarih_TextChanged);
            this.textBoxTarih.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTarih_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "GİRİŞ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "AÇIKLAMA";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxGiris
            // 
            this.textBoxGiris.Location = new System.Drawing.Point(145, 121);
            this.textBoxGiris.Name = "textBoxGiris";
            this.textBoxGiris.Size = new System.Drawing.Size(100, 21);
            this.textBoxGiris.TabIndex = 4;
            this.textBoxGiris.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGiris_KeyPress);
            // 
            // textBoxAciklama
            // 
            this.textBoxAciklama.Location = new System.Drawing.Point(145, 148);
            this.textBoxAciklama.Name = "textBoxAciklama";
            this.textBoxAciklama.Size = new System.Drawing.Size(100, 21);
            this.textBoxAciklama.TabIndex = 5;
            this.textBoxAciklama.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // buttonKayit
            // 
            this.buttonKayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonKayit.Location = new System.Drawing.Point(155, 175);
            this.buttonKayit.Name = "buttonKayit";
            this.buttonKayit.Size = new System.Drawing.Size(75, 23);
            this.buttonKayit.TabIndex = 6;
            this.buttonKayit.Text = "KAYIT";
            this.buttonKayit.UseVisualStyleBackColor = true;
            this.buttonKayit.Click += new System.EventHandler(this.buttonKayit_Click);
            // 
            // buttonDokum
            // 
            this.buttonDokum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDokum.Location = new System.Drawing.Point(266, 201);
            this.buttonDokum.Name = "buttonDokum";
            this.buttonDokum.Size = new System.Drawing.Size(75, 23);
            this.buttonDokum.TabIndex = 7;
            this.buttonDokum.TabStop = false;
            this.buttonDokum.Text = "DÖKÜM";
            this.buttonDokum.UseVisualStyleBackColor = true;
            this.buttonDokum.Click += new System.EventHandler(this.buttonDokum_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "ALICI";
            this.label7.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboBoxAlici
            // 
            this.comboBoxAlici.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxAlici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlici.FormattingEnabled = true;
            this.comboBoxAlici.Items.AddRange(new object[] {
            "Diğer",
            "Elektrik",
            "Su",
            "Tedarikçi",
            "Yönetim"});
            this.comboBoxAlici.Location = new System.Drawing.Point(145, 65);
            this.comboBoxAlici.Name = "comboBoxAlici";
            this.comboBoxAlici.Size = new System.Drawing.Size(100, 23);
            this.comboBoxAlici.Sorted = true;
            this.comboBoxAlici.TabIndex = 2;
            this.comboBoxAlici.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlici_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "ANA PARA";
            // 
            // textBoxAnaPara
            // 
            this.textBoxAnaPara.AcceptsTab = true;
            this.textBoxAnaPara.BackColor = System.Drawing.Color.White;
            this.textBoxAnaPara.Location = new System.Drawing.Point(145, 9);
            this.textBoxAnaPara.Name = "textBoxAnaPara";
            this.textBoxAnaPara.Size = new System.Drawing.Size(100, 21);
            this.textBoxAnaPara.TabIndex = 1;
            this.textBoxAnaPara.Text = "0";
            this.textBoxAnaPara.TextChanged += new System.EventHandler(this.textBoxTarih_TextChanged);
            this.textBoxAnaPara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTarih_KeyPress);
            // 
            // buttonDegistir
            // 
            this.buttonDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 2.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, ((byte)(162)));
            this.buttonDegistir.Location = new System.Drawing.Point(252, 9);
            this.buttonDegistir.Name = "buttonDegistir";
            this.buttonDegistir.Size = new System.Drawing.Size(75, 23);
            this.buttonDegistir.TabIndex = 5;
            this.buttonDegistir.TabStop = false;
            this.buttonDegistir.Text = "DEĞİŞTİR";
            this.buttonDegistir.UseVisualStyleBackColor = true;
            this.buttonDegistir.Click += new System.EventHandler(this.buttonDegistir_Click_1);
            // 
            // buttonCari
            // 
            this.buttonCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCari.Location = new System.Drawing.Point(16, 201);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(75, 23);
            this.buttonCari.TabIndex = 6;
            this.buttonCari.TabStop = false;
            this.buttonCari.Text = "CARİ EKLE";
            this.buttonCari.UseVisualStyleBackColor = true;
            this.buttonCari.Click += new System.EventHandler(this.buttonCari_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yenileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(126, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // yenileToolStripMenuItem
            // 
            this.yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            this.yenileToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.yenileToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.yenileToolStripMenuItem.Text = "Yenile";
            this.yenileToolStripMenuItem.Click += new System.EventHandler(this.yenileToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "GELİR / GİDER";
            this.label2.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboBoxGelir
            // 
            this.comboBoxGelir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGelir.FormattingEnabled = true;
            this.comboBoxGelir.Items.AddRange(new object[] {
            "Gelir",
            "Gider",
            "Borç",
            "Ödeme"});
            this.comboBoxGelir.Location = new System.Drawing.Point(145, 95);
            this.comboBoxGelir.Name = "comboBoxGelir";
            this.comboBoxGelir.Size = new System.Drawing.Size(100, 23);
            this.comboBoxGelir.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kayıt Edildi !";
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(353, 243);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxGelir);
            this.Controls.Add(this.buttonCari);
            this.Controls.Add(this.buttonDegistir);
            this.Controls.Add(this.comboBoxAlici);
            this.Controls.Add(this.buttonDokum);
            this.Controls.Add(this.buttonKayit);
            this.Controls.Add(this.textBoxAciklama);
            this.Controls.Add(this.textBoxGiris);
            this.Controls.Add(this.textBoxAnaPara);
            this.Controls.Add(this.textBoxTarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Logger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxTarih;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBoxGiris;
        public System.Windows.Forms.TextBox textBoxAciklama;
        public System.Windows.Forms.Button buttonKayit;
        public System.Windows.Forms.Button buttonDokum;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox comboBoxAlici;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox textBoxAnaPara;
        public System.Windows.Forms.Button buttonDegistir;
        private System.Windows.Forms.Button buttonCari;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox comboBoxGelir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}

