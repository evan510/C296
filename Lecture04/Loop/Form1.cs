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
        private int[] randomArray = new int[2];
        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void GameStarButton_Click(object sender, EventArgs e)
        {
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
                //Controls.Find("NumberLabel" + i.ToString(), false)[0].Text = randomArray[i].ToString();
            }
            NumberLabel0.Text = "????";
            //string.Format("{0} {1}",
            //randomArray[0],
            //randomArray[1]);
            //randomArray[2],
            //randomArray[3]);
        }

        private void CheckBotton_Click(object sender, EventArgs e)
        {
        }
    }
}