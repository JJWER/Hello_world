namespace GPAxCalculator
{
    public partial class Form1 : Form
    {
        GPACalculator oGPAcal = new GPACalculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = this.textBoxGPA_input.Text;
            string name = this.textBoxNameInput.Text;

            double dInput = Convert.ToDouble(input);
            oGPAcal.addGPA(dInput, name);         

            double gpax = oGPAcal.getGPAx();
            textBoxGPAx.Text = gpax.ToString();

            textBoxMaxGPA.Text = oGPAcal.getMax().ToString();
            textBoxMaxName.Text = oGPAcal.getMaxName().ToString();

            textBoxMinGPA.Text = oGPAcal.getMin().ToString();
            textBoxMinName.Text = oGPAcal.getMinname().ToString();

            textBoxGPA_input.Text = "";
            textBoxNameInput.Text = string.Empty;
            textBoxAllData.Text = oGPAcal.getAllData();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxGPAx.Text = "";
            textBoxGPA_input.Text = "";
            textBoxMaxGPA.Text = "";
            textBoxMinGPA.Text = "";

        }
    }
}