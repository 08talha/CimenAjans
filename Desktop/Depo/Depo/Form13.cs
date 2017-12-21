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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
            SqlConnection baglan1 = new SqlConnection("Data Source=REISIALA\\SQLEXPRESS;Initial Catalog=Depo;Integrated Security=True"); //project ten add new Data source dan al iç yeri "firma"
            baglan1.Open();
            SqlCommand komut1 = new SqlCommand("Select * from [Depo].[dbo].[Araclar]", baglan1);   //bağlantıdan verileri çeker
            
            SqlDataReader oku = komut1.ExecuteReader();
            while (oku.Read()) //oku dan okunduğu sürece
            {

                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["AracModeli"].ToString();
                SqlCommand komut2 = new SqlCommand("Select * from [Depo].[dbo].[Depo] WHERE depo_id='"+ oku["depo_id"].ToString()+"'", baglan1);   //bağlantıdan verileri çeker
                SqlDataReader oku2 = komut1.ExecuteReader();
                while (oku2.Read()) //oku dan okunduğu sürece
                {
                    ekle.SubItems.Add(oku["depo_id"].ToString());
                    ekle.SubItems.Add(oku["Bölge"].ToString());
                }

                listView1.Items.Add(ekle);

            }
            baglan1.Close();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Visible = true;

            this.Close();
        }
    }
}
