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
    public partial class frmAra : Form
    {
        public frmAra()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=data.accdb");
        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            OleDbDataAdapter adaptör = new OleDbDataAdapter("select * from Kisiler where Kisi_ad Like '%"+txtAra.Text+"%'",baglanti);
            adaptör.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void frmAra_Load(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            OleDbDataAdapter adaptör = new OleDbDataAdapter("select * from Kisiler", baglanti);
            adaptör.Fill(tablo);
            dataGridView1.DataSource = tablo;
            dataGridView1.Columns[0].HeaderText = "No";
            dataGridView1.Columns[1].HeaderText = "Adı";
            dataGridView1.Columns[2].HeaderText = "Soyadı";
            dataGridView1.Columns[3].HeaderText = "Tel No";
            dataGridView1.Columns[4].HeaderText = "Cinsiyet";
            dataGridView1.Columns[5].HeaderText = "Adres";
        }
    }
}
