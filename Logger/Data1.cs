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

namespace Logger
{
    public partial class Data1 : Form
    {
        public Data1()
        {
            InitializeComponent();
            start();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\odemeDB.accdb");
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet data = new DataSet();
        OleDbCommand comm = new OleDbCommand();

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
            int para = 0;
            data.Clear();
            baglan.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from " + comboBox1.SelectedItem.ToString(), baglan);
            adtr.Fill(data, comboBox1.SelectedItem.ToString());
            dataGridView1.DataSource = data.Tables[comboBox1.SelectedItem.ToString()];
            adtr.Dispose();
            comm = new OleDbCommand("select Kalanpara From " + comboBox1.SelectedItem.ToString(), baglan);
            OleDbDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                para += Convert.ToInt32(dr["KalanPara"]);
            }
            dr.Close();
            baglan.Close();
            labelPara.Text = para.ToString();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            comm = new OleDbCommand("drop table " + comboBox1.SelectedItem.ToString(), baglan);
            baglan.Open();
            comm.ExecuteNonQuery();
            comm = new OleDbCommand("delete from Cariler where Cariler='" + comboBox1.SelectedItem.ToString() + "'", baglan);
            comm.ExecuteNonQuery();
            baglan.Close();
            start();
        }
    }
}
