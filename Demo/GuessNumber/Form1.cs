using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumber
{
    public partial class Form1 : Form
    {
        public int[] numbers = new int[4]; //電腦給的數字
        public string[] inputNumber = new string[4];//玩家猜的數字
        public Random random = new Random();  //亂數
        private int a = 0;  //計算猜中多少A
        private int b = 0;  //計算猜中多少B
        public int z;  //統計猜的次數

        public Form1()
        {
            InitializeComponent();
            Render();
        }

        #region 畫面render

        private void Render()
        {
            //起始畫面就自動產生一組亂數
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 10);
                for (int j = 0; j < i;)
                {
                    if (numbers[j] == numbers[i])
                    {
                        numbers[i] = random.Next(1, 10);
                        j = 0;
                    }
                    else
                    {
                        j++;
                    }
                }
            }
        }

        #endregion 畫面render

        #region 猜數字按鈕

        private void chuckNumberButton_Click(object sender, EventArgs e)
        {
            int num = numbers.Length; //使用num代替猜數字最大字數 (就是4)

            //判定輸入的字數要有4碼
            if (inputNumberTextBox.Text.Length != numbers.Length)
            {
                MessageBox.Show(String.Format("請輸入{0}位數字", num.ToString()));
                return;
            }
            else
                //將輸入的數字放入陣列
                for (int i = 0; i < num; i++)
                {
                    inputNumber[i] = inputNumberTextBox.Text.Substring(i, 1);
                }
            //判定輸入的數字間不能有重覆
            if (inputNumber[0] == inputNumber[1] ||
                inputNumber[0] == inputNumber[2] ||
                inputNumber[0] == inputNumber[3] ||
                inputNumber[1] == inputNumber[2] ||
                inputNumber[1] == inputNumber[3] ||
                inputNumber[2] == inputNumber[3])
            {
                MessageBox.Show("請不要輸入重覆數字");
                return;
            }
            else { }

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if (numbers[i].ToString() == inputNumber[j] && i == j)
                    {
                        a++;
                    }
                    else if (numbers[i].ToString() == inputNumber[j] && i != j)
                    {
                        b++;
                    }
                }
            }

            if (a == num)
            {
                MessageBox.Show(String.Format("在第{0}次猜中了！", z += 1));
                guessNumberLabel.Text = "";
                for (int i = 0; i < numbers.Length; i++)
                {
                    guessNumberLabel.Text += numbers[i];
                }
                chuckNumberButton.Enabled = false;
            }
            else
            {
                guessListLabel.Text += String.Format("{2}. {0}A{1}B ", a, b, z += 1) + inputNumberTextBox.Text + "\r";
                a = 0;
                b = 0;
                MessageBox.Show("請繼續努力！");
            }
        }

        #endregion 猜數字按鈕

        #region 顯示答案

        private void AnswerButton_Click(object sender, EventArgs e)
        {
            guessNumberLabel.Text = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                guessNumberLabel.Text += numbers[i];
            }
        }

        #endregion 顯示答案

        #region 重新開始按鈕

        private void RestarButton_Click(object sender, EventArgs e)
        {
            Render();
            chuckNumberButton.Enabled = true;
            inputNumberTextBox.Text = "";
            guessListLabel.Text = "";
            guessNumberLabel.Text = "";
            a = 0;
            b = 0;
            z = 0;
        }

        #endregion 重新開始按鈕

        #region 輸入文字後按enter後執行chuck button

        private void InputNumberBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                chuckNumberButton.Focus();

                chuckNumberButton_Click(sender, e);

                inputNumberTextBox.Text = "";

                inputNumberTextBox.Focus();
            }
        }

        #endregion 輸入文字後按enter後執行chuck button
    }
}