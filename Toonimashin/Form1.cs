namespace Toonimashin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
                txtDisplay.Text = "6";
            else
                txtDisplay.Text += "6";
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
                txtDisplay.Text = "7";
            else
                txtDisplay.Text += "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
                return;

            txtDisplay.Text += "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
                txtDisplay.Text = "1";
            else
                txtDisplay.Text += "1";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
                txtDisplay.Text = "2";
            else
                txtDisplay.Text += "2";
        }

        private void button14_Click(object sender, EventArgs e)
        {

            if (txtDisplay.Text == "0")
                txtDisplay.Text = "3";
            else
                txtDisplay.Text += "3";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
                txtDisplay.Text = "4";
            else
                txtDisplay.Text += "4";
        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (txtDisplay.Text == "0")
                txtDisplay.Text = "5";
            else
                txtDisplay.Text += "5";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
                txtDisplay.Text = "8";
            else
                txtDisplay.Text += "8";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
                txtDisplay.Text = "9";
            else
                txtDisplay.Text += "9";
        }
    }
}
