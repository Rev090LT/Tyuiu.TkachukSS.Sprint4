using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TkachukSS.Sprint4.Task5.V10.Lib;
namespace Tyuiu.TkachukSS.Sprint4.Task5.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество столбцов в массиве: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[rows, columns];
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    arr[i, j] = rnd.Next(-4, 7);
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Массив: \n");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");

            Console.WriteLine("****************************РЕЗУЛЬТАТ**************************************");

            Console.WriteLine("Сумма положительных элементов равна: ");
            int summa = ds.Calculate(arr);
            Console.WriteLine(summa);
            Console.ReadKey();
        }
    }
}
