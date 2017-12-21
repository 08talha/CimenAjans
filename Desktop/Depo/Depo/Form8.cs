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
    public partial class Form8 : Form
    {
        Form2 frm = new Form2();
        public Form8()
        {
            InitializeComponent();
        }
        SqlConnection baglan1 = new SqlConnection("Data Source=REISIALA\\SQLEXPRESS;Initial Catalog=Depo;Integrated Security=True"); //project ten add new Data source dan al iç yeri Firma
        private void button1_Click(object sender, EventArgs e)
        {

            baglan1.Open();            
             SqlCommand komut = new SqlCommand("INSERT INTO [Depo].[dbo].[Firma] (Firma_adi) VALUES ('" + textBox1.Text +"')",baglan1);
            komut.ExecuteNonQuery();				
            baglan1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm.Visible = true;

            this.Close();
        }
    }
}
