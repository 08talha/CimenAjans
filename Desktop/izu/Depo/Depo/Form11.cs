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
   
    public partial class Form11 : Form
    {
        Form2 frm = new Form2();
        public Form11()
        {
            InitializeComponent();
            int a = 0;
            SqlConnection baglan1 = new SqlConnection("Data Source=REISIALA\\SQLEXPRESS;Initial Catalog=Depo;Integrated Security=True"); //project ten add new Data source dan al iç yeri depo
            baglan1.Open();
                SqlCommand komut1 = new SqlCommand("Select * from Personel", baglan1);	//bağlantıdan verileri çeker
                SqlDataReader oku = komut1.ExecuteReader();
                while (oku.Read()) //oku dan okunduğu sürece
                {
                   
                    ListViewItem ekle = new ListViewItem();
	                ekle.Text = oku["Personel_ad"].ToString();
	                ekle.SubItems.Add(oku["Personel_Soyad"].ToString());
                    ekle.SubItems.Add(oku["Personel_tel"].ToString());
		            ekle.SubItems.Add(oku["Personel_adres"].ToString());
                    a = Convert.ToInt32(oku["cinsiyet"]);
                    if (a == 0) { ekle.SubItems.Add("Bay"); } else { ekle.SubItems.Add("Bayan"); }
                    ekle.SubItems.Add(oku["dogumTarihi"].ToString());
                    ekle.SubItems.Add(oku["Unvan"].ToString());
                    ekle.SubItems.Add(oku["KayitTarihi"].ToString());
                    listView1.Items.Add(ekle);
                    
                }

            baglan1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm.Visible=true;

            this.Close();
        }
    }
}
