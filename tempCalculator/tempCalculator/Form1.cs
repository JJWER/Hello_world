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
            //convert to F
            //F = c x 9/5 + 32
            double c = Convert.ToDouble(Input);
            double f = c * 9 / 5 + 32;

            //Show input to textBox
            textBoxF.Text = f.ToString();


        }

        private void bottonConvert_Click(object sender, EventArgs e)
        {
            // input
            //textBoxC.Text = "Hello";
            string Input = textBoxF.Text;
            //convert to C
            //(°C x 9/5) + 32
            double f = Convert.ToDouble(Input);
            double c = (f - 32) / 1.80;

            //Show input to textBox
            textBoxC.Text = c.ToString();


        }

        private void buttonClear_Click(object sender, EventArgs e)
        {

            textBoxC.Text = "";
            textBoxF.Text = "";

        }
    }
}