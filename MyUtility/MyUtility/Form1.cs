using System;
using System.Windows.Forms;

namespace MyUtility
{
    public partial class MainForm : Form
    {
        private int _count;
        private readonly Random _random = new();

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
            _count++;
            lblCount.Text = _count.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            _count--;
            lblCount.Text = _count.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _count = 0;
            lblCount.Text = _count.ToString();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            int number = _random.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value) + 1);
            lblRandom.Text = number.ToString();

            // добавлять сгенерированные числа без повторок

            if (cbRandom.Checked)
            {
                int i = 0;

                while (tbRandom.Text.IndexOf(number.ToString(), StringComparison.Ordinal) != -1)
                {
                    number = _random.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value) + 1);
                    i++;

                    if (i > 1000)
                    {
                        break;
                    }
                }

                if (i <= 1000)
                {
                    tbRandom.AppendText(number + "\r\n"); // сгенерированные числа записать в textBox
                }
            }
            else // или с повторками
            {
                tbRandom.AppendText(number + "\r\n"); // сгенерированные числа записать в textBox
            }
        }

        private void btnRandomClear_Click(object sender, EventArgs e)
        {
            tbRandom.Clear();
        }

        private void btnRandomCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbRandom.Text);
        }

        private void tsmiInsertDate_Click(object sender, EventArgs e)
        {
            rtbNotepad.AppendText(DateTime.Now.ToShortDateString() + "\n");
        }

        private void tsmiInsertTime_Click(object sender, EventArgs e)
        {
            rtbNotepad.AppendText(DateTime.Now.ToShortTimeString() + "\n");
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            try
            {
                rtbNotepad.SaveFile("notepad.rtf"); // сохраняем в формате rtf
            }
            catch
            {
                MessageBox.Show("Ошибка при попытке сохранения");
            }
        }

        void LoadNotepad()
        {
            try
            {
                rtbNotepad.LoadFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Ошибка при загрузке");
            }
        }

        private void tsmiLoad_Click(object sender, EventArgs e)
        {
            LoadNotepad();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadNotepad();
        }
    }
}
