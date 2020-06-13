using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Logger
{
    public partial class Cari : Form
    {
        public Cari()
        {
            InitializeComponent();
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\odemeDB.accdb");

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand comm = new OleDbCommand("create table [" + textBoxCari.Text + "] (ID int identity(1,1) primary key, Tarih datetime, Alıcı nvarchar, [Gelir / Gider] nvarchar, Giriş int, Açıklama nvarchar, KalanPara int)", baglan);
                baglan.Open();
                comm.ExecuteNonQuery();
                comm = new OleDbCommand("insert into Cariler (Cariler) values ('" + textBoxCari.Text + "')", baglan);
                comm.ExecuteNonQuery();
                baglan.Close();
            }
            catch
            {
                MessageBox.Show("Bu Cari Zaten Mevcut!");
            }
         }
    }
}
