using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.IO;

namespace Logger
{
    public partial class Data1 : Form
    {
        public Data1()
        {
            InitializeComponent();
            start();
        }

        private void giderboya()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[3].Value.ToString() == "Borç")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.RosyBrown;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
                else if (dataGridView1.Rows[i].Cells[3].Value.ToString() == "Ödeme")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.MediumPurple;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }

        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\odemeDB.accdb");
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet data = new DataSet();
        OleDbCommand comm = new OleDbCommand();
        int numara = 0, anaParaDuzelt = 0;

        private void start()
        {
            comboBox1.Items.Clear();
            comm = new OleDbCommand("select Cariler From Cariler", baglan);
            baglan.Open();
            OleDbDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["Cariler"]);
            }
            dr.Close();
            baglan.Close();
        }

        private void tabloDoldur()
        {
            data.Clear();
            int para = 0;
            baglan.Open();
            adtr = new OleDbDataAdapter("select * from [" + comboBox1.SelectedItem.ToString() + "] order by Tarih DESC", baglan);
            adtr.Fill(data, comboBox1.SelectedItem.ToString());
            dataGridView1.DataSource = data.Tables[comboBox1.SelectedItem.ToString()];
            adtr.Dispose();
            comm = new OleDbCommand("select Giriş From [" + comboBox1.SelectedItem.ToString() + "] where [Gelir / Gider] = 'Borç' or [Gelir / Gider] = 'Ödeme'", baglan);
            OleDbDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                para += Convert.ToInt32(dr["Giriş"]) * -1;
            }
            labelPara.Text = para.ToString();
            para = 0;
            comm = new OleDbCommand("select Giriş From [" + comboBox1.SelectedItem.ToString() + "] where [Gelir / Gider] = 'Gelir' or  [Gelir / Gider] = 'Borç'", baglan);
            dr = comm.ExecuteReader();
            while (dr.Read())
            {
                para += Convert.ToInt32(dr["Giriş"]);
            }
            labelGelir.Text = para.ToString();
            para = 0;
            comm = new OleDbCommand("select Giriş From [" + comboBox1.SelectedItem.ToString() + "] where [Gelir / Gider] = 'Gider' or  [Gelir / Gider] = 'Ödeme'", baglan);
            dr = comm.ExecuteReader();
            while (dr.Read())
            {
                para += Convert.ToInt32(dr["Giriş"]);
            }
            labelGider.Text = (para * -1).ToString();
            dr.Close();
            baglan.Close();
            labelFark.Text = (int.Parse(labelGelir.Text) - int.Parse(labelGider.Text)).ToString();
            giderboya();
        }

        private void Data1_Load(object sender, EventArgs e)
        {
            
        }
        private void tabPageElektrik_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewElektrik_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabloDoldur();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Silme İşlemi Geri Alınamayacaktır. Silmek İstediğinizden Emin Misiinz?", "UYARI!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                case DialogResult.Yes:
                    comm = new OleDbCommand("drop table [" + comboBox1.SelectedItem.ToString() + "]", baglan);
                    baglan.Open();
                    comm.ExecuteNonQuery();
                    comm = new OleDbCommand("delete from Cariler where Cariler='" + comboBox1.SelectedItem.ToString() + "'", baglan);
                    comm.ExecuteNonQuery();
                    baglan.Close();
                    start();
                    data.Clear();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            giderboya();
        }

        private void labelPara_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                if (index > -1)
                {
                    dataGridView1.Rows[index].Selected = true;
                    numara = Convert.ToInt32(dataGridView1.Rows[index].Cells["ID"].Value);
                    anaParaDuzelt = Convert.ToInt32(dataGridView1.Rows[index].Cells["Giriş"].Value);
                }
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (numara != 0)
            {
                switch (MessageBox.Show("Silme İşlemi Geri Alınamayacaktır. Silmek İstediğinizden Emin MisiniZ?", "UYARI!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    case DialogResult.Yes:
                        comm = new OleDbCommand("delete from [" + comboBox1.SelectedItem.ToString() + "] where ID = " + numara.ToString() + "", baglan);
                        baglan.Open();
                        comm.ExecuteNonQuery();
                        baglan.Close();
                        tabloDoldur();
                        Form1.anaParaGiris.Text = (Convert.ToInt32(Form1.anaParaGiris.Text) + anaParaDuzelt * -1).ToString();
                        File.WriteAllText(Environment.CurrentDirectory + @"\Para.txt", Form1.anaParaGiris.Text);
                        numara = 0;
                        break;
                    case DialogResult.No:
                        break;

                }
            }
                
        }
    }
}
