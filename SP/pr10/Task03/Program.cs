using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    internal class Program
     {  /*Задание 08. Вычисление стоимости покупки некоторого количества яблок (по весу)
        Введите исходные данные:
        Цена одного килограмма яблок (руб.) - xx
        Вес яблок (кг) - xx.xx
        Стоимость покупки: xx.xx руб.*/
        static void Main(string[] args)
        {
            double Mass, PriceMass, Price;
            Console.WriteLine("Mass: ");
            Mass = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Price a mass: ");
            PriceMass = Convert.ToDouble(Console.ReadLine());
            Price = PriceMass * Mass;
            Console.WriteLine("Result: " + Convert.ToString(Price));
            Console.ReadKey();
        }
    }
}
