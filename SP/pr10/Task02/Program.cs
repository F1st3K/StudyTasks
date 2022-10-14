using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    internal class Program
    {   /*Задание 24. Пересчет расстояния из километров в мили (1 км - это 0,621 мили)
        Введите исходные данные:
        Введите расстояние в километрах - xx
        xx километров - это xxx.xx миль*/
        static void Main(string[] args)
        {
            double Kilometrs, Miles;
            Console.WriteLine("Kilometrs: ");
            Kilometrs = Convert.ToDouble(Console.ReadLine());
            Miles = Kilometrs * 0.621;
            Console.WriteLine("Result: " + Miles);
            Console.ReadKey();
        }
    }
}
