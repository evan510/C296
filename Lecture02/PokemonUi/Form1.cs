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

            PokemonCpLabel.Text = string.Format("{0}", PokemonCp + 100);
            PokemonMaxHpLabel.Text = string.Format("{0}", PokemonCp + 50);
            PokemonWeightLabel.Text = string.Format("{0}", PokemonCp + 10);
            PokemonHeightLlabel.Text = string.Format("{0}", PokemonCp + 3.30f);
        }
    }
}