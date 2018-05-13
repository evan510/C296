using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GameStarButton_Click(object sender, EventArgs e)
        {
            int[] randomArray = new int[4];
            Random rnd = new Random();

            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = rnd.Next(0, 9);
                for (int j = 0; j < i;)
                {
                    if (randomArray[j] == randomArray[i])
                    {
                        randomArray[i] = rnd.Next(0, 9);
                        j = 0;
                    }
                    else
                    {
                        j++;
                    }
                }
                Controls.Find("NumberLabel" + i.ToString(), false)[0].Text = randomArray[i].ToString();
            }
        }

        private int ChkNumber0;
        private int ChkNumber1;
        private int ChkNumber2;
        private int ChkNumber3;

        private void render()
        {
        }

        private void CheckBotton_Click(object sender, EventArgs e)
        {
            int[] Number = new int[4];
            Number[0] = ChkNumber0;
            Number[1] = ChkNumber0;
            Number[2] = ChkNumber0;
            Number[3] = ChkNumber0;
            CheckNumberBox0.Text = ChkNumber0.ToString();
            CheckNumberBox1.Text = ChkNumber1.ToString();
            CheckNumberBox2.Text = ChkNumber2.ToString();
            CheckNumberBox3.Text = ChkNumber3.ToString();

            if (NumberLabel0.Text == CheckNumberBox1.Text)
            {
            }
        }
    }
}