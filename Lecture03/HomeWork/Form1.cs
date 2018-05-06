using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class homeWork : Form
    {
        public homeWork()
        {
            InitializeComponent();
        }

        private void CheckMailButton_Click(object sender, EventArgs e)
        {
            string mail = MailTextBox.Text;
            int atPosition = mail.IndexOf("@");
            int dotPosition = mail.IndexOf(".");
            if ((atPosition > 0) && (atPosition < dotPosition) && (dotPosition < mail.Length - 2))
            {
                MessageBox.Show("這是合法的");
            }
            else
            {
                MessageBox.Show("這是假的");
            }
        }
    }
}