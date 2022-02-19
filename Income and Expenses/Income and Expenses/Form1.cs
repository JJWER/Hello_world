namespace Income_and_Expenses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV (*.csv) | *.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] readAlllLine = File.ReadAllLines(openFileDialog.FileName);
                string readAllText = File.ReadAllText(openFileDialog.FileName);
                //this.textBox1.Text = readAllText;
                //this.dataGridView1.Rows.Add()

                for (int i = 0; i < readAlllLine.Length; i++)
                {
                    string date = readAlllLine[i];
                    string[] studentSplited = date.Split(',');
                    Income student = new Income(studentSplited[0], studentSplited[1], studentSplited[2]);
                }
            }
        }
    }
}