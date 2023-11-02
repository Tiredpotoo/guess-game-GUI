namespace guess_game
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox1.Text) < 0 || Convert.ToInt32(textBox1.Text) > 10)//makes sure its betwenn the right numbers
                {
                    lblHelloWorld.Text = "Make sure its\n between 1-10";
                }
                else
                {
                    lblHelloWorld.Text = "Input a number\n 1-10";
                    button1.Text = "Submit";
                    button1.Enabled = true;
                    button1.Cursor = Cursors.Default;
                }
            }
            catch//if the convert breaks we know its not an int
            {
                if (textBox1.Text != null)
                {
                    lblHelloWorld.Text = "this should be\n a number";
                }
                lblHelloWorld.Text = "this should be\n a number";
                button1.Text = "Can't Submit";
                button1.Enabled = false;
                button1.Cursor = Cursors.No;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) == globals.easyRandomNum)//is it correct
            {
                lblHelloWorld.Text = "nice you got\n it right";
                //Thread.Sleep(3000);
                //lblHelloWorld.Text = "";
            }
            else if (Convert.ToInt32(textBox1.Text) >= globals.easyRandomNum)//is it high
            {
                lblHelloWorld.Text = "Too High!";
                //Thread.Sleep(3000);
                //lblHelloWorld.Text = "";
            }
            else//is it low
            {
                lblHelloWorld.Text = "Too low!";
            }

        }
        private void Form1_Load(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }

    }
    static class globals
    {
        public static Random random = new Random();
        public static int easyRandomNum = random.Next(10);
        public static int mediumRandomNum = random.Next(100);
        public static int GuessNum;
        public static int counter = 0;
        public static int hardRandomNum()
        {
            return random.Next(50);
        }
    }
}
