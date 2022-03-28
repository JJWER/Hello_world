using My_library;

namespace MyUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //create object from MyMath class
            MyMath myMath = new MyMath();
            int sum1 = myMath.getSummation(1,2);
            int sum2 = myMath.getSummation(2, 3, 4);

            this.textBox1.Text = sum1.ToString();

            string grade = MyGPA.calculateGrade(80.0);
            this.textBox2.Text = sum2.ToString();



        }
    }
}