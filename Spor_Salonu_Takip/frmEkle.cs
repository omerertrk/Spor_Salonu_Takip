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
    public partial class frmEkle : Form
    {
        public Form1 frm1;
        public frmEkle()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ace.OleDb.12.0;Data source=data.accdb");
        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (txt_Ad.Text.TrimEnd() == "" || txt_Soyad.Text.TrimEnd() == "" || txt_Tel.Text.TrimEnd() == "" || txt_Adres.Text.TrimEnd() == "" || txt_Kilo.Text.TrimEnd() == "" || txt_Boy.Text.TrimEnd() == "" || txt_Göbek.Text.TrimEnd() == "" || txt_Kol.Text.TrimEnd() == "" || txt_Bacak.Text.TrimEnd() == "") MessageBox.Show("Lütfen Boş Yerleri Doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else if (cmb_Cinsiyet.Text == "Seçiniz")
            {
                MessageBox.Show("Lütfen Cinsiyetinizi Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmb_Cinsiyet.Focus();
            }
            else
            {

                OleDbCommand komut = new OleDbCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "INSERT INTO Kisiler(Kisi_ad,Kisi_soyad,Kisi_telno,Kisi_cinsiyet,Kisi_adres,Kilo,Boy,Göbek,Kol,Bacak) values('" + txt_Ad.Text + "','" + txt_Soyad.Text + "','" + txt_Tel.Text + "','" + cmb_Cinsiyet.Text + "','" + txt_Adres.Text + "','" + txt_Kilo.Text + "','" + txt_Boy.Text + "','" + txt_Göbek.Text + "','" + txt_Kol.Text + "','" + txt_Bacak.Text + "')";
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Yeni Kişi Eklendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm1.yenile();
                txt_Ad.Clear();
                txt_Soyad.Clear();
                txt_Tel.Clear();
                txt_Adres.Clear();
                txt_Kilo.Clear();
                txt_Boy.Clear();
                txt_Göbek.Clear();
                txt_Kol.Clear();
                txt_Bacak.Clear();

                cmb_Cinsiyet.Text = "Seçiniz";
            }




        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
