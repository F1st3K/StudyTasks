using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr15
{
    /*ВАРИАНТ № А22/Б9
1. Проверить истинность высказывания: "Данное целое положительное число является нечетным трехзначным числом".

2. С некоторого момента прошло N дней (N > 0). Сколько полных недель прошло за этот период?

3. Дан целочисленный массив, состоящий из N элементов (N > 0). 
    Проверить, чередуются ли в нем четные и нечетные числа. Если чередуются, то вывести 0,
    если нет, то вывести порядковый номер первого элемента, нарушающего закономерность.

4. Вводится строка, состоящая из цифр и символов английского алфавита. Длина строки может быть разной. 
    Вывести на экран произведение всех нечетных цифр этого числа.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Task03();
            Console.ReadKey();
        }

        static void Task01()
        {
            try
            {
                string pathInput = "Input1.txt";
                string pathOutput = "Output1.txt";
                string[] strings = File.ReadAllLines(pathInput);
                int Number = Convert.ToInt32(strings[0]);
                bool Result = false;

                if (Number <= 0)
                {
                    Console.WriteLine("Число оказалось не положительным...Читай описание задания...");
                    return;
                }

                if (Number >= 100 && Number < 1000 && Number % 2 != 0)
                    Result = true;
                File.WriteAllText(pathOutput, "Ответ: " + Result);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message +  "Кирл Вылерьевич moment...");
            }
        }

        static void Task02()
        {
            try
            {
                string pathInput = "Input2.txt";
                string pathOutput = "Output2.txt";
                string[] strings = File.ReadAllLines(pathInput);
                int Number = Convert.ToInt32(strings[0]);
                int Result = 0;

                if (Number <= 0)
                {
                    Console.WriteLine("Число оказалось не положительным...Читай описание задания...");
                    return;
                }

                Result = Number / 7;
                File.WriteAllText(pathOutput, "Ответ: " + Result);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "Кирл Вылерьевич moment...");
            }
        }

        static void Task03()
        {
            try
            {
                string pathInput = "Input3.txt";
                string pathOutput = "Output3.txt";
                string[] strings = File.ReadAllLines(pathInput);
                int[] Numbers = new int[strings.Length];
                int Result = 0;
                int State = 0;

                if (strings.Length <= 0)
                {
                    Console.WriteLine("в файле *Пусто*");
                    return;
                }

                for (int i = 0; i < strings.Length; i++)
                    Numbers[i] = Convert.ToInt32(strings[i]);

                for (int i = 0; i < Numbers.Length; i++)
                {
                    if (State == 0)
                    {
                        if (Numbers[i] < 0)
                        {
                            State = 2;
                            continue;
                        }
                        if (Numbers[i] > 0)
                        {
                            State = 1;
                            continue;
                        }
                        Result = i + 1;
                        break;
                    }
                    else if (State == 1)
                    {
                        if (!(Numbers[i] < 0))
                        {
                            Result = i + 1;
                            break;
                        }
                        State = 2;
                    }
                    else if (State == 2)
                    {
                        if (!(Numbers[i] > 0))
                        {
                            Result = i + 1;
                            break;
                        }
                        State = 1;
                    }

                }

                File.WriteAllText(pathOutput, "Ответ: " + Result);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "Кирл Вылерьевич moment...");
            }
        }

        static void Task04()
        {
            try
            {
                string pathInput = "Input4.txt";
                string pathOutput = "Output4.txt";
                string Sentence = File.ReadAllText(pathInput);
                int MullResult = 1;
                bool IsMullable = false;

                for (int i = 0; i < Sentence.Length; i++)
                {
                    if (char.IsDigit(Sentence[i]) && Convert.ToInt32(Sentence[i]) % 2 != 0)
                    {
                        MullResult *= Convert.ToInt32(Sentence[i].ToString());
                        IsMullable = true;
                    }
                }
                if (!IsMullable)
                    MullResult = 0;
                File.WriteAllText(pathOutput, "Ответ: " + MullResult);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "Кирл Вылерьевич moment...");
            }
        }
    }
}
