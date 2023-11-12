using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TkachukSS.Sprint4.Task6.V2.Lib;
namespace Tyuiu.TkachukSS.Sprint4.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            string[] cars = new string[] { "Белый", "Черный", "Зеленый", "Синий", "Красный", "Желтый", "Фиолетовый" };
            string[] res = dataService.Calculate(cars), wait = { "Черный", "Зеленый", "Красный", "Желтый", "Фиолетовый" };
            Assert.AreEqual(wait, res);
        }
    }
}
