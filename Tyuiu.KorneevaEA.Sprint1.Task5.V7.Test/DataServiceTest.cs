using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KorneevaEA.Sprint1.Task5.V7.Lib;

namespace Tyuiu.KorneevaEA.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x = 90;
            DataService ds = new DataService();
            double res = ds.AngleToHoursMinutes(x);

            int result = Convert.ToInt32(res);

            int wait = 3;
            Assert.AreEqual(wait, result);
        }
    }
}
