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
    public partial class Form6 : Form
    {
        Form2 frm = new Form2();
        public Form6()
        {
            InitializeComponent();
            SqlConnection baglan1 = new SqlConnection("Data Source=REISIALA\\SQLEXPRESS;Initial Catalog=Depo;Integrated Security=True"); //project ten add new Data source dan al iç yeri depo
            baglan1.Open();
                SqlCommand komut1 = new SqlCommand("Select * from [Depo].[dbo].[Depo]", baglan1);	//bağlantıdan verileri çeker
                SqlDataReader oku = komut1.ExecuteReader();
                while (oku.Read()) //oku dan okunduğu sürece
                {
                   comboBox1.Items.Add(oku["bolge"].ToString());
                }
            baglan1.Close();
        }

         SqlConnection baglan2 = new SqlConnection("Data Source=REISIALA\\SQLEXPRESS;Initial Catalog=Depo;Integrated Security=True"); //project ten add new Data source dan al iç yeri magaza
        
        private void button1_Click(object sender, EventArgs e)
        {
            baglan2.Open();            
             SqlCommand komut = new SqlCommand("INSERT INTO '[Depo].[dbo].[Magaza]' (Magaza_adi,stok_id,bolge) VALUES (" + textBox1.Text + ",0,"+comboBox1.Text.ToString()+" )",baglan2);
            komut.ExecuteNonQuery();
            baglan2.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm.Visible = true;

            this.Close();
        }

       
    }
}
