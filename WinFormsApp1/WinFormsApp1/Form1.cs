namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxGPAx_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strinput = textBoxGPA1.Text;

            double sum 0.0;

            double dinput = double.Parse(strinput);

            sum = sum + strinput;

            textBoxGPA1.Text = sum.ToString();
        }
    }
}