using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr11
{
    internal class Program
    {
        /*
         ВАРИАНТ № А22/Б9
        1. Даны пять целых ненулевых положительных чисел. Найти сумму двух наименьших чисел.
        2. Задано целое положительное четырехзначное число N (N > 0). 
        Найти разницу между суммой всех его цифр и произведением первой и последней цифры.
        3. Проверить истинность высказывания: "Сумма двух первых цифр 
        данного четырехзначного целого положительного числаравна сумме двух его последних цифр".
        4. Проверить истинность высказывания: "Квадратное уравнение A·x2 + B·x + C = 0 
        с данными коэффициентами A (A не равно 0), B, C имеет ровно один вещественный корень".
        5. Дано целое положительное число в диапазоне от 20 до 69, определяющее возраст (в годах). 
        Вывести строку-описание указанного возраста, обеспечив правильное согласование числа со словом «год»,
        например: 20 - «двадцать лет», 32 - «тридцать два года», 41 - «сорок один год».*/
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
                int MinValue, MinValuePost, Result;
                int[] mass = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Number " + (i+1) + ": ");
                    mass[i] = Convert.ToInt32(Console.ReadLine());
                    if (mass[i] == 0)
                    {
                        Console.WriteLine("Number is null!!!");
                        goto Task01;
                    }    
                }

                MinValue = mass[0];
                for (int i = 0; i < 5; i++)
                {
                    if (mass[i] < MinValue)
                        MinValue = mass[i];
                }

                MinValuePost = mass[1];
                for (int i = 0; i < 5; i++)
                {
                    if (mass[i] < MinValuePost && mass[i] != MinValue)
                        MinValuePost = mass[i];
                }

                Result = MinValue + MinValuePost;
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
                int Summ = 0;
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

                for (int i = 0; i < 4 ; i++)
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

                x1 = (-B + Math.Sqrt(B*B - 4 * A * C)) / (2*A);
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
                switch (Age/10)
                {
                    case 2: { Result += "Двадцать ";    } break;
                    case 3: { Result += "Тридцать ";    } break;
                    case 4: { Result += "Сорок ";       } break;
                    case 5: { Result += "Пятьдесят ";   } break;
                    case 6: { Result += "Шестьдесят ";  } break;
                    default:
                        break;
                }
                switch (Age%10)
                {
                    case 0: { Result += "";         } break;
                    case 1: { Result += "один ";    } break;
                    case 2: { Result += "два ";     } break;
                    case 3: { Result += "три ";     } break;
                    case 4: { Result += "четыре ";  } break;
                    case 5: { Result += "пять ";    } break;
                    case 6: { Result += "шесть ";   } break;
                    case 7: { Result += "семь ";    } break;
                    case 8: { Result += "восемь ";  } break;
                    case 9: { Result += "девять ";  } break;
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
