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
    public partial class SearchForm : Form
    {
        public payment_menu pm;
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtsearch.Text.Contains("mehdi")) 
            {
                MessageBox.Show("140012028009");
                txtsearch.Text = "";
                this.Hide();
                return;
                
            }
            if(txtsearch.Text == "") 
            {
                MessageBox.Show("please Enter Your Name");
                return;
            }
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtsearch.Text = "";
        }
    }
}
