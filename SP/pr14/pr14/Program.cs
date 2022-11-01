using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr14
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// ВАРИАНТ № А37/Б9
        /// 
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
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
