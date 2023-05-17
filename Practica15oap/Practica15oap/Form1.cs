//Form1.cs
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Practica15oap
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;
            comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox2.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            anwer.Text = "";
            textBox1.Text = "Первая часть числа";//подсказка
            textBox1.ForeColor = Color.Gray;
            textBox2.Text = "Вторая часть числа";//подсказка
            textBox2.ForeColor = Color.Gray;
            textBox3.Text = "Первая часть числа";//подсказка
            textBox3.ForeColor = Color.Gray;
            textBox4.Text = "Вторая часть числа";//подсказка
            textBox4.ForeColor = Color.Gray;

        }
        public bool cheakInt(string number)
        {
            try
            {
                int n = Convert.ToInt32(number);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool cheakCompNumber(string number)
        {
            int bookI = 0;
            for (int i = 0; i < number.Length; i++)
            {
                char n = number[i];
                if (char.IsDigit(n) == false)
                {
                    if (n != 'i' || bookI == 1)
                    {
                        return false;
                    }
                    if (n == 'i') bookI = 1;
                }
            }
            if(bookI == 0)
            {
                return false;
            }
            if (bookI > 1) return false;
            return true;
        }
        public bool cheakTextBox()
        {
            bool cheak = true;
            if(cheakInt(textBox1.Text) == false)
            {
                MessageBox.Show("Вы ввели неверно первую часть первого число", "Ошибка");
                cheak = false;
            }
            if (cheakInt(textBox3.Text) == false)
            {
                MessageBox.Show("Вы ввели неверно первую часть второго числа", "Ошибка");
                cheak = false;
            }
            if(cheakCompNumber(textBox2.Text) == false)
            {
                MessageBox.Show("Вы ввели неверно вторую часть первого числа", "Ошибка");
                cheak = false;
            }
            if (cheakCompNumber(textBox4.Text) == false)
            {
                MessageBox.Show("Вы ввели неверно вторую часть второго числа", "Ошибка");
                cheak = false;
            }
            return cheak;

        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox1.ForeColor = Color.Black;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = null;
            textBox2.ForeColor = Color.Black;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.Text = null;
            textBox3.ForeColor = Color.Black;
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            textBox4.Text = null;
            textBox4.ForeColor = Color.Black;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) //сложение
        {
            if (cheakTextBox())
            {
                string text2 = textBox2.Text;
                string text4 = textBox4.Text;
                if(comboBox1.SelectedIndex == 1)
                {
                    text2 = "-" + textBox2.Text;
                }
                if (comboBox2.SelectedIndex == 1)
                {
                    text4 = "-" + textBox4.Text;
                }
                ComplexNumbers complexNumbers = new ComplexNumbers(Convert.ToInt32(textBox1.Text), text2, Convert.ToInt32(textBox3.Text), text4);
                anwer.Text = complexNumbers.addition();

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) //вычитание
        {
            if (cheakTextBox())
            {
                string text2 = textBox2.Text;
                string text4 = textBox4.Text;
                if (comboBox1.SelectedIndex == 1)
                {
                    text2 = "-" + textBox2.Text;
                }
                if (comboBox2.SelectedIndex == 1)
                {
                    text4 = "-" + textBox4.Text;
                }
                ComplexNumbers complexNumbers = new ComplexNumbers(Convert.ToInt32(textBox1.Text), text2, Convert.ToInt32(textBox3.Text), text4);
                anwer.Text = complexNumbers.subtraction();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) //умножение
        {
            if (cheakTextBox())
            {
                string text2 = textBox2.Text;
                string text4 = textBox4.Text;
                if (comboBox1.SelectedIndex == 1)
                {
                    text2 = "-" + textBox2.Text;
                }
                if (comboBox2.SelectedIndex == 1)
                {
                    text4 = "-" + textBox4.Text;
                }
                ComplexNumbers complexNumbers = new ComplexNumbers(Convert.ToInt32(textBox1.Text), text2, Convert.ToInt32(textBox3.Text), text4);
                anwer.Text = complexNumbers.multiplication();
            }
        }
    }
}
