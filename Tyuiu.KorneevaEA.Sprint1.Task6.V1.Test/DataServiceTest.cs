using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KorneevaEA.Sprint1.Task6.V1.Lib;

namespace Tyuiu.KorneevaEA.Sprint1.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string x = "1";
            string wait = "49";
            var res = ds.SymbolCode(x);
            Assert.AreEqual(wait, res);

        }
    }
}
