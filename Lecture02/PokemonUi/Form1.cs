using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonUi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Render();
        }

        public void Render()
        {
            EvolveButton.Enabled = int.Parse(PlayerCandyLabel.Text) >= int.Parse(PokemonEvolveCandyLabel.Text);
        }

        private void PowerUpButton_Click(object sender, EventArgs e)
        {
            int pokemonCp = int.Parse(PokemonCpLabel.Text);
            int pokemonMaxHp = int.Parse(PokemonMaxHpLabel.Text);
            int pokemonWeight = int.Parse(PokemonWeightLabel.Text);
            float pokemonHeight = float.Parse(PokemonHeightLlabel.Text);
            int playerStardust = int.Parse(PlayerStardustLabel.Text);
            int playerCandy = int.Parse(PlayerCandyLabel.Text);
            int pokemonPowerUpStardust = int.Parse(PokemonPowerUpStardustLabel.Text);
            int pokemonPowerUpCandy = int.Parse(PokemonPowerUpCandyLabel.Text);

            //PokemonPowerUp條件
            if (playerStardust >= pokemonPowerUpCandy && playerCandy >= pokemonPowerUpCandy)
            {
                PokemonCpLabel.Text = string.Format("{0}", pokemonCp + 100);
                PokemonMaxHpLabel.Text = string.Format("{0}", pokemonMaxHp + 50);
                PokemonWeightLabel.Text = string.Format("{0}", pokemonWeight + 10);
                PokemonHeightLlabel.Text = string.Format("{0}", (pokemonHeight + 3.70f).ToString("#.##"));
                PlayerStardustLabel.Text = string.Format("{0}", playerStardust -= pokemonPowerUpStardust);
                PlayerCandyLabel.Text = string.Format("{0}", playerCandy -= pokemonPowerUpCandy);
            }
            else
            {
                MessageBox.Show("星星沙子/糖果不夠囉!!!");
            };
        }

        private void EvolveButton_Click(object sender, EventArgs e)
        {
            int pokemonCp = int.Parse(PokemonCpLabel.Text);
            int pokemonMaxHp = int.Parse(PokemonMaxHpLabel.Text);
            int pokemonWeight = int.Parse(PokemonWeightLabel.Text);
            float pokemonHeight = float.Parse(PokemonHeightLlabel.Text);
            int playerCandy = int.Parse(PlayerCandyLabel.Text);
            int pokemonEvolveCandy = int.Parse(PokemonEvolveCandyLabel.Text);
            string pokemonName = PokemonNameLabel.Text;

            if (playerCandy < pokemonEvolveCandy) { EvolveButton.Enabled = false; }
            else if (playerCandy >= pokemonEvolveCandy)
            {
                PokemonCpLabel.Text = string.Format("{0}", pokemonCp + 1500);
                PokemonMaxHpLabel.Text = string.Format("{0}", pokemonMaxHp + 800);
                PokemonWeightLabel.Text = string.Format("{0}", pokemonWeight + 40);
                PokemonHeightLlabel.Text = string.Format("{0}", (pokemonHeight + 85.70f).ToString("#.##"));
                PlayerCandyLabel.Text = string.Format("{0}", playerCandy -= pokemonEvolveCandy);
                PokemonNameLabel.Text = "噴火龍";
                PokemonPictureBox.Image = Image.FromFile("..\\..\\Picture\\Charizard.png");
                if (playerCandy < pokemonEvolveCandy) { EvolveButton.Enabled = false; }
            }
        }
    }
}