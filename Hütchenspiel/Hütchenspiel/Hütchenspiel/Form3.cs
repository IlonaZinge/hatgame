using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hütchenspiel
{
    public partial class Form3 : Form
    {
        public  Form1 mydady;
        public Form3(Form1 mydady)
        {
            InitializeComponent();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            this.mydady = mydady;

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label9.Text = "Your balance is: " +mydady.balance+ "$";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 newform = new Form1();
            this.Hide();
            newform.ShowDialog();
          
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label5.Hide();
            button1.Show();
            mydady.isRedHat = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dickhat_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
