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
                int LowValue = 0, Number = 5, Result;
                int Mull = 1;
                int[] mass = new int[Number];

                for (int i = 0; i < mass.Length; i++)
                {
                    mass[i] = Convert.ToInt32(Console.ReadLine());
                    if (mass[i] <= 0)
                    {
                        Console.WriteLine("Number low null");
                        goto Task02;
                    }
                }
                for (int i = 0; i < mass.Length; i++)
                {
                    for (int j = 0; j < mass.Length; j++)
                    {
                        if (mass[i] < mass[j])
                        {
                            LowValue = mass[i];
                            mass[i] = mass[j];
                            mass[j] = LowValue;
                        }
                    }
                }
                Mull = mass[0] * mass[1]; 
                Result = Mull;
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
                int Switch = 0, Result;
                int Number = Convert.ToInt32(Console.ReadLine());
                if (Number <= 0)
                {
                    Console.WriteLine("Number low null");
                    goto Task03;
                }
                int[] mass = new int[Number];

                for (int i = 0; i < mass.Length; i++)
                {
                    mass[i] = Convert.ToInt32(Console.ReadLine());
                }

                if (mass[0] % 2 != 0)
                    Switch = 1;
                else if (mass[0] % 2 == 0)
                    Switch = 2;

                for (int i = 1; i < mass.Length; i++)
                {
                    if (Switch == 1)
                    {
                        if (mass[i] % 2 != 0)
                        {
                            Console.WriteLine("Eror in " + i + 1);
                            return;
                        }
                        Switch = 2;
                    }
                    else if (Switch == 2)
                    {
                        if (mass[i] % 2 == 0)
                        {
                            Console.WriteLine("Eror in " + i + 1);
                            return;
                        }
                        Switch = 2;
                    }
                }
                Result = 0;
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
                int Summ = 0, Mull = 1;
                string Result;
                int Number = Convert.ToInt32(Console.ReadLine());
                if (Number <= 0)
                {
                    Console.WriteLine("Number low null");
                    goto Task04;
                }
                int[] mass = new int[Number];

                for (int i = 0; i < mass.Length; i++)
                {
                    mass[i] = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = 0; i < mass.Length; i++)
                {
                    Summ += mass[i];
                    Mull *= mass[i];
                }

                Result = ("Summ = "+Summ+"; Mull = "+Mull+";");
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
                int Result = 0;
                int Number = Convert.ToInt32(Console.ReadLine());
                if (Number <= 0)
                {
                    Console.WriteLine("Number low null");
                    goto Task05;
                }
                int[] mass = new int[Number];

                for (int i = 0; i < mass.Length; i++)
                {
                    mass[i] = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = 0; i < mass.Length; i++)
                {
                    int counter = 0;
                    for (int j = 0; j < mass.Length; j++)
                    {
                        if (mass[i] == mass[j])
                            counter++;
                    }
                    if (counter == 1)
                        Result++;
                }

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
