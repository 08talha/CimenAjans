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
    public partial class Form5 : Form
    {
        Form2 frm = new Form2();
        public Form5()
        {
            InitializeComponent();
            SqlConnection baglan1 = new SqlConnection("Data Source=REISIALA\\SQLEXPRESS;Initial Catalog=Depo;Integrated Security=True"); //project ten add new Data source dan al iç yeri "firma"
            baglan1.Open();
                SqlCommand komut1 = new SqlCommand("Select * from [Depo].[dbo].[Depo]", baglan1);	//bağlantıdan verileri çeker
                SqlDataReader oku = komut1.ExecuteReader();
                while (oku.Read()) //oku dan okunduğu sürece
                {               
      
                    ListViewItem ekle = new ListViewItem();
	                ekle.Text = oku["Bölge"].ToString();
	                ekle.SubItems.Add(oku["depoCalisan_id"].ToString());
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
