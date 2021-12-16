namespace tempCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            // input
            //textBoxC.Text = "Hello";
            string Input = textBoxC.Text;
            textBoxF.Text = Input;


        }
    }
}