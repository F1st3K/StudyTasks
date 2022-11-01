using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //1. Проверить истинность высказывания: "Данное целое положительное число является четным трехзначным числом".

        //2. Дано вещественное число A и целое число N(N > 0).
        //Вывести значение результата A в степени N: AN = A* A*...*A(число A перемножается N раз).

        //3. Вводится строка-предложение на английском языке.
        //Длина строки может быть разной. Определить и вывести слово,
        //содержащего наибольшее число символов 'd'.

        //4. Вводится строка, состоящая из слов разделенных точками.
        //Длина строки может быть разной.Сформировать и вывести подстроку, 
        //расположенную между второй и пятой точками исходной строки.
        //Если в строке менее пяти точек, то вывести всю исходную строку.
        private void runingTask01_Click(object sender, EventArgs e)
        {
            try
            {
                int Number = Convert.ToInt32(inputNumberTask01.Text);
                bool Result = false;
                if (Number <= 0)
                {
                    MessageBox.Show("Число оказалось не положительным...", "Читай описание задания...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (Number >= 100 && Number < 1000 && Number % 2 == 0)
                    Result = true;
                outputTask01.Text = "Ответ: " + Result;
                    
            }
            catch (Exception ex)
            { 
                 MessageBox.Show(ex.Message, "Кирл Вылерьевич moment...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void runingTask02_Click(object sender, EventArgs e)
        {
            try
            {
                double NumberA = Convert.ToDouble(inputATask02.Text);
                int NumberN = Convert.ToInt32(inputNTask02.Text);
                double Result;
                if (NumberN <= 0)
                {
                    MessageBox.Show("Число оказалось не положительным...", "Читай описание задания...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Result = Math.Pow(NumberA, NumberN);
                outputTask02.Text = "Ответ: " + Result;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Кирл Вылерьевич moment...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void runingTask03_Click(object sender, EventArgs e)
        {
            try
            {
                string Sentence = inputTask03.Text;
                string[] Words = Sentence.Split(' ');
                int MaxCounter = 0;
                string Result = "*nothing*";
                for (int i = 0; i < Words.Length; i++)
                {
                    int counter = 0;
                    for (int j = 0; j < Words[i].Length; j++)
                    {
                        if (Words[i][j] == 'd')
                            counter++;
                    }
                    if (counter > MaxCounter)
                    {
                        MaxCounter = counter;
                        Result = Words[i];
                    }
                }
                outputTask03.Text = "Ответ: " + Result;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Кирл Вылерьевич moment...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void runingTask04_Click(object sender, EventArgs e)
        {
            try
            {
                string Sentence = inputTask04.Text;
                string[] Words = Sentence.Split('.');
                string Result = "*nothing*";
                if (Words.Length < 5)
                    Result = Sentence;
                else
                    Result = Words[2] + "." + Words[3] + "." + Words[4];
                outputTask04.Text = "Ответ: " + Result;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Кирл Вылерьевич moment...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
