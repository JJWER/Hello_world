using System.Data;

namespace Income_and_Expenses_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxIncome.Text = dataGridView1.ProductVersion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            txtFilePath.Text = openFileDialog1.FileName;
            BindDataCSV(txtFilePath.Text);
        }
        private void BindDataCSV(string filepath)
        {
            DataTable dt = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(filepath);
            if (lines.Length > 0)
            {
                string FirstLine =lines[0];

                string[] headerLabels = FirstLine.Split(',');
                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord)); 

                }

                for (int r = 1; r < lines.Length; r++)
                {
                    string[] dataword = lines[r].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        
                        dr[headerWord] = dataword[columnIndex++];
                    }
                    
                    dt.Rows.Add(dr);
                }

            }
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }
            


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV (*.csv) | *.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] readAlllLine = File.ReadAllLines(openFileDialog.FileName);
                string readAllText = File.ReadAllText(openFileDialog.FileName);

                for (int i = 0; i < readAlllLine.Length; i++)
                {
                    string gridRAW = readAlllLine[i];
                    string[] DataSplited = gridRAW.Split(',');
                    AllDataGridView alldatagridview = new AllDataGridView(DataSplited[0], 
                        DataSplited[1], DataSplited[2], DataSplited[3], DataSplited[4]);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxDate.Text = dataGridView1.ProductVersion;
            textBoxList.Text = dataGridView1.ProductVersion;
            textBoxIncome.Text = dataGridView1.ProductVersion;
            textBoxExp.Text = dataGridView1.ProductVersion;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}    