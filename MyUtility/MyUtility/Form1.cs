using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace MyUtility
{
    public partial class MainForm : Form
    {
        private int _count;
        private readonly Random _random;
        private readonly char[] _specialChars = { '%', '*', ')', '#', '$', '^', '&', '~' };
        private Dictionary<string, double> metrica;

        private const double Millimetre = 1;
        private const double Centimetre = 10;
        private const double Decimetre = 100;
        private const double Metre = 1000;
        private const double Kilometre = 1000000;
        private const double Mile = 1609344;

        private const double Gramme = 1;
        private const double Kilogramme = 1000;
        private const double Tonne = 1000000;
        private const double Libra = 453.6;
        private const double Ounce = 28.3;

        private readonly string[] _lengthName = { "mm", "cm", "dm", "m", "km", "mile" };
        private readonly double[] _lengthValue = { Millimetre, Centimetre, Decimetre, Metre, Kilometre, Mile };

        private readonly string[] _weightName = { "gm", "kg", "t", "lb", "oz" };
        private readonly double[] _weightValue = { Gramme, Kilogramme, Tonne, Libra, Ounce };

        public MainForm()
        {
            InitializeComponent();

            _random = new Random();

            metrica = new Dictionary<string, double>();
            FillDictionary(_lengthName, _lengthValue);
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close(); // заставляет форму закрываться по нажатию "Выход"
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Программа ""Мои утилиты""
содержит ряд небольших программ,
которые могут научить меня
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
                MessageBox.Show(@"Ошибка при попытке сохранения");
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
                MessageBox.Show(@"Ошибка при загрузке");
            }
        }

        private void tsmiLoad_Click(object sender, EventArgs e)
        {
            LoadNotepad();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadNotepad();
            clbPassword.SetItemChecked(0, true); // при загрузке формы будут выбраны сразу "цифры" для генератора паролей
            clbPassword.SetItemChecked(0, true); // и "прописные буквы"

            cbMetric.Text = cbMetric.Items[0].ToString(); // при загрузке формы будет выбрана сразу "Длина" для конвертера
        }

        private void btnCreatePassword_Click(object sender, EventArgs e)
        {
            // если никакие чекбоксы не выбраны
            if (clbPassword.CheckedItems.Count == 0)
            {
                return;
            }
            else
            {
                StringBuilder password = new();

                for (int i = 0; i < nudPasswordLength.Value; i++)
                {
                    int element = _random.Next(0, clbPassword.CheckedItems.Count);
                    string stringElement = clbPassword.CheckedItems[element].ToString();

                    switch (stringElement)
                    {
                        case "Цифры":
                            password.Append(_random.Next(10).ToString());
                            break;
                        case "Прописные буквы":
                            password.Append(Convert.ToChar(_random.Next(65, 88)));
                            break;
                        case "Строчные буквы":
                            password.Append(Convert.ToChar(_random.Next(97, 122)));
                            break;
                        default:
                            password.Append(_specialChars[_random.Next(_specialChars.Length)]);
                            break;
                    }
                }

                tbGeneratedPassword.Text = password.ToString();

                // скопировать в буфер обмена
                Clipboard.SetText(password.ToString());
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double metricaFrom = metrica[cbFrom.Text];
            double metricaTo = metrica[cbTo.Text];

            double numberToConvert = Convert.ToDouble(tbFrom.Text);
            tbTo.Text = (numberToConvert * metricaFrom / metricaTo).ToString("0.###", CultureInfo.InvariantCulture);
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            string temp = cbFrom.Text;
            cbFrom.Text = cbTo.Text;
            cbTo.Text = temp;
        }

        private void cbMetric_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbMetric.Text)
            {
                case "Длина":
                    SetMetrica(_lengthName, _lengthValue);
                    break;

                case "Вес":
                    SetMetrica(_weightName, _weightValue);
                    break;
            }
        }

        private void SetMetrica(string[] names, double[] values)
        {
            metrica.Clear();

            FillDictionary(names, values);

            SetNamesInCombobox(cbFrom, names);
            SetNamesInCombobox(cbTo, names);
        }

        private void SetNamesInCombobox(ComboBox cbx, string[] names)
        {
            cbx.Items.Clear();
            cbx.Items.AddRange(names);

            cbx.Text = names[0];
        }

        private void FillDictionary(string[] names, double[] values)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (!metrica.ContainsKey(names[i]))
                {
                    metrica.Add(names[i], values[i]);
                }
            }
        }
    }
}
