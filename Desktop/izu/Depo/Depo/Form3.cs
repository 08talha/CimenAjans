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
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
            ListViewItem ekle = new ListViewItem();
            SqlConnection baglan1 = new SqlConnection("Data Source=REISIALA\\SQLEXPRESS;Initial Catalog=Depo;Integrated Security=True"); 
            baglan1.Open();
             
                SqlCommand komut1 = new SqlCommand("Select * from [Depo].[dbo].[Magaza]", baglan1);	//bağlantıdan verileri çeker
                SqlDataReader oku = komut1.ExecuteReader();
                while (oku.Read()) //oku dan okunduğu sürece
                {   
	                ekle.Text = oku["magaza_id"].ToString();
	                ekle.SubItems.Add(oku["magaza_ad"].ToString());
                    ekle.SubItems.Add(oku["bolge"].ToString());
		            listView1.Items.Add(ekle);                    
                }
            baglan1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Visible = true;

            this.Close();
        }
        
    }
}
