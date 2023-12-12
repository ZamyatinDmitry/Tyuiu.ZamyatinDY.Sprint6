using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZamyatinDY.Sprint6.Task0.Lib;
namespace Tyuiu.ZamyatinDY.Sprint6.Task0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int x = 12;
            var res = ds.Calculate(x);
            double wait = 2546.4;
            Assert.AreEqual(res, wait);
        }
    }
}
