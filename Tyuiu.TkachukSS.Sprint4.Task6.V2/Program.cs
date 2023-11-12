using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TkachukSS.Sprint4.Task6.V2.Lib;
namespace Tyuiu.TkachukSS.Sprint4.Task6.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] colors = new string[] {"Белый", "Черный", "Зеленый", "Синий", "Красный", "Желтый", "Фиолетовый"};

            Console.Write("Массив: ");
            for (int i = 0; i < colors.Length; i++)
            {
                Console.Write(colors[i]);
                if (i != colors.Length - 1) { Console.Write(", "); }
            }

            Console.WriteLine("***************************************************************************");

            Console.WriteLine("****************************РЕЗУЛЬТАТ**************************************");

            string[] newarr = ds.Calculate(colors);
            Console.WriteLine();
            Console.WriteLine(newarr);
            Console.ReadKey();
        }
    }
}
