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

namespace Spor_Salonu_Takip
{
    public partial class Form1 : Form
    {
        public frmBilgiGüncelle frmbilgiGuncelle;
        public frmEkle frmEkle;
        public frmBilgi frmBilgi;
        public frmGuncelle frmGuncelle;
        public Form1()
        {
            InitializeComponent();
            frmEkle = new frmEkle();
            frmbilgiGuncelle = new frmBilgiGüncelle();
            frmGuncelle=new frmGuncelle();
            frmBilgi = new frmBilgi();
            frmGuncelle.frm1 = this;
            frmbilgiGuncelle.frm1 = this;
            frmEkle.frm1 = this;
            frmBilgi.frm1 = this;
    
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ace.OleDb.12.0;Data source=data.accdb");
        public void yenile()
        {
            DataTable tablo = new DataTable();
            OleDbDataAdapter adaptör = new OleDbDataAdapter("select Kisi_no,Kisi_ad,Kisi_soyad,Kisi_telno,Kisi_cinsiyet,Kisi_adres from Kisiler", baglanti);
            adaptör.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            yenile();
            dataGridView1.Columns[0].HeaderText = "No";
            dataGridView1.Columns[1].HeaderText="Adı";
            dataGridView1.Columns[2].HeaderText="Soyadı";
            dataGridView1.Columns[3].HeaderText="Tel No";
            dataGridView1.Columns[4].HeaderText="Cinsiyet";
            dataGridView1.Columns[5].HeaderText="Adres";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            frmEkle.ShowDialog();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            DialogResult silsinmi = MessageBox.Show("Seçilen Kişi Silinsinmi ?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (silsinmi == DialogResult.Yes)
            {
                OleDbCommand kmtSil = new OleDbCommand();
                baglanti.Open();
                kmtSil.Connection = baglanti;
                kmtSil.CommandText = "DELETE FROM Kisiler where Kisi_no=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
                kmtSil.ExecuteNonQuery();
                baglanti.Close();
                yenile();
            }
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            frmGuncelle.txt_Ad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmGuncelle.txt_Soyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmGuncelle.txt_Tel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frmGuncelle.cmb_Cinsiyet.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frmGuncelle.txt_Adres.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frmGuncelle.ShowDialog();
        }

        private void btn_Ara_Click(object sender, EventArgs e)
        {
            frmAra frmAra = new frmAra();
            frmAra.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBilgi.ShowDialog();
        }


    }
}
