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
    public partial class frmGuncelle : Form
    {
        public Form1 frm1;
        public frmGuncelle()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ace.OleDb.12.0;Data source=data.accdb");

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            
            
            if (txt_Ad.Text.TrimEnd() == "" || txt_Soyad.Text.TrimEnd() == "" || txt_Tel.Text.TrimEnd() == "" || txt_Adres.Text.TrimEnd() == "") MessageBox.Show("Lütfen Boş Yerleri Doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            
            else
            {
                DialogResult guncellesinmi = MessageBox.Show("Kayıt Güncellensinmi ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (guncellesinmi == DialogResult.Yes)
                {
                    OleDbCommand kmtGuncel = new OleDbCommand();
                    baglanti.Open();
                    kmtGuncel.Connection = baglanti;
                    kmtGuncel.CommandText = "update Kisiler set Kisi_ad=@kisiad,Kisi_soyad=@kisisoyad, Kisi_telno=@kisitelno,Kisi_cinsiyet=@kisicinsiyet,Kisi_adres=@kisiadres where Kisi_no=@anahtar";
                    kmtGuncel.Parameters.AddWithValue("@kisiad", txt_Ad.Text);
                    kmtGuncel.Parameters.AddWithValue("@kisisoyad", txt_Soyad.Text);
                    kmtGuncel.Parameters.AddWithValue("@kisitelno", txt_Tel.Text);
                    kmtGuncel.Parameters.AddWithValue("@kisicinsiyet", cmb_Cinsiyet.Text);
                    kmtGuncel.Parameters.AddWithValue("@kisiadres", txt_Adres.Text);
                    kmtGuncel.Parameters.AddWithValue("@anahtar", frm1.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    kmtGuncel.ExecuteNonQuery();
                    baglanti.Close();
                    frm1.yenile();
                }
            }
            
        }
    
    }
}
