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
    public partial class seferEkle : Form
    {
        SqlConnection baglan1 = new SqlConnection("Data Source=REISIALA\\SQLEXPRESS;Initial Catalog=Depo;Integrated Security=True"); //project ten add new Data source dan al iç yeri depo
        ListViewItem ekle = new ListViewItem();
        string s1;
        public seferEkle()
        {
            InitializeComponent();
            baglan1.Open();
            SqlCommand komut1 = new SqlCommand("Select * from [Depo].[dbo].[Araclar]", baglan1);   //bağlantıdan verileri çeker
            SqlDataReader oku = komut1.ExecuteReader();
            while (oku.Read()) //oku dan okunduğu sürece
            {
                comboBox1.Items.Add("Id: "+oku["arac_id"].ToString()+" "+oku["AracModeli"].ToString());
            }
            int depoID=0;
            SqlCommand komut2 = new SqlCommand("Select * from [Depo].[dbo].[Stok] WHERE depo_id='"+depoID+"'", baglan1);   //bağlantıdan verileri çeker
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read()) //oku dan okunduğu sürece
            {
                SqlCommand komut3 = new SqlCommand("Select * from [Depo].[dbo].[Urunler] WHERE ürün_id='"+oku2["ürün_id"].ToString()+"'", baglan1);   //bağlantıdan verileri çeker
                SqlDataReader oku3 = komut3.ExecuteReader();
                while (oku3.Read()) //oku dan okunduğu sürece
                {
                    comboBox2.Items.Add(oku3["ürün_id"].ToString()+"  "+ oku3["ürünAdi"].ToString());
                }
            }
            baglan1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string ürün_id = (comboBox2.Text).Split('  ')[0];
            baglan1.Open();
            int depoID = 0;
            SqlCommand komut2 = new SqlCommand("Select * from [Depo].[dbo].[Stok] WHERE depo_id='" + depoID + "', ürün_id='"+ürün_id+"'", baglan1);   //bağlantıdan verileri çeker
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read()) //oku dan okunduğu sürece
            {
                int say=Int32.Parse(oku2["ürünAdet"].ToString());
                for(int i = 0; i < say; i++)
                {
                    comboBox3.Items.Add(i);
                }
                  
            }
            baglan1.Close();
            label6.Visible = true;
            comboBox3.Visible = true;
            button4.Visible = true;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglan1.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO '[Depo].[dbo].[Sefer]' (yuklenenMalzemeler,hareketSaati,depoCalisan_id,islem_tarihi,arac_id) VALUES (" +""+ " )", baglan1);
            komut.ExecuteNonQuery();
            baglan1.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            ekle.Text = (comboBox2.Text);
            ekle.SubItems.Add(comboBox3.Text);

            listView1.Items.Add(ekle);
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
