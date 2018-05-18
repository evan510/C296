﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokemonRunCode;

namespace PokemonRunApp
{
    public partial class MainWindow : Form
    {
        private Pokemon pokemon1;
        private Pokemon pokemon2;

        public string GymName { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            pokemon1 = new Pokemon(1, "小火龍", 57);
            pokemon2 = new Pokemon(4, "水箭龜", 65);
            Render();
        }

        private void Render()
        {
            pokemon1HpLabel.Text = string.Format("{0}/{1}", pokemon1.Hp, pokemon1.maxHp);
            pokemon2HpLabel.Text = string.Format("{0}/{1}", pokemon2.Hp, pokemon2.maxHp);
            if (pokemon1.Hp <= 0 || pokemon2.Hp <= 0)
            {
                gameTimer.Enabled = false;
                if (pokemon1.Hp > 0)
                {
                    MessageBox.Show("You Win!");
                    pokemon2PictureBox.Enabled = false;
                }
                else
                {
                    MessageBox.Show("You Lost");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pokemon2.Attack(pokemon1);
            Render();
        }

        private void pokemon2PictureBox2_Click(object sender, EventArgs e)
        {
            pokemon1.Attack(pokemon2);
            Render();
        }

        private void restarButton_Click(object sender, EventArgs e)
        {
            pokemon1.RestoreHp();
            pokemon2.RestoreHp();
            gameTimer.Enabled = true;
            Render();
        }
    }
}