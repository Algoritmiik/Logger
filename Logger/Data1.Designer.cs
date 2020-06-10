namespace Logger
{
    partial class Data1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonSil = new System.Windows.Forms.Button();
            this.labelMali = new System.Windows.Forms.Label();
            this.labelPara = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(628, 281);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Cari Seçiniz";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(564, 12);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(75, 23);
            this.buttonSil.TabIndex = 2;
            this.buttonSil.Text = "Cari Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // labelMali
            // 
            this.labelMali.AutoSize = true;
            this.labelMali.Location = new System.Drawing.Point(139, 17);
            this.labelMali.Name = "labelMali";
            this.labelMali.Size = new System.Drawing.Size(63, 13);
            this.labelMali.TabIndex = 3;
            this.labelMali.Text = "Mali Durum:";
            // 
            // labelPara
            // 
            this.labelPara.AutoSize = true;
            this.labelPara.Location = new System.Drawing.Point(208, 17);
            this.labelPara.Name = "labelPara";
            this.labelPara.Size = new System.Drawing.Size(35, 13);
            this.labelPara.TabIndex = 4;
            this.labelPara.Text = "label2";
            // 
            // Data1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 332);
            this.Controls.Add(this.labelPara);
            this.Controls.Add(this.labelMali);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Data1";
            this.Text = "Döküm";
            this.Load += new System.EventHandler(this.Data1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Label labelMali;
        private System.Windows.Forms.Label labelPara;
    }
}