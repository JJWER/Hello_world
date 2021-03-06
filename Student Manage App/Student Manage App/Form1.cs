namespace Student_Manage_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public object Encoding { get; private set; }

        private void openToolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV (*.csv) | *.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] readAllLine = File.ReadAllLines(openFileDialog.FileName);
                string readAllText = File.ReadAllText(openFileDialog.FileName);
                this.textBox1.Text = readAllText;
            }
        }

        private void saveToolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            string filepath = string.Empty;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV (*.csv) | *.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FileName != string.Empty)
                {
                    filepath = saveFileDialog.FileName;

                    //save file
                    File.WriteAllText(filepath, this.textBox1.Text, Encoding.UTF8);
                }
            }
        }
    }
}
