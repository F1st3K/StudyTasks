using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr11_SP_Goroh
{
    internal class Program
    {
        /*
        ВАРИАНТ № А29/Б2
        1. Даны целые положительные числа A и B (A < B). 
        Вывести все целые числа от A до B включительно; при этом каждое число должно выводиться столько раз, 
        каково его значение (например, число 3 выводится 3 раза).
        2. Задано целое положительное четырехзначное число N (N > 0).
        Найти разницу между суммой всех его цифр и произведением нечетных цифр.
        3. Проверить истинность высказывания: "Данное целое положительное число является нечетным трехзначным числом".
        4. Проверить истинность высказывания: "Квадратное уравнение A·x2 + B·x + C = 0
        с данными коэффициентами A (A не равно 0), B, C не имеет вещественных корней".
        5. Даны два целых положительных числа: D (день, от 1 до 31) и M (месяц, от 1 до 12),
        определяющие правильную дату не високосного года. Вывести значения D и M для даты, предшествующей указанной.*/
        static void Main(string[] args)
        {
            //Task01();
            //Task02();
            //Task03();
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
                Console.WriteLine("Number: ");
                A = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Number: ");
                B = Convert.ToInt32(Console.ReadLine());
                if (A >= B)
                {
                    Console.WriteLine("Number A >= B !!!");
                    goto Task01;
                }
                for (int i = A; i < B; i++)
                {
                    for (int j = 0; j < i; j++)
                        Console.Write("Number " + i);
                    Console.WriteLine();
                }

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
                int Summ = 0;
                int Mult = 1;
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
                bool isMult = false;
                for (int i = 0; i < 4; i++)
                {
                    Summ += mass[i];
                    if (mass[i] % 2 != 0)
                    {
                        Mult *= mass[i];
                        isMult = true;
                    }
                }
                if (!isMult)
                    Mult = 0;
                Result = (Summ) - (Mult);
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

                Console.WriteLine("Number: ");
                Number = Convert.ToInt32(Console.ReadLine());
                if (Number <= 0)
                {
                    Console.WriteLine("Number not null!!!");
                    goto Task03;
                }

                Result = (Number % 2 != 0) && (Number >= 100 && Number <1000);
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
                double D;

                Console.WriteLine("Number: ");
                A = Convert.ToDouble(Console.ReadLine());
                B = Convert.ToDouble(Console.ReadLine());
                C = Convert.ToDouble(Console.ReadLine());
                if (A == 0)
                {
                    Console.WriteLine("A not null");
                    goto Task04;
                }

                D = Math.Sqrt(B * B - 4 * A * C);
                Result = (D is double.NaN);
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
        }
    }
}
