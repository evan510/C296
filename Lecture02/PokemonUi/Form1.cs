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
        }

        private void PowerUpButton_Click(object sender, EventArgs e)
        {
            int PokemonCp = int.Parse(PokemonCpLabel.Text);
            int PokemonMaxHp = int.Parse(PokemonMaxHpLabel.Text);
            int PokemonWeight = int.Parse(PokemonWeightLabel.Text);
            float PokemonHeight = float.Parse(PokemonHeightLlabel.Text);
            int PlayerStardust = int.Parse(PlayerStardustLabel.Text);
            int PlayerCandy = int.Parse(PlayerCandyLabel.Text);
            int PokemonPowerUpStardust = int.Parse(PokemonPowerUpStardustLabel.Text);
            int PokemonPowerUpCandy = int.Parse(PokemonPowerUpCandyLabel.Text);

            //PokemonPowerUp條件
            if (PlayerStardust >= PokemonPowerUpCandy && PlayerCandy >= PokemonPowerUpCandy)
            {
                PokemonCpLabel.Text = string.Format("{0}", PokemonCp + 100);
                PokemonMaxHpLabel.Text = string.Format("{0}", PokemonMaxHp + 50);
                PokemonWeightLabel.Text = string.Format("{0}", PokemonWeight + 10);
                PokemonHeightLlabel.Text = string.Format("{0}", (PokemonHeight + 3.70f).ToString("#.##"));
                PlayerStardustLabel.Text = string.Format("{0}", PlayerStardust -= PokemonPowerUpStardust);
                PlayerCandyLabel.Text = string.Format("{0}", PlayerCandy -= PokemonPowerUpCandy);
            }
            else
            {
                MessageBox.Show("星星沙子/糖果不夠囉!!!");
            };
        }

        private void EvolveButton_Click(object sender, EventArgs e)
        {
            int PokemonCp = int.Parse(PokemonCpLabel.Text);
            int PokemonMaxHp = int.Parse(PokemonMaxHpLabel.Text);
            int PokemonWeight = int.Parse(PokemonWeightLabel.Text);
            float PokemonHeight = float.Parse(PokemonHeightLlabel.Text);
            int PlayerCandy = int.Parse(PlayerCandyLabel.Text);
            int PokemonEvolveCandy = int.Parse(PokemonEvolveCandyLabel.Text);
            string PokemonName = PokemonNameLabel.Text;

            if (PlayerCandy < PokemonEvolveCandy) { EvolveButton.Enabled = false; }
            else if (PlayerCandy >= PokemonEvolveCandy)
            {
                PokemonCpLabel.Text = string.Format("{0}", PokemonCp + 1500);
                PokemonMaxHpLabel.Text = string.Format("{0}", PokemonMaxHp + 800);
                PokemonWeightLabel.Text = string.Format("{0}", PokemonWeight + 40);
                PokemonHeightLlabel.Text = string.Format("{0}", (PokemonHeight + 85.70f).ToString("#.##"));
                PlayerCandyLabel.Text = string.Format("{0}", PlayerCandy -= PokemonEvolveCandy);
                PokemonNameLabel.Text = "噴火龍";
                PokemonPictureBox.Image = Image.FromFile("..\\..\\Picture\\Charizard.png");
                if (PlayerCandy < PokemonEvolveCandy) { EvolveButton.Enabled = false; }
            }
        }
    }
}