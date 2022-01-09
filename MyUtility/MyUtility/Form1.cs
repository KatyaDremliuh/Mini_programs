using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace MyUtility
{
    public partial class MainForm : Form
    {
        private int count = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close(); // заставляет форму закрываться по нажатию "Выход"
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Программа ""Мои утилиты""
содержит ряд небольших программ,
которые могут пригодиться в жизни.
А главное, научить меня
основам программирования.", @"О программе");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            count++;
            lblCount.Text = count.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            count--;
            lblCount.Text = count.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            count = 0;
            lblCount.Text = count.ToString();
        }
    }
}
