using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace GUI
{
    
    public partial class Loginform : Form
    {
        public string user = "admin";
        public string pass = "55555";
        
        public Loginform()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Init f = new Init();
            Thread.Sleep(100);
            if (f.login)
            {
                if (richTextBox1.Text == user && richTextBox2.Text == pass)
                {
                    board b = new board();                  
                    b.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect user or password.");
                }
            }
            /*else
            {
                MessageBox.Show("Please open server before login.");
            }*/

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

  

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
