using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TkachukSS.Sprint4.Task0.VLib;
namespace Tyuiu.TkachukSS.Sprint4.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int[] nums = { 8, 9, 5, 4, 3, 2, 1, 0, 5, 7 };
            int res = dataService.GetMultOddArrEl(nums), wait = 30;
            Assert.AreEqual(wait, res);
        }
    }
}
