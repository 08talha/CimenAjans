using System;
using System.Windows.Forms;

namespace Depo
{


    public partial class Form2 : Form
    {
        
        
        
       
        
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();

            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();

            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            
            frm7.Show();

            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            
            frm8.Show();

            this.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            
            frm9.Show();

            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form10 frm10 = new Form10();
            
            frm10.Show();

            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form11 frm11 = new Form11();
            frm11.Show();

            //this.Visible = false;
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form12 frm12 = new Form12();
            frm12.Show();

            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form13 frm13 = new Form13();
            frm13.Show();

            this.Close();
        }
    }
}
