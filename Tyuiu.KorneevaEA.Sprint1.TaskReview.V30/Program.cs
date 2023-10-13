using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KorneevaEA.Sprint1.TaskReview.V30.Lib;

namespace Tyuiu.KorneevaEA.Sprint1.TaskReview.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            double x; double y;
            Console.WriteLine("Введите значение x: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToInt32(Console.ReadLine());

            var res = ds.Calculate(x, y);

            Console.WriteLine("Результат: ");
            Console.ReadKey();
        }
    }
}
