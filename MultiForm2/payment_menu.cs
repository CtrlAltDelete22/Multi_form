using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiForm2
{
    public partial class payment_menu : Form
    {
        SearchForm sf = new SearchForm();
        public payment_menu()
        {
            InitializeComponent();
            sf.pm = this;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "140012028009" && textBox2.Text == "20")  
            {
                MessageBox.Show("پرداخت با موفقیت انجام شد");
            }
            textBox1.Text = "";
            textBox2.Text = "";
           
        }


        private void labelX1_Click(object sender, EventArgs e)
        {

            sf.Show();
            
            

            
            
        }

        private void payment_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
