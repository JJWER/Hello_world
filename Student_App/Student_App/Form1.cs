namespace Student_App
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }
        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filepath = string.Empty;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV (*.csv) | *.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                if (saveFileDialog.FileName != string.Empty) {
                    filepath = saveFileDialog.FileName;

                }
            }

        }
    }
}