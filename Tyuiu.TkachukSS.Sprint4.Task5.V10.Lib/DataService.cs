﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.TkachukSS.Sprint4.Task5.V10.Lib
{
    public class DataService : ISprint4Task5V10
    {
        public int Calculate(int[,] matrix)
        {
            int sum = 0;
            foreach (var item in matrix)
                if (item > 0)
                    sum += item;
            return sum;
        }
    }
}
