namespace Pokemonnnn_battleee
{
    public partial class Form1 : Form
    {
        Pokemon groudon;
        Pokemon Dialga;
        Pokemon Giratina;
        Pokemon arceus;
        Pokemon greninja;
        Pokemon Mewtwo;
        //Array of pokemon
        Pokemon[] pokemondex;
        Pokemon[] enemydex;
        public Form1()
        {
            InitializeComponent();

            pokemondex = new Pokemon[6];
            enemydex = new Pokemon[6];

            groudon = new Groudon();
            Dialga = new Dialga();
            Giratina = new Giratina();
            Mewtwo = new Mewtwo();
            greninja = new Greninja();
            arceus = new Arceus();

            pokemondex[0] = groudon;
            pokemondex[1] = Dialga;
            pokemondex[2] = Giratina;
            pokemondex[3] = arceus;
            pokemondex[4] = Giratina;
            pokemondex[5] = greninja;

            enemydex[0] = Mewtwo;
        }

        private void diaplayPokemon()
        {
            this.pictureBox1.Image = pokemondex[0].getImage();
            this.labelPokemonName.Text = pokemondex[0].getName();
            this.pictureBox2.Image = pokemondex[1].getImage();
            this.pictureBox3.Image = pokemondex[2].getImage();

            this.pictureBox7.Image = enemydex[0].getImage();

            this.textBoxATK.Text = pokemondex[0].getAtk().ToString();
            this.textBoxDEF.Text = pokemondex[0].getDef().ToString();
            this.textBoxHP.Text = pokemondex[0].getHP().ToString();
            this.textBoxSPD.Text = pokemondex[0].getSpd().ToString();

            this.textBoxEnemy.Text = enemydex[0].getHP().ToString();

            //if (pokemondex[0].getHP() <= 0)
            //{
            //    this.buttonATK.Enabled = false;
            //}
            //else {
            //    this.buttonATK.Enabled = true;
            //}
            this.buttonAtk.Enabled = pokemondex[0].getHP() > 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pokemon temp = pokemondex[0];
            pokemondex[0] = pokemondex[1];
            pokemondex[1] = temp;

            diaplayPokemon();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            diaplayPokemon();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void buttonATK_Click(object sender, EventArgs e)
        {
            pokemondex[0].attackPokemon(ref enemydex[0]);

            enemydex[0].attackPokemon(ref pokemondex[0]);

            diaplayPokemon();
        }
    }
}