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
    public partial class Form1 : Form
    {
        Form2 frm = new Form2();
        public Form1()
        {
            InitializeComponent();
        }
        private string isimid="Admin";
        private string ps="IzuMarket";
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglan1 = new SqlConnection("Data Source=REISIALA\\SQLEXPRESS;Initial Catalog=Depo;Integrated Security=True");
            baglan1.Open();

            SqlCommand komut1 = new SqlCommand("Select * from [Depo].[dbo].[user] where user_adi='" + textBox1.Text+"'", baglan1);    //bağlantıdan verileri çeker
            SqlDataReader oku = komut1.ExecuteReader();
            while (oku.Read()) //oku dan okunduğu sürece
            {

                isimid = oku["user_adi"].ToString();
                ps=(oku["user_pass"].ToString());
               
            }



            baglan1.Close();
            if (textBox1.Text == isimid & textBox2.Text == ps)
            {
                
                frm.Show();

                this.Visible = false;

            }
        }
    }
}
