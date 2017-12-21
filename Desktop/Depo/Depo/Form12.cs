using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depo
{
    
    public partial class Form12 : Form
    {
        Form2 frm = new Form2();
        public Form12()
        {
            InitializeComponent();
            SqlConnection baglan1 = new SqlConnection("Data Source=REISIALA\\SQLEXPRESS;Initial Catalog=Depo;Integrated Security=True"); //project ten add new Data source dan al iç yeri "firma"
            baglan1.Open();
            SqlCommand komut1 = new SqlCommand("Select * from [Depo].[dbo].[Sefer]", baglan1);   //bağlantıdan verileri çeker
            SqlDataReader oku = komut1.ExecuteReader();
            while (oku.Read()) //oku dan okunduğu sürece
            {

                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["seferNo"].ToString();
                ekle.SubItems.Add(oku["hareketSaati"].ToString());
                ekle.SubItems.Add(oku["AracModeli"].ToString());
                ekle.SubItems.Add(oku["depoCalisan_id"].ToString());
                ekle.SubItems.Add(oku["yuklenenMalzemeler"].ToString());
                listView1.Items.Add(ekle);

            }
            baglan1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm.Visible = true;

            this.Close();
        }
    
    }
}
