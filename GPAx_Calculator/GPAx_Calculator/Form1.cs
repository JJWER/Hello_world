namespace GPAx_Calculator
{
    public partial class Form1 : Form
    {
        double som = 0;
        int n = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string strinput = textBoxGPA1.Text;
            double dinput = double.Parse(strinput);

            if (dinput > max) 
                max = dinput;

            //sum = 0.0 + "4.00"
            sum = sum + dinput;
            n = n + 1;

            double result = sum / n;
            textBoxGPA1
            





        }