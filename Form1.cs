namespace A01_Calculator
{
    public partial class Form1 : Form
    {
        private bool isNewEntry = true;
        private int originalWidth;
        string operation;

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
    }
}
