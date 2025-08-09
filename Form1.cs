namespace A01_Calculator
{
    public partial class Form1 : Form
    {
        private bool isNewEntry = true;
        private int originalWidth;
        string operation = "";
        double firstNumber = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 245;
            originalWidth = this.Width;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (this.Width >= 370)
            {
                this.Width = originalWidth;
            }
            else
            {
                this.Width = 370;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void Load_Key(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (isNewEntry)
            {
                txtDisplay.Text = "";
                isNewEntry = false;
            }
            if (btn.Text != "." && txtDisplay.Text == "0")
            {
                txtDisplay.Text += "";
            }

            int dotCount = txtDisplay.Text.Count(c => c == '.');

            if (dotCount >= 1)
            {
                if (btn.Text != ".")
                {
                    txtDisplay.Text += btn.Text;
                    txtEquation.Text += btn.Text;
                }
            }
            else if (txtDisplay.Text == "" && btn.Text == ".")
            {
                txtDisplay.Text = "0.";
                txtEquation.Text = "0.";
            }
            else
            {
                txtDisplay.Text += btn.Text;
                if (txtDisplay.Text.Contains(".."))
                {
                    txtDisplay.Text = txtDisplay.Text.Replace("..", ".");
                }
                txtEquation.Text += btn.Text;
            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Load_Key(sender, e);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Load_Key(sender, e);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Load_Key(sender, e);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Load_Key(sender, e);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Load_Key(sender, e);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Load_Key(sender, e);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Load_Key(sender, e);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Load_Key(sender, e);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Load_Key(sender, e);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Load_Key(sender, e);
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            Load_Key(sender, e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            txtEquation.Clear();
        }

        private void btnDot_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {

        }

        private void Operator(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (double.TryParse(txtDisplay.Text, out firstNumber))
            {

                operation = btn.Text;
                isNewEntry = true;
                txtEquation.Text = firstNumber.ToString() + " " + operation + " ";
            }
        }
        private void total()
        {

            double secondNumber = 0;
            double result = 0;
            if (!double.TryParse(txtDisplay.Text, out secondNumber))
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }
            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.", "Pogi ni jerome");
                        return;
                    }
                    result = firstNumber / secondNumber;
                    break;
                default:
                    MessageBox.Show("Please select an operation.", "Error");
                    return;
            }
            txtDisplay.Text = result.ToString();
            isNewEntry = true;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            total(); //total of the equation
        }
    }
}
