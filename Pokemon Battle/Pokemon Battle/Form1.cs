namespace Pokemon_Battle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pikachu pikachu = new Pikachu();
            this.labelPokemon.Text = pikachu.getName();
            this.pictureBox1.Image = pikachu.getImage();

            this.labelPokemon.Text = _483.getName();
            this.pictureBox1.Image = _483.getImage();
        }
    }
}