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
    
    public partial class frmBilgi : Form
    {
        public Form1 frm1;
        public frmBilgi()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=data.accdb");
        private void frmBilgi_Load(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            OleDbDataAdapter adaptör = new OleDbDataAdapter("select Kilo,Boy,Göbek,Kol,Bacak from Kisiler where Kisi_no=" + frm1.dataGridView1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
            adaptör.Fill(tablo);
            dataGridView1.DataSource = tablo;
            label1.Text = frm1.dataGridView1.CurrentRow.Cells[1].Value.ToString() +" "+ frm1.dataGridView1.CurrentRow.Cells[2].Value.ToString()+" Adlı Müşterimizin Vücut Bilgileri";
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            frm1.frmbilgiGuncelle.ShowDialog();
        }

    }
}
