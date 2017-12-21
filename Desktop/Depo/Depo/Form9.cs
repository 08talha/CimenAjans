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
    
    public partial class Form9 : Form
    {
        Form2 frm = new Form2();
        int blg = 0;
        public Form9()
        {
            InitializeComponent();
        }

        SqlConnection baglan1 = new SqlConnection("Data Source=REISIALA\\SQLEXPRESS;Initial Catalog=Depo;Integrated Security=True"); 
        private void button1_Click(object sender, EventArgs e)
        {

            baglan1.Open();
            SqlCommand komut = new SqlCommand("Select depo_id from Depo",baglan1);	//bağlantıdan verileri çeker
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read()) //oku dan okunduğu sürece
            {
	            blg=Convert.ToInt32(oku["depo_id"]);
            }
            baglan1.Close();
            baglan1.Open();
            SqlCommand komut2 = new SqlCommand("insert into Depo (Depo_ad,stok_id,urun_id,bolge) VALUES ('" + textBox1.Text + "',1,1,"+(blg+1)+")",baglan1);
            komut2.ExecuteNonQuery();
            baglan1.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm.Visible = true;

            this.Close();
        }
    }
}
