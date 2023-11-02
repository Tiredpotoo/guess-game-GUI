using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guess_game
{
    public partial class Medium : Form
    {
        public Medium()
        {
            InitializeComponent();
        }

        private void Medium_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox1.Text) < 0 || Convert.ToInt32(textBox1.Text) > 100)//makes sure the number is within the range
                {
                    lblHelloWorld.Text = "Make sure its\n 1-100";
                }
                else//if not they cant submit and break it
                {
                    lblHelloWorld.Text = "Input\n 1-100";
                    button1.Text = "Submit";
                    button1.Enabled = true;
                    button1.Cursor = Cursors.Default;
                }
            }
            catch//if he convert breaks the try then we know its not a number
            {
                if (textBox1.Text != null)
                {
                    lblHelloWorld.Text = "this should be a number";
                }
                button1.Text = "Can't Submit";
                button1.Enabled = false;
                button1.Cursor = Cursors.No;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) == globals.mediumRandomNum)// equals
            {
                lblHelloWorld.Text = "you got\n it right";
                //Thread.Sleep(3000);
                //lblHelloWorld.Text = "";
            }
            else if (Convert.ToInt32(textBox1.Text) >= globals.mediumRandomNum)//too high
            {
                lblHelloWorld.Text = "Too High";
                //Thread.Sleep(3000);
                //lblHelloWorld.Text = "";
            }
            else//too low
            {
                lblHelloWorld.Text = "Too low";
            }
        }

        private void lblHelloWorld_Click(object sender, EventArgs e)
        {

        }
    }
}
