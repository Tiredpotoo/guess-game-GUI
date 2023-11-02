using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guess_game
{
    public partial class Hard : Form
    {
        public Hard()
        {
            InitializeComponent();
        }

        private void Hard_Load(object sender, EventArgs e)
        {
            int hardRandomNum = globals.hardRandomNum();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox1.Text) < 0 || Convert.ToInt32(textBox1.Text) > 50)//sees if num is between range
                {
                    lblHelloWorld.Text = "thats not\n 1-50";
                    button1.Text = "Can't Submit";
                    button1.Enabled = false;
                }
                else//else you cant submit
                {
                    lblHelloWorld.Text = "give num";
                    button1.Text = "Submit";
                    button1.Enabled = true;
                    button1.Cursor = Cursors.Default;
                }                
            }
            catch//and if the convert breaks the try then we know its not a number
            {
                if (textBox1.Text != null)
                {
                    lblHelloWorld.Text = "thats no\n number";
                }
                button1.Text = "Can't Submit";
                button1.Enabled = false;
                button1.Cursor = Cursors.No;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (Convert.ToInt32(textBox1.Text) == globals.hardRandomNum())//is it equal
            {
                lblHelloWorld.Text = "Damn";
                //Thread.Sleep(3000);
                //lblHelloWorld.Text = "";
            }
            else
            {
                lblHelloWorld.Text = "wrong";//or just wrong
            }

            if (Convert.ToInt32(textBox1.Text) == globals.GuessNum && globals.counter > 3)
                {
                    button1.Text = "Can't Submit";
                    button1.Enabled = false;
                    lblHelloWorld.Text = "use new\n num";
                }
                else if (Convert.ToInt32(textBox1.Text) == globals.GuessNum)
                {
                    globals.counter++;
                }
                else
                {
                    globals.counter = 0;
                }
            globals.GuessNum = Convert.ToInt32(textBox1.Text);
        }

        private void lblHelloWorld_Click(object sender, EventArgs e)
        {

        }
    }
}
