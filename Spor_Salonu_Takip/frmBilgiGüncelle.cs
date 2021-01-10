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
    public partial class frmBilgiGüncelle : Form
    {
        public Form1 frm1;
        public frmBilgiGüncelle()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=microsoft.ace.oledb.12.0;data source=data.accdb");
        private void frmBilgiGüncelle_Load(object sender, EventArgs e)
        {
            txt_Kilo.Text = frm1.frmBilgi.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_Boy.Text = frm1.frmBilgi.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_Göbek.Text = frm1.frmBilgi.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_Kol.Text = frm1.frmBilgi.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_Bacak.Text = frm1.frmBilgi.dataGridView1.CurrentRow.Cells[4].Value.ToString();
           
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (txt_Kilo.Text.TrimEnd() == "" || txt_Boy.Text.TrimEnd() == "" || txt_Göbek.Text.TrimEnd() == "" || txt_Kol.Text.TrimEnd() == "" || txt_Bacak.Text.TrimEnd() == ""  ) MessageBox.Show("Lütfen Boş Yerleri Doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            else
            {
                DialogResult guncellesinmi = MessageBox.Show("Veri Güncellensinmi ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (guncellesinmi == DialogResult.Yes)
                {
                    OleDbCommand kmtGuncel = new OleDbCommand();
                    baglanti.Open();
                    kmtGuncel.Connection = baglanti;
                    kmtGuncel.CommandText = "update Kisiler set Kilo=@kilo,Boy=@boy, Göbek=@göbek,Kol=@kol,Bacak=@bacak  where Kisi_no=@anahtar";
                    kmtGuncel.Parameters.AddWithValue("@kilo", txt_Kilo.Text);
                    kmtGuncel.Parameters.AddWithValue("@boy", txt_Boy.Text);
                    kmtGuncel.Parameters.AddWithValue("@göbek", txt_Göbek.Text);
                    kmtGuncel.Parameters.AddWithValue("@kol", txt_Kol.Text);
                    kmtGuncel.Parameters.AddWithValue("@bacak", txt_Bacak.Text);
                    
                    kmtGuncel.Parameters.AddWithValue("@anahtar", frm1.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    kmtGuncel.ExecuteNonQuery();
                    baglanti.Close();
                    DataTable tablo = new DataTable();
                    
                    OleDbDataAdapter adaptör = new OleDbDataAdapter("select Kilo,Boy,Göbek,Kol,Bacak from Kisiler", baglanti);
                    adaptör.Fill(tablo);
                    frm1.frmBilgi.dataGridView1.DataSource = tablo;
                }
            }
        }
    }
}
