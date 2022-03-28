using System.Text;

namespace Income_And_Expenses_agen
{
    public partial class Form1 : Form
    {
        INE oGPACal = new INE();

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
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
        int SumIN = 0, SumEX = 0, FIn = 0, FEx = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            /* เก็บไว้ก่อน
            string _list = this.textBox2.Text;
            string _count = this.textBox3.Text;
            string _type = this.comboBox1.Text;
            string _Date = this.textBoxDate.Text;
            oGPACal.addGPA(_Date, _list, _type, _count);
            textBox3.Text = "";
            textBox2.Text = string.Empty;
            textBox1.Text = oGPACal.getAlldata();
            */

            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = textBoxDate.Text;
            dataGridView1.Rows[n].Cells[1].Value = textBox2.Text;
            dataGridView1.Rows[n].Cells[2].Value = textBox4.Text;
            dataGridView1.Rows[n].Cells[3].Value = textBox5.Text;


            FIn = Convert.ToInt32(textBox4.Text);
            FEx = Convert.ToInt32(textBox5.Text);

            SumIN += FIn;
            SumEX += FEx;

            textBox1.Text = SumIN.ToString();
            textBox6.Text = SumEX.ToString();

        }


    }
}