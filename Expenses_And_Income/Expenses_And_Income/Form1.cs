using System.Text;

namespace Expenses_And_Income
{
    public partial class Form1 : Form
    {
        Data oGPACal = new Data();
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                string filepath = openFileDialog.FileName;
                string data = File.ReadAllText(filepath);
                this.textBox1.Text = data;
            }

            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string data = this.textBox1.Text;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV | *csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                 string filepath = saveFileDialog.FileName;
                 //save file
                 File.WriteAllText(saveFileDialog.FileName, data, Encoding.UTF8);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _list = this.textBox2.Text;
            string _count = this.textBox3.Text;
            string _type = this.comboBox1.Text;
            oGPACal.addGPA(_list, _type, _count);
            textBox3.Text = "";
            textBox2.Text = string.Empty;
            textBox1.Text = oGPACal.getAlldata();
        }
    }
}
