namespace WindowForm_Abstract_Interface
{
    public partial class Form1 : Form
    {
        List<Student> cSharpStudent;
        List<Student> pythonStudent;
        public Form1()
        {
            InitializeComponent();

            this.cSharpStudent = new List<Student>();
            this.pythonStudent = new List<Student>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = this.textBoxName.Text;
            student.Lastname = this.textBoxLastname.Text;

            this.cSharpStudent.Add(student);
            displayStudentData();
        }
        private void displayStudentData()
        {
            this.textBox1.Text = "Student in C# course : "
                + this.cSharpStudent.Count + "\r\n"
                + "Student in Python course : "
                + this.pythonStudent.Count;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonPy_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = this.textBoxName.Text;
            student.Lastname = this.textBoxLastname.Text;

            this.pythonStudent.Add(student);
            displayStudentData();
        }
    }
}