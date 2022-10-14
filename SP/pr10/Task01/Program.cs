using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    internal class Program
    {
        /*Задание 09. Вычисление площади треугольника, если известна длина основания и высота
        Введите исходные данные:
        Основание (см) - xx.xx
        Высота (см) - xxd
        Площадь треугольника: xx.xx кв.см.*/
        static void Main(string[] args)
        {
            double Found, Height, Square;
            Console.WriteLine("Foundd: ");
            Found = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Height: ");
            Height = Convert.ToDouble(Console.ReadLine());
            Square = Found * Height / 2;
            Console.WriteLine("Result: "+ Square);
            Console.ReadKey();
        }
    }
}
