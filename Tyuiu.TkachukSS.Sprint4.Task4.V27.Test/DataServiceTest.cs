using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TkachukSS.Sprint4.Task4.V27.Lib;
namespace Tyuiu.TkachukSS.Sprint4.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int[,] numsArray = new int[,] { { 8, 8, 3, 4, 5 },
                                            { 8, 6, 6, 4, 6 },
                                            { 3, 6, 5, 3, 4 },
                                            { 5, 6, 3, 7, 5 },
                                            { 7, 8, 5, 6, 6 } };
            int res = dataService.Calculate(numsArray), wait = 51;
            Assert.AreEqual(wait, res);
        }
    }
}