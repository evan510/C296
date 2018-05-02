using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICakulatorEx
{
    public partial class BMI : Form
    {
        public BMI()
        {
            InitializeComponent();
        }

        private void BMIbutton_Click(object sender, EventArgs e)
        {
            try
            {
                int height = int.Parse(heightTextBox.Text);
                float weight = float.Parse(WeightTextBox.Text);
                float bmi = weight / ((height / 100.0f) * (height / 100.0f));

                MessageBox.Show(string.Format("BMI:{0}", bmi.ToString("#.##")));
            }
            catch
            {
                MessageBox.Show(string.Format("輸入有問題唷"));
                heightTextBox.Focus();
                return;
            }
        }
    }
}