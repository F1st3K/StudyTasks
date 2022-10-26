using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr12
{
    internal class Program
    {
        /*ВАРИАНТ № А22/Б9
        1. Даны два целых положительных числа: A, B. Проверить истинность высказывания: «Каждое из чисел A и B нечетное».
        2. Из пяти введенных целых положительных чисел найти два наибольших и вывести произведение этих двух наибольших чисел.
        3. Дан целочисленный массив, состоящий из N элементов (N > 0). 
        Проверить, чередуются ли в нем положительные и отрицательные числа. Если чередуются, то вывести значение 0,
        если нет, то вывести порядковый номер первого элемента, нарушающего закономерность.
        4. Дан целочисленный массив, состоящий из N элементов (N > 0).
        Найти сумму и произведение всех чисел из данного массива.
        5. Дан целочисленный массив, состоящий из N элементов (N > 0).
        Найти количество различных (не одинаковых) элементов в данном массиве.*/
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
                Console.WriteLine("Task01--------------------------------------------------------");
                int A, B;
                bool Result;
                Console.WriteLine("Number A: ");
                A = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Number B: ");
                B = Convert.ToInt32(Console.ReadLine());

                if (A <= 0 || B <= 0)
                {
                    Console.WriteLine("A or B low null");
                    goto Task01;
                }

                Result = (A % 2 != 0) && (B % 2 != 0);
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
                Console.WriteLine("Task02--------------------------------------------------------");
                int Number, Result;
                int Mull = 0;
                int[] mass = new int[4];

                Console.WriteLine("Number: ");
                Number = Convert.ToInt32(Console.ReadLine());
                if (Number < 1000 || Number >= 10000)
                {
                    Console.WriteLine("Number not 4value");
                    goto Task02;
                }

                for (int i = 0, j = 1000; i < 4; i++, j /= 10)
                {
                    mass[i] = (Number / j) % 10;
                }

                for (int i = 0; i < 4; i++)
                {
                    Summ += mass[i];
                }
                Result = (Summ) - (mass[0] * mass[3]);
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
                Console.WriteLine("Task03--------------------------------------------------------");
                int Number;
                bool Result;
                int[] mass = new int[4];

                Console.WriteLine("Number: ");
                Number = Convert.ToInt32(Console.ReadLine());
                if (Number < 1000 || Number >= 10000)
                {
                    Console.WriteLine("Number not 4value");
                    goto Task03;
                }

                for (int i = 0, j = 1000; i < 4; i++, j /= 10)
                {
                    mass[i] = (Number / j) % 10;
                }

                Result = (mass[0] * mass[1]) == (mass[2] * mass[3]);
                Console.WriteLine("Result: " + Result);
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
                Console.WriteLine("Task04--------------------------------------------------------");
                double A, B, C;
                bool Result;
                double x1, x2;

                Console.WriteLine("Number: ");
                A = Convert.ToDouble(Console.ReadLine());
                B = Convert.ToDouble(Console.ReadLine());
                C = Convert.ToDouble(Console.ReadLine());
                if (A == 0)
                {
                    Console.WriteLine("A not null");
                    goto Task04;
                }

                x1 = (-B + Math.Sqrt(B * B - 4 * A * C)) / (2 * A);
                x2 = (-B - Math.Sqrt(B * B - 4 * A * C)) / (2 * A);
                Result = (x1 == x2);
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
                Console.WriteLine("Task05--------------------------------------------------------");
                int Age;
                string Result = "";
                Console.WriteLine("Age: ");
                Age = Convert.ToInt32(Console.ReadLine());
                if (Age < 20 || Age > 69)
                {
                    Console.WriteLine("Age is not 20 ~ 69 !!!");
                    goto Task05;
                }
                switch (Age / 10)
                {
                    case 2: { Result += "Двадцать "; } break;
                    case 3: { Result += "Тридцать "; } break;
                    case 4: { Result += "Сорок "; } break;
                    case 5: { Result += "Пятьдесят "; } break;
                    case 6: { Result += "Шестьдесят "; } break;
                    default:
                        break;
                }
                switch (Age % 10)
                {
                    case 0: { Result += ""; } break;
                    case 1: { Result += "один "; } break;
                    case 2: { Result += "два "; } break;
                    case 3: { Result += "три "; } break;
                    case 4: { Result += "четыре "; } break;
                    case 5: { Result += "пять "; } break;
                    case 6: { Result += "шесть "; } break;
                    case 7: { Result += "семь "; } break;
                    case 8: { Result += "восемь "; } break;
                    case 9: { Result += "девять "; } break;
                    default:
                        break;
                }
                if (Age % 10 > 1 && Age % 10 < 5)
                    Result += "года";
                else if (Age % 10 == 1)
                    Result += "год";
                else
                    Result += "лет";

                Console.WriteLine("Result: " + Result);
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
