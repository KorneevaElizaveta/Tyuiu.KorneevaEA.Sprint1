using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KorneevaEA.Sprint1.TaskReview.V30.Lib;

namespace Tyuiu.KorneevaEA.Sprint1.TaskReview.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;

            var res = ds.Calculate(x, y);
            var wait = 12.283;
            Assert.AreEqual(wait, res);
        }
    }
}
