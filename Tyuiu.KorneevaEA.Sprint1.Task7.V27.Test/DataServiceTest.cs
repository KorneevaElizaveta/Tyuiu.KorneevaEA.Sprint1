using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KorneevaEA.Sprint1.Task7.V27.Lib;

namespace Tyuiu.KorneevaEA.Sprint1.Task7.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x = 30;
            double y = 30;
            DataService ds = new DataService();
            var res = Math.Round(ds.Calculate(x, y), 3);
            Assert.AreEqual(30.308, res);

        }
    }
}
