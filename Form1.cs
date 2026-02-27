namespace CalculatorGui
{
    public partial class Form1 : Form
    {
        double firstNumber;
        string operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double secondNumber = Convert.ToDouble(txtDisplay.Text);
            double result = 0;

            if (operation == "+")
                result = firstNumber + secondNumber;
            else if (operation == "-")
                result = firstNumber - secondNumber;
            else if (operation == "*")
                result = firstNumber * secondNumber;
            else if (operation == "/")
            {
                if (secondNumber == 0)
                {
                    MessageBox.Show("Cannot divide by zero!");
                    return;
                }
                result = firstNumber / secondNumber;
            }

            txtDisplay.Text = result.ToString();

            History.Items.Add(firstNumber + " " + operation + " " + secondNumber + " = " + result);
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtDisplay.Text);
            operation = "+";
            txtDisplay.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtDisplay.Text);
            operation = "-";
            txtDisplay.Clear();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtDisplay.Text);
            operation = "*";
            txtDisplay.Clear();
        }

        private void btnDevide_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtDisplay.Text);
            operation = "/";
            txtDisplay.Clear();
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text += ".";
            }
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            History.Items.Clear();
        }
    }
}
