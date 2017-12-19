using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Depo
{
    public partial class Form4 : Form
    {
        Form2 frm = new Form2();
        public Form4()
        {
            InitializeComponent();
            SqlConnection baglan1 = new SqlConnection("Data Source=REISIALA\\SQLEXPRESS;Initial Catalog=Depo;Integrated Security=True"); //project ten add new Data source dan al iç yeri "urun"
            baglan1.Open();
                SqlCommand komut1 = new SqlCommand("Select stok_id,ürünAdet from [Depo].[dbo].[stok]", baglan1);	//bağlantıdan verileri çeker
                SqlDataReader oku = komut1.ExecuteReader();
            while (oku.Read()) //oku dan okunduğu sürece
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["stok_id"].ToString();
                ekle.SubItems.Add(oku["adet"].ToString());
            }
            baglan1.Close();
            baglan1.Open();
            SqlCommand komut2 = new SqlCommand("Select urun_adi,katagori_adi from [Depo].[dbo].[Urun] ", baglan1);  //bağlantıdan verileri çeker
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read()) //oku dan okunduğu sürece
            {
                ListViewItem ekle = new ListViewItem();
                ekle.SubItems.Add(oku2["katagori_adi"].ToString());
                ekle.SubItems.Add(oku2["urun_adi"].ToString());
		        
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
