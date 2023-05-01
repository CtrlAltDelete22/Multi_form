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
    public partial class Form1 : Form
    {
       payment_menu pm = new payment_menu();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "admin" && txtpassword.Text == "admin") 
            {
                pm.Show();
                
                this.Hide();
            }
            else if(txtUsername.Text == "") 
            {
                MessageBox.Show("please enter your username");
            }
            else if(txtpassword.Text == "") 
            {
                MessageBox.Show("please enter your password");
            }
            else 
            {
                MessageBox.Show("your username or password are incorrect");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
