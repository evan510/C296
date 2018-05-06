using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICakulator
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            int height = 0;
            float weight = 0.0f;
            float bmi = 0.0f;

            try
            {
                height = int.Parse(HeightTextBox.Text);
            }
            catch
            {
                MessageBox.Show("請輸入身高!!");
                HeightTextBox.Text = "";
                HeightTextBox.Focus();
                return;
            }

            try
            {
                weight = float.Parse(WeightTextBox.Text);
            }
            catch
            {
                MessageBox.Show("請輸入體重!!");
                WeightTextBox.Text = "";
                WeightTextBox.Focus();
                return;
            }

            bmi = weight / ((height / 100.0f) * (height / 100.0f));
            //TODO 如果bmi大於24 或 bmi 小於 18 不健康

            //TODO 顯示不健康的提示

            //TODO 不然顯示健康的提示
            if (bmi >= 18.5 && bmi <= 24.9)
            {
                MessageBox.Show(string.Format("BMI:{0}", bmi.ToString("#.##")));
                BmiLabel.Text = (BmiLabel.Text + bmi.ToString("#.##"));
                StatusLabel.Text = (StatusLabel.Text + "非常健康");
            }
            else
            {
                MessageBox.Show(string.Format("BMI:{0}", bmi.ToString("#.##")));
                BmiLabel.Text = (BmiLabel.Text + bmi.ToString("#.##"));
                StatusLabel.Text = (StatusLabel.Text + "不健康唷");
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
        }
    }
}