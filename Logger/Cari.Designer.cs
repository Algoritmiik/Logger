namespace Logger
{
    partial class Cari
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
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxCari = new System.Windows.Forms.TextBox();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 28);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(80, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Cari İsmi Giriniz:";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // textBoxCari
            // 
            this.textBoxCari.Location = new System.Drawing.Point(98, 28);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.Size = new System.Drawing.Size(100, 20);
            this.textBoxCari.TabIndex = 1;
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(108, 54);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(75, 23);
            this.buttonEkle.TabIndex = 2;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // Cari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 106);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.textBoxCari);
            this.Controls.Add(this.labelName);
            this.Name = "Cari";
            this.Text = "Cari";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxCari;
        private System.Windows.Forms.Button buttonEkle;
    }
}