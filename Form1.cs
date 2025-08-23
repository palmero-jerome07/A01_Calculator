using System.Data.OleDb;
using System.Text;
using System.Windows.Forms;

namespace A01_Calculator
{
    public partial class Form1 : Form
    {

        private bool isNewEntry = true;
        private int originalWidth;
        string operation = "";
        double firstNumber = 0;

        string dbPath = @"C:\LOCALDB\Calculator.accdb";

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
                txtDisplay.Text = btn.Text;
                txtEquation.Text = btn.Text;
                return;
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
            txtDisplay.Text = "0";
            isNewEntry = true;

            if (!string.IsNullOrWhiteSpace(operation) && txtEquation.Text.Contains(operation))
            {
                int opIndex = txtEquation.Text.LastIndexOf(operation);
                if (opIndex >= 0)
                {
                    txtEquation.Text = txtEquation.Text.Substring(0, opIndex + operation.Length + 1);
                }
            }
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
            txtEquation.Text += " = " + result.ToString();
            isNewEntry = true;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            total(); //total of the equation
            InsertEquationToDatabase(txtEquation.Text);
            DisplayDBtoTB();
        }

        private void InsertEquationToDatabase(string equationText)
        {
            // Build connection string again
            string connStr = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};";

            //SQL query for inserting a new row into the table
            string insertQuery = "INSERT INTO tbl_Calculator_History (Equation) VALUES (@equation)";

            //Use OleDbConnection in using block for safety
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                try
                {
                    conn.Open();
                    OleDbCommand insertCmd = new OleDbCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@equation", equationText);
                    insertCmd.ExecuteNonQuery();

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting data: " + ex.Message);
                }
            }
        }
        private void DisplayDBtoTB()
        {
            // Build connection string
            string connStr = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};";

            // SQL query to fetch all rows from the table
            string query = "SELECT Equation FROM tbl_Calculator_History order by ID desc";
            //string clearTb = "DELETE FROM tbl_Calculator_History WHERE ID";

            // Use OleDbConnection in a using block for safety
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                try
                {   
                    //open the connection to the Access database   
                    conn.Open();
                    //Prepare the SQL command using the query
                    OleDbCommand selectCmd = new OleDbCommand(query, conn);
                    //Excute the command and get the data reader
                    OleDbDataReader reader = selectCmd.ExecuteReader();
                    //Use StringBuilder to build the output string efficiently
                    StringBuilder sb = new StringBuilder();
                    // Clear the TextBox before appending new data
                    txtHistory.Clear();

                    // Read data and append to the TextBox
                    while (reader.Read())
                    {
                        string equation = reader["Equation"].ToString();
                        sb.AppendLine(equation);
                    }
                    txtHistory.ScrollBars = ScrollBars.Vertical;
                    txtHistory.Text = sb.ToString();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching data: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            txtEquation.Clear();
            operation = "";
            firstNumber = 0;
            isNewEntry = true;
        }

        private void btnErase_Click_1(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);

                if (txtEquation.Text.Length > 0)
                {
                    txtEquation.Text = txtEquation.Text.Substring(0, txtEquation.Text.Length - 1);
                }
            }
        }
    }
}