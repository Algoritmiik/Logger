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

namespace Logger
{
    public partial class Form1 : Form
    {
        Data1 dataForm = new Data1();        
        int sayacDegistir = 0; //Ana parayı değiştirme sayacı
        int sayacElektrik = 0, sayacSu = 0, sayacTedarikci = 0, sayacYonetim = 0, sayacDiger = 0; //Tablo Satır Sayaçları


        public Form1()
        {
            InitializeComponent();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxAnaPara.Enabled = false;
        }

        private void comboBoxAlici_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAlici.SelectedItem == comboBoxAlici.Items[0] || comboBoxAlici.SelectedItem == comboBoxAlici.Items[1])
            {
                textBoxFirmaGirisi.Text = comboBoxAlici.Text + " İşleri";
                textBoxFirmaGirisi.Enabled = false;
            }
            else
            {
                textBoxFirmaGirisi.Clear();
                textBoxFirmaGirisi.Enabled = true;
            }
        }

        private void textBoxUrunGirisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBoxAlici.SelectedItem == comboBoxAlici.Items[0] || comboBoxAlici.SelectedItem == comboBoxAlici.Items[1])
            {              
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
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
            if (textBoxTarih.Text == "" || textBoxFirmaGirisi.Text == "" ||
                textBoxGiris.Text == "" || textBoxOdeme.Text == "" ||
                textBoxCikis.Text == "" || textBoxAciklama.Text == "" ||
                comboBoxAlici.SelectedIndex == -1)
            {
                MessageBox.Show("KAYIT EDİLEMEDİ ! \nAlanlar Boş Bırakılamaz");
            }
            else
            {
                if (comboBoxAlici.SelectedItem == comboBoxAlici.Items[0])
                {
                    int i = dataForm.dataGridViewElektrik.Rows.Add();
                    dataForm.dataGridViewElektrik.Rows[sayacElektrik].Cells[0].Value = textBoxTarih.Text;
                    dataForm.dataGridViewElektrik.Rows[sayacElektrik].Cells[1].Value = comboBoxAlici.Text;
                    dataForm.dataGridViewElektrik.Rows[sayacElektrik].Cells[2].Value = textBoxFirmaGirisi.Text;
                    dataForm.dataGridViewElektrik.Rows[sayacElektrik].Cells[3].Value = textBoxGiris.Text;
                    dataForm.dataGridViewElektrik.Rows[sayacElektrik].Cells[4].Value = textBoxOdeme.Text;
                    dataForm.dataGridViewElektrik.Rows[sayacElektrik].Cells[5].Value = textBoxCikis.Text;
                    dataForm.dataGridViewElektrik.Rows[sayacElektrik].Cells[6].Value = textBoxAciklama.Text;
                    dataForm.dataGridViewElektrik.Rows[sayacElektrik].Cells[7].Value = (int.Parse(textBoxAnaPara.Text)+int.Parse(textBoxGiris.Text)-int.Parse(textBoxCikis.Text)).ToString();
                    textBoxAnaPara.Text = (dataForm.dataGridViewElektrik.Rows[sayacElektrik].Cells[7].Value).ToString();
                    sayacElektrik++;
                }
                else if (comboBoxAlici.SelectedItem == comboBoxAlici.Items[1])
                {
                    int i = dataForm.dataGridViewSu.Rows.Add();
                    dataForm.dataGridViewSu.Rows[sayacSu].Cells[0].Value = textBoxTarih.Text;
                    dataForm.dataGridViewSu.Rows[sayacSu].Cells[1].Value = comboBoxAlici.Text;
                    dataForm.dataGridViewSu.Rows[sayacSu].Cells[2].Value = textBoxFirmaGirisi.Text;
                    dataForm.dataGridViewSu.Rows[sayacSu].Cells[3].Value = textBoxGiris.Text;
                    dataForm.dataGridViewSu.Rows[sayacSu].Cells[4].Value = textBoxOdeme.Text;
                    dataForm.dataGridViewSu.Rows[sayacSu].Cells[5].Value = textBoxCikis.Text;
                    dataForm.dataGridViewSu.Rows[sayacSu].Cells[6].Value = textBoxAciklama.Text;
                    dataForm.dataGridViewSu.Rows[sayacSu].Cells[7].Value = (int.Parse(textBoxAnaPara.Text) + int.Parse(textBoxGiris.Text) - int.Parse(textBoxCikis.Text)).ToString();
                    textBoxAnaPara.Text = (dataForm.dataGridViewSu.Rows[sayacSu].Cells[7].Value).ToString();
                    sayacSu++;
                }
                else if (comboBoxAlici.SelectedItem == comboBoxAlici.Items[2])
                {
                    int i = dataForm.dataGridViewTedarikci.Rows.Add();
                    dataForm.dataGridViewTedarikci.Rows[sayacTedarikci].Cells[0].Value = textBoxTarih.Text;
                    dataForm.dataGridViewTedarikci.Rows[sayacTedarikci].Cells[1].Value = comboBoxAlici.Text;
                    dataForm.dataGridViewTedarikci.Rows[sayacTedarikci].Cells[2].Value = textBoxFirmaGirisi.Text;
                    dataForm.dataGridViewTedarikci.Rows[sayacTedarikci].Cells[3].Value = textBoxGiris.Text;
                    dataForm.dataGridViewTedarikci.Rows[sayacTedarikci].Cells[4].Value = textBoxOdeme.Text;
                    dataForm.dataGridViewTedarikci.Rows[sayacTedarikci].Cells[5].Value = textBoxCikis.Text;
                    dataForm.dataGridViewTedarikci.Rows[sayacTedarikci].Cells[6].Value = textBoxAciklama.Text;
                    dataForm.dataGridViewTedarikci.Rows[sayacTedarikci].Cells[7].Value = (int.Parse(textBoxAnaPara.Text) + int.Parse(textBoxGiris.Text) - int.Parse(textBoxCikis.Text)).ToString();
                    textBoxAnaPara.Text = (dataForm.dataGridViewTedarikci.Rows[sayacTedarikci].Cells[7].Value).ToString();
                    sayacTedarikci++;
                }
                else if (comboBoxAlici.SelectedItem == comboBoxAlici.Items[3])
                {
                    int i = dataForm.dataGridViewYonetim.Rows.Add();
                    dataForm.dataGridViewYonetim.Rows[sayacYonetim].Cells[0].Value = textBoxTarih.Text;
                    dataForm.dataGridViewYonetim.Rows[sayacYonetim].Cells[1].Value = comboBoxAlici.Text;
                    dataForm.dataGridViewYonetim.Rows[sayacYonetim].Cells[2].Value = textBoxFirmaGirisi.Text;
                    dataForm.dataGridViewYonetim.Rows[sayacYonetim].Cells[3].Value = textBoxGiris.Text;
                    dataForm.dataGridViewYonetim.Rows[sayacYonetim].Cells[4].Value = textBoxOdeme.Text;
                    dataForm.dataGridViewYonetim.Rows[sayacYonetim].Cells[5].Value = textBoxCikis.Text;
                    dataForm.dataGridViewYonetim.Rows[sayacYonetim].Cells[6].Value = textBoxAciklama.Text;
                    dataForm.dataGridViewYonetim.Rows[sayacYonetim].Cells[7].Value = (int.Parse(textBoxAnaPara.Text) + int.Parse(textBoxGiris.Text) - int.Parse(textBoxCikis.Text)).ToString();
                    textBoxAnaPara.Text = (dataForm.dataGridViewYonetim.Rows[sayacYonetim].Cells[7].Value).ToString();
                    sayacYonetim++;
                }
                else if (comboBoxAlici.SelectedItem == comboBoxAlici.Items[4])
                {
                    int i = dataForm.dataGridViewDiger.Rows.Add();
                    dataForm.dataGridViewDiger.Rows[sayacDiger].Cells[0].Value = textBoxTarih.Text;
                    dataForm.dataGridViewDiger.Rows[sayacDiger].Cells[1].Value = comboBoxAlici.Text;
                    dataForm.dataGridViewDiger.Rows[sayacDiger].Cells[2].Value = textBoxFirmaGirisi.Text;
                    dataForm.dataGridViewDiger.Rows[sayacDiger].Cells[3].Value = textBoxGiris.Text;
                    dataForm.dataGridViewDiger.Rows[sayacDiger].Cells[4].Value = textBoxOdeme.Text;
                    dataForm.dataGridViewDiger.Rows[sayacDiger].Cells[5].Value = textBoxCikis.Text;
                    dataForm.dataGridViewDiger.Rows[sayacDiger].Cells[6].Value = textBoxAciklama.Text;
                    dataForm.dataGridViewDiger.Rows[sayacDiger].Cells[7].Value = (int.Parse(textBoxAnaPara.Text) + int.Parse(textBoxGiris.Text) - int.Parse(textBoxCikis.Text)).ToString();
                    textBoxAnaPara.Text = (dataForm.dataGridViewDiger.Rows[sayacDiger].Cells[7].Value).ToString();
                    sayacDiger++;
                }
            }
        }

        private void buttonDokum_Click(object sender, EventArgs e)
        {            
            dataForm.Show();
        }
        
        private void buttonDegistir_Click_1(object sender, EventArgs e)
        {
            sayacDegistir++;
            if (sayacDegistir % 2 == 0)
            {
                textBoxAnaPara.Enabled = false;
            }
            else if (sayacDegistir % 2 != 0)
            {
                textBoxAnaPara.Enabled = true;
            }            
        }
    }
}
