using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Data.SqlClient;
using System.IO;
using System.Security.AccessControl;
using System.Data.OleDb;

namespace Logger
{
    public partial class Form1 : Form
    {
    
        int sayacDegistir = 0, sayac = 0;

        public Form1()
        {
            InitializeComponent();
            start();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\odemeDB.accdb");
        public static TextBox anaParaGiris;

        public void start ()
        {
            comboBoxAlici.Items.Clear();
            OleDbCommand comm = new OleDbCommand("select Cariler From Cariler", baglanti);
            baglanti.Open();
            OleDbDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                comboBoxAlici.Items.Add(dr["Cariler"]);
            }
            dr.Close();
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var klasor = new DirectoryInfo(Application.StartupPath);
            var guvenlik = klasor.GetAccessControl();
            var rule = new FileSystemAccessRule("Everyone", FileSystemRights.Write, InheritanceFlags.None | InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow);
            guvenlik.SetAccessRule(rule);
            klasor.SetAccessControl(guvenlik);
            textBoxAnaPara.Enabled = false;            
            string para = File.ReadAllText(Environment.CurrentDirectory + @"\Para.txt");
            textBoxAnaPara.Text = para;
            label4.Visible = false;
            anaParaGiris = textBoxAnaPara;
        }

        private void comboBoxAlici_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }        
        private void textBoxTarih_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBoxTarih_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetter(e.KeyChar);
        }

        private void textBoxOdeme_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetter(e.KeyChar);
        }

        private void labelUyari_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCikis_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetter(e.KeyChar);
        }

        private void textBoxGiris_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetter(e.KeyChar);
        }

        private void textAnaPara_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetter(e.KeyChar);
        }

        private void buttonKayit_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxTarih.Text == "" || textBoxGiris.Text == "" || comboBoxGelir.SelectedIndex == -1 ||
                textBoxAciklama.Text == "" || comboBoxAlici.SelectedIndex == -1)
                {
                    MessageBox.Show("KAYIT EDİLEMEDİ ! \nAlanlar Boş Bırakılamaz");
                }
                else
                {
                    OleDbCommand komut = new OleDbCommand();
                    if (comboBoxGelir.SelectedIndex == 0 || comboBoxGelir.SelectedIndex == 2)
                    {
                        komut = new OleDbCommand("insert into [" + comboBoxAlici.SelectedItem.ToString() + "] (Tarih, Alıcı, [Gelir / Gider], Giriş, Açıklama, KalanPara) values ('" + textBoxTarih.Text + "','" + comboBoxAlici.Text + "','" + comboBoxGelir.Text + "','" + int.Parse(textBoxGiris.Text) + "','" + textBoxAciklama.Text + "','" + (int.Parse(textBoxAnaPara.Text) + int.Parse(textBoxGiris.Text)) + "')", baglanti);
                        textBoxAnaPara.Text = (int.Parse(textBoxAnaPara.Text) + int.Parse(textBoxGiris.Text)).ToString();
                    }
                    else if (comboBoxGelir.SelectedIndex == 1 || comboBoxGelir.SelectedIndex == 3)
                    {
                        komut = new OleDbCommand("insert into [" + comboBoxAlici.SelectedItem.ToString() + "] (Tarih, Alıcı, [Gelir / Gider], Giriş, Açıklama, KalanPara) values ('" + textBoxTarih.Text + "','" + comboBoxAlici.Text + "','" + comboBoxGelir.Text + "','" + int.Parse(textBoxGiris.Text) * -1 + "','" + textBoxAciklama.Text + "','" + (int.Parse(textBoxAnaPara.Text) + (int.Parse(textBoxGiris.Text) * -1)) + "')", baglanti);
                        textBoxAnaPara.Text = (int.Parse(textBoxAnaPara.Text) + (int.Parse(textBoxGiris.Text) * -1)).ToString();
                    }
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    File.WriteAllText(Environment.CurrentDirectory + @"\Para.txt", textBoxAnaPara.Text);
                    timer1.Enabled = true;
                }
            }

            catch
            {
                MessageBox.Show("Böyle Bir Cari Bulunmamaktadır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void buttonDokum_Click(object sender, EventArgs e)
        {
            Data1 dataForm = new Data1();
            dataForm.Show();
        }
        
        private void buttonDegistir_Click_1(object sender, EventArgs e)
        {
            sayacDegistir++;
            if (sayacDegistir % 2 == 0)
            {
                textBoxAnaPara.Enabled = false;
                File.WriteAllText(Environment.CurrentDirectory + @"\Para.txt", textBoxAnaPara.Text);
            }
            else if (sayacDegistir % 2 != 0)
            {
                textBoxAnaPara.Enabled = true;
            }
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            Cari cari = new Cari();
            cari.Show();
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label4.Visible = true;
            if (sayac > 1)
            {
                label4.Visible = false;
                sayac = 0;
                timer1.Enabled = false;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}