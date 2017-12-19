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
    public partial class Form7 : Form
    {
        Form2 frm = new Form2();
        public Form7()
        {
            InitializeComponent();
        }
        Boolean kntrl = false,kntrl2=false;
        String firma_adi = "";
        int firmaId = 0, urun_id = 0;
        SqlConnection baglan1 = new SqlConnection("Data Source=REISIALA\\SQLEXPRESS;Initial Catalog=Depo;Integrated Security=True"); //project ten add new Data source dan al iç yeri ürün
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text== "Bulunan Ürün")
            {
                label2.Visible = true;
                textBox1.Visible = false;
                label3.Visible = true;
                textBox2.Visible = true;
                kntrl = false;
                comboBox3.Visible = true;
                baglan1.Open();
                SqlCommand komut3 = new SqlCommand("Select * from Urun", baglan1);  //bağlantıdan verileri çeker
                SqlDataReader oku = komut3.ExecuteReader();
                while (oku.Read()) //oku dan okunduğu sürece
                {

                    comboBox3.Items.Add(oku["urun_adi"].ToString());

                }
                baglan1.Close();
            }
            if(comboBox1.Text== "Yeni Ürün")
            {
                comboBox3.Visible = false;
                kntrl = true;
                baglan1.Open();
                SqlCommand komut2 = new SqlCommand("Select * from Katagori", baglan1);	//bağlantıdan verileri çeker
                SqlDataReader oku = komut2.ExecuteReader();
                while (oku.Read()) //oku dan okunduğu sürece
                {
                    
                        comboBox2.Items.Add(oku["KatagoriAdi"].ToString());
                    
                }
                baglan1.Close();
                label2.Visible = true;
                textBox1.Visible = true;
                label3.Visible = true;
                textBox2.Visible = true;
                label5.Visible = true;
                comboBox2.Visible = true;
                label4.Visible = true;
                textBox3.Visible = true;

            }
            button2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm.Visible = true;

            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (kntrl)
            {
                baglan1.Open();
                SqlCommand komut5 = new SqlCommand("Select * from [Depo].[dbo].[Firma]", baglan1);  //bağlantıdan verileri çeker
                SqlDataReader oku12 = komut5.ExecuteReader();
                while (oku12.Read()) //oku dan okunduğu sürece
                {
                    if (textBox3.Text == oku12["Firma_adi"].ToString())
                    {
                        firmaId = Convert.ToInt32(oku12["Firma_id"]);
                        kntrl2 = false;
                    }
                    else
                    {
                        kntrl2 = true;
                    }
                    
                }
                if (kntrl2)
                {
                    SqlCommand komut6 = new SqlCommand("INSERT INTO [Depo].[dbo].[Firma] (Firma_adi) VALUES ('" + textBox3.Text + "')", baglan1);
                    komut6.ExecuteNonQuery();

                }
                baglan1.Close();

                baglan1.Open();
                SqlCommand komut22 = new SqlCommand("INSERT INTO [Depo].[dbo].[Urun] (urun_adi,katagori_adi,firma_id) VALUES ('" + textBox1.Text + "','" + comboBox2.Text + "'," + firmaId + " )",baglan1);
                komut22.ExecuteNonQuery();
                baglan1.Close();

                baglan1.Open();
                SqlCommand komut3 = new SqlCommand("Select * from [Depo].[dbo].[Urun]", baglan1);  //bağlantıdan verileri çeker
                SqlDataReader oku1 = komut3.ExecuteReader();
                while (oku1.Read()) //oku dan okunduğu sürece
                {
                    if (textBox1.Text == oku1["urun_adi"].ToString())
                    {
                        urun_id = Convert.ToInt32(oku1["urun_id"]);
                    }
                    else if (comboBox3.Text == oku1["urun_adi"].ToString())
                    {
                        urun_id = Convert.ToInt32(oku1["urun_id"]);
                    }
                }
                baglan1.Close();
                baglan1.Open();
                SqlCommand komut1 = new SqlCommand("Select * from [Depo].[dbo].[Stok]", baglan1);  //bağlantıdan verileri çeker
                SqlDataReader oku5 = komut1.ExecuteReader();
                while (oku5.Read()) //oku dan okunduğu sürece
                {
                    if (urun_id == Convert.ToInt32(oku5["urun_id"]))
                    {
                        SqlCommand komut13 = new SqlCommand("INSERT INTO [Depo].[dbo].[Stok] (urun_id,adet) VALUES (" + urun_id + "," + (Convert.ToInt32(oku5["adet"]) + Convert.ToInt32(textBox2)) + " )", baglan1);
                        komut13.ExecuteNonQuery();
                    }
                }
                baglan1.Close();
                
            }





            
            else{
                baglan1.Open();
                SqlCommand komut4 = new SqlCommand("Select * from [Depo].[dbo].[Urun]", baglan1);  //bağlantıdan verileri çeker
                SqlDataReader oku = komut4.ExecuteReader();
                while (oku.Read()) //oku dan okunduğu sürece
                {
                    if (textBox1.Text == oku["urun_adi"].ToString())
                    {
                        urun_id = Convert.ToInt32(oku["urun_id"]);
                    }
                    else if (comboBox3.Text == oku["urun_adi"].ToString())
                    {
                        urun_id = Convert.ToInt32(oku["urun_id"]);
                    }
                }
                baglan1.Close();
                baglan1.Open();
                SqlCommand komut5 = new SqlCommand("Select * from [Depo].[dbo].[Stok]", baglan1);  //bağlantıdan verileri çeker
                SqlDataReader oku3 = komut5.ExecuteReader();
                while (oku3.Read()) //oku dan okunduğu sürece
                {
                    if (urun_id == Convert.ToInt32(oku3["urun_id"]))
                    {
                        SqlCommand komut31 = new SqlCommand("INSERT INTO [Depo].[dbo].[Stok] (urun_id,adet) VALUES (" + urun_id + "," + (Convert.ToInt32(oku["adet"]) + Convert.ToInt32(textBox2)) + " )", baglan1);
                        komut31.ExecuteNonQuery();
                    }
                }
                baglan1.Close();
            }
            
        }
             

        }

       
}