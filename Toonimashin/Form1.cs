namespace Toonimashin
{
    public partial class Form1 : Form
    {

        double num1, num2;
        string op;
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
            double number = Convert.ToDouble(txtDisplay.Text);

            txtDisplay.Text = (number / 100).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtDisplay.Text);
            op = "/";
            txtDisplay.Text = "";
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
            num1 = Convert.ToDouble(txtDisplay.Text);
            op = "-";
            txtDisplay.Text = "";
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

        private void button20_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtDisplay.Text, out num2))
            {
                MessageBox.Show("Зөвхөн тоо оруулна уу.");
                return;
            }

            if (op == "+")
            {
                txtDisplay.Text = (num1 + num2).ToString();
            }
            else if (op == "-")
            {
                txtDisplay.Text = (num1 - num2).ToString();
            }
            else if (op == "*")
            {
                txtDisplay.Text = (num1 * num2).ToString();
            }
            else if (op == "/")
            {
                if (num2 == 0)
                {
                    MessageBox.Show("0-д хувааж болохгүй!");
                    return;
                }

                txtDisplay.Text = (num1 / num2).ToString();
            }
            else if (op == "%")
            {
                txtDisplay.Text = (num1 % num2).ToString();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtDisplay.Text);
            op = "+";
            txtDisplay.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtDisplay.Text);
            op = "*";
            txtDisplay.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            num1 = 0;
            num2 = 0;
            op = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text += ".";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }
    }
}
