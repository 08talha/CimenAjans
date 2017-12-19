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
    
    public partial class Form10 : Form
    {
        Form2 frm2 = new Form2();
        int cinsiyet = 1;
        public Form10()
        {
            InitializeComponent();
            SqlConnection baglan1 = new SqlConnection("Data Source=REISIALA\\SQLEXPRESS;Initial Catalog=Depo;Integrated Security=True"); //project ten add new Data source dan al iç yeri depo
            baglan1.Open();
                SqlCommand komut1 = new SqlCommand("Select * from [Depo].[dbo].[Depo]", baglan1);	//bağlantıdan verileri çeker
                SqlDataReader oku = komut1.ExecuteReader();
                while (oku.Read()) //oku dan okunduğu sürece
                {
                   comboBox1.Items.Add(oku["bolge"].ToString());
                   comboBox2.Items.Add(oku["depo_adi"].ToString());
                   
                }
            baglan1.Close();
        }
        SqlConnection baglan1 = new SqlConnection("Data Source=REISIALA\\SQLEXPRESS;Initial Catalog=Depo;Integrated Security=True"); //project ten add new Data source dan al iç yeri depo

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { cinsiyet = 1; }
            else { cinsiyet = 0; }
            baglan1.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO [Depo].[dbo].[Personel] (Personel_ad,Personel_soyad,Personel_tel,Personel_adres,cinsiyet,dogumTarihi,Unvan,KayitTarihi) VALUES (" + textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + "," + textBox4.Text + "," + cinsiyet + "," + dateTimePicker1.Value.ToString("yyyy-MM-dd") + ","+comboBox1.Text.ToString()+"," + DateTime.Now.ToString("yyyy-MM-dd") +" )",baglan1);
            komut.ExecuteNonQuery();
            baglan1.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            frm2.Visible = true;
            this.Close();
        }
            
    }
}
