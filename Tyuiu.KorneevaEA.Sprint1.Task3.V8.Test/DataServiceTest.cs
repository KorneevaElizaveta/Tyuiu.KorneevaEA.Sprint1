using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KorneevaEA.Sprint1.Task3.V8.Lib;

namespace Tyuiu.KorneevaEA.Sprint1.Task3.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double startAmount = 2500;
            double timeDays = 30;
            double procent = 20;
            double wait = 41.10;
            var res = ds.IncomeAmount(startAmount, timeDays, procent);
            Assert.AreEqual(wait, res);
        }
    }
}
