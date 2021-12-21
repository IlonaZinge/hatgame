using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hütchenspiel
{
    public partial class Form1 : Form
    {
         
        public int balance;
        static int usernumber = 0;
        static int randomnumber;
        static int userbid;
        static string userinput;
        static int newbalance;
        public bool isRedHat = false;
        
        public Form1()
        {
            
            InitializeComponent();
            balance = 300;
            label2.Text = "Your balance is: " + balance + "$";           
            Random rnd = new Random();
            randomnumber = rnd.Next(1, 4);



        
            

           
        }

        private void no_money()
        {
            if (balance <= 0)
            {
                MessageBox.Show("You have no money left. Everything will be reseted!!!");
                balance = 300;
                label2.Text = "Your balance is: " + balance + ".";
            }
                
            
        }
        private void bank_balance()
        {
            if (usernumber == randomnumber)
            {
                newbalance = balance + Convert.ToInt32(textBox1.Text);
                balance = newbalance;
            }
            else if (usernumber != randomnumber)
            {
              newbalance =  balance - Convert.ToInt32(textBox1.Text);
                balance = newbalance;
            }
           
            label2.Text = "Your balance is: " + balance + ".";
            textBox1.Clear();
            Random rnd = new Random();
            randomnumber = rnd.Next(1, 4);
            usernumber = 0;
        }
        private void check_hat()
        {
            if (usernumber == randomnumber)
            {

                switch (usernumber)
                {
                    case 1:
                        pictureBox1.Image = Image.FromFile(@"C:\Users\vin_a\source\repos\Hütchenspiel\ball.jpg");
                        break;
                    case 2:
                        pictureBox2.Image = Image.FromFile(@"C:\Users\vin_a\source\repos\Hütchenspiel\ball.jpg");
                        break;
                    case 3:
                        pictureBox3.Image = Image.FromFile(@"C:\Users\vin_a\source\repos\Hütchenspiel\ball.jpg");
                        break;
                }
            }
            else if (usernumber != randomnumber)
            {

                switch (usernumber)
                {
                    case 1:
                        pictureBox1.Image = Image.FromFile(@"C:\Users\vin_a\source\repos\Hütchenspiel\blank.png");
                        break;
                    case 2:
                        pictureBox2.Image = Image.FromFile(@"C:\Users\vin_a\source\repos\Hütchenspiel\blank.png");
                        break;
                    case 3:
                        pictureBox3.Image = Image.FromFile(@"C:\Users\vin_a\source\repos\Hütchenspiel\blank.png");
                        break;
                }
                
            }
        }

        private void play_again()
        {
            if (usernumber == randomnumber)
            {
                MessageBox.Show("You won: " + textBox1.Text + "!!!");
            }
            else
            {
                MessageBox.Show("You lost: " + textBox1.Text + "!!!");
            }
            pictureBox1.Image = Image.FromFile(@"C:\Users\vin_a\source\repos\Hütchenspiel\Hut.png");
            pictureBox2.Image = Image.FromFile(@"C:\Users\vin_a\source\repos\Hütchenspiel\Hut.png");
            pictureBox3.Image = Image.FromFile(@"C:\Users\vin_a\source\repos\Hütchenspiel\Hut.png");
            button1.Visible = true;
            textBox1.Visible = true;         
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {           
            if (textBox1.Text != "")
            {
                if (usernumber == 0)
                {
                    usernumber = 3;
                    check_hat();
                    play_again();
                    bank_balance();
                    no_money();
                }
            }
            else
            {
                MessageBox.Show("Please type in a bid!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {          
            if (textBox1.Text != "")
            {
                if (usernumber == 0)
                {
                    usernumber = 1;
                    check_hat();
                    play_again();
                    bank_balance();
                    no_money();

                }
            }
            else
            {
                MessageBox.Show("Please type in a bid!");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {            
            if (textBox1.Text != "")
            {
                if (usernumber == 0)
                {
                    usernumber = 2;
                    check_hat();
                    play_again();
                    bank_balance();
                    no_money();

                }
            }
            else
            {
                MessageBox.Show("Please type in a bid!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                userinput = Console.ReadLine();
                userbid = Convert.ToInt32(userinput);
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            
                button1.Visible = false;
                textBox1.Visible = false;
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            Form3 newform = new Form3(this);
            this.Hide();
            newform.ShowDialog();
            
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
