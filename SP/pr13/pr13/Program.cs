using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr13
{
    internal class Program
    {
        /*ВАРИАНТ № А22/Б9
        1. Дано целое положительное трехзначное число. В нем зачеркнули первую справа цифру и приписали ее слева. 
        Вывести полученное новое число.
        2. Дан целочисленный массив, состоящий из N элементов (N > 0). 
        После каждого отрицательного элемента массива вставить элемент с нулевым значением.
        3. Вводится строка, содержащая латинские буквы и круглые скобки. Длина строки может быть разной.
        Если скобки расставлены правильно (т. е. каждой открывающей скобки соответствует одна закрывающая скобка),
        то вывести число 0. В противном случае вывести или номер позиции,
        в которой расположена первая ошибочная закрывающая скобка, или, если закрывающих скобок не хватает, значение −1.
        4. Вводится строка, изображающая двоичную запись целого положительного числа. 
        Вывести строку, изображающую десятичную запись этого же числа.
        5. Вводится строка, состоящая из слов, разделенных подчеркиваниями (одним или несколькими).
        Длина строки может быть разной. Определить и вывести на экран самое длинное слово а так же размер этого слова.*/
        static void Main(string[] args)
        {
            Task01();
            Task02();
            Task03();
            Task04();
            Task05();
        }
        private static void Task01()
        {
        Task01:
            try
            {
                string Result, Number = Console.ReadLine();
                int IntNumber = Convert.ToInt32(Number);
                if (IntNumber < 100 || IntNumber >= 1000)
                {
                    Console.WriteLine("Num NOT 4VALUE");
                    goto Task01;
                }
                Result = Number.Substring(1, Number.Length-1) + Number.Substring(0, 1);
                Console.WriteLine("Result: " + Result);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Task01;
            }
        }
        private static void Task02()
        {
        Task02:
            try
            {
                string Result = "";
                int N = Convert.ToInt32(Console.ReadLine());
                if (N <= 0)
                {
                    Console.WriteLine("Num <= 0");
                    goto Task02;
                }
                int[] Mass = new int[N];
                for (int i = 0; i < Mass.Length; i++)
                {
                    Mass[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 0; i < Mass.Length; i++)
                {
                    Result += Convert.ToString(Mass[i]);
                    if (Mass[i] < 0)
                        Result += "0";
                }
                Console.WriteLine("Result: " + Result);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Task02;
            }
        }
        private static void Task03()
        {
        Task03:
            try
            {
                string Str = Console.ReadLine();
                int OpenBkt = 0, CloseBkt = 0;
                char[] Array = Str.ToCharArray();
                for (int i = 0; i < Array.Length; i++)
                {
                    if (Array[i] == '(')
                        OpenBkt++;
                    if (Array[i] == ')')
                        CloseBkt++;
                    if (CloseBkt > OpenBkt)
                    {
                        Console.WriteLine("Warning close ')' " + (i + 1));
                        return;
                    }
                }
                if (CloseBkt < OpenBkt)
                {
                    Console.WriteLine(-1);
                    return;
                }
                Console.WriteLine(0);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Task03;
            }
        }
        private static void Task04()
        {
        Task04:
            try
            {
                string Str = Console.ReadLine();
                int Result = Convert.ToInt32(Str, 2);
                Console.WriteLine("Result: " + Result);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Task04;
            }
        }
        private static void Task05()
        {
        Task05:
            try
            {
                string Result = "", Str = Console.ReadLine();
                string[] Array = Str.Split('_');
                for (int i = 0; i < Array.Length; i++)
                {
                    if (Array[i].Length > Result.Length)
                        Result = Array[i];
                }
                Console.WriteLine("Result: " + Result + " size: " + Result.Length);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Task05;
            }
        }
    }
}
