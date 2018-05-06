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
    public partial class PokemonUi : Form
    {
        private int pokemonCp = 133;
        private int pokemonHp = 30;
        private int pokemonMaxHp = 80;
        private float pokemonWeight = 60.0f;
        private float pokemonHeight = 90.0f;
        private int playerStardust = 1000;
        private int playerCandy = 50;
        private int pokemonPowerUpStardust = 100;
        private int pokemonPowerUpCandy = 3;
        private int pokemonEvolveCandy = 30;

        public PokemonUi()
        {
            InitializeComponent();
            PokemonCpLabel.Text = pokemonCp.ToString();
            PokemonHpLabel.Text = pokemonHp.ToString();
            PokemonMaxHpLabel.Text = pokemonMaxHp.ToString();
            PokemonWeightLabel.Text = pokemonWeight.ToString();
            PokemonHeightLlabel.Text = pokemonHeight.ToString();
            PlayerStardustLabel.Text = playerStardust.ToString();
            PlayerCandyLabel.Text = playerCandy.ToString();
            PokemonPowerUpStardustLabel.Text = pokemonPowerUpStardust.ToString();
            PokemonPowerUpCandyLabel.Text = pokemonPowerUpCandy.ToString();
            PokemonEvolveCandyLabel.Text = pokemonEvolveCandy.ToString();
            Render();
        }

        public void Render()
        {
            EvolveButton.Enabled = int.Parse(PlayerCandyLabel.Text) >= int.Parse(PokemonEvolveCandyLabel.Text);
        }

        private void PowerUpButton_Click(object sender, EventArgs e)
        {
            //PokemonPowerUp條件
            if (playerStardust >= pokemonPowerUpCandy && playerCandy >= pokemonPowerUpCandy)
            {
                //pokemonCp = pokemonCp + 100;
                //pokemonMaxHp = pokemonMaxHp + 50;
                //pokemonWeight = pokemonWeight + 10.0f;
                //pokemonHeight = pokemonHeight + 3.70f;

                PokemonCpLabel.Text = string.Format("{0}", pokemonCp += 100);
                PokemonMaxHpLabel.Text = string.Format("{0}", pokemonMaxHp += 50);
                PokemonWeightLabel.Text = string.Format("{0}", pokemonWeight += 10.0f);
                PokemonHeightLlabel.Text = string.Format("{0}", pokemonHeight += 3.70f);
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
            if (playerCandy < pokemonEvolveCandy) { EvolveButton.Enabled = false; }
            else if (playerCandy >= pokemonEvolveCandy)
            {
                PokemonCpLabel.Text = string.Format("{0}", pokemonCp += 1500);
                PokemonMaxHpLabel.Text = string.Format("{0}", pokemonMaxHp += 800);
                PokemonWeightLabel.Text = string.Format("{0}", pokemonWeight += 40);
                PokemonHeightLlabel.Text = string.Format("{0}", (pokemonHeight += 85.70f).ToString("#.##"));
                PlayerCandyLabel.Text = string.Format("{0}", playerCandy -= pokemonEvolveCandy);
                PokemonNameLabel.Text = "噴火龍";
                PokemonPictureBox.Image = Image.FromFile("..\\..\\Picture\\Charizard.png");
                Render();
            }
        }

        private void StardustPictureBox1_Click(object sender, EventArgs e)
        {
            PlayerStardustLabel.Text = string.Format("{0}", playerStardust += 500);
            Render();
        }

        private void CandyPictureBox1_Click(object sender, EventArgs e)
        {
            PlayerCandyLabel.Text = string.Format("{0}", playerCandy += 10);
            Render();
        }
    }
}