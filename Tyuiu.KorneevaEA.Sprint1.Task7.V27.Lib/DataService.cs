using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;


namespace Tyuiu.KorneevaEA.Sprint1.Task7.V27.Lib
{
    public class DataService : ISprint1Task7V27
    {
        public double Calculate(double x, double y)
        {
            return (Math.Cos(x * x) + Math.Sin(y * y)) / (Math.Sin(y) + 1) - (x * y - 12) / (15 + Math.Cos(x));
        }
    }
}
