using Pokemons_battlesss.Properties;

namespace Pokemons_battlesss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     

        private void Form1_Load(object sender, EventArgs e)
        {
            Groudon groudon = new Groudon();
            this.labelPokemonName.Text = groudon.getName();
            this.pictureBox1.Image = groudon.getImage();
        }

    }
}