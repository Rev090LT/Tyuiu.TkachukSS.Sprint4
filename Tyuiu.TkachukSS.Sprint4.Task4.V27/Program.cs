using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TkachukSS.Sprint4.Task4.V27.Lib;
namespace Tyuiu.TkachukSS.Sprint4.Task4.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] nums = new int[5, 5] { { 4, 3, 9, 2, 2 },
                                          { 8, 4, 1, 4, 3},
                                          {3, 9, 2, 2, 5 },
                                          {4, 6, 8, 5, 6 },
                                          {1, 5, 2, 2, 5 } };


            Console.Write("Дан массив: \n");
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    Console.Write(nums[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("****************************РЕЗУЛЬТАТ**************************************");

            Console.WriteLine("Сумма нечётных элементов равна: ");
            int summ = ds.Calculate(nums);
            Console.WriteLine(summ);

            Console.ReadKey();
        }
    }
}