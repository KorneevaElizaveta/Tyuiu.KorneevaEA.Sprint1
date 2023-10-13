using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KorneevaEA.Sprint1.Task6.V1.Lib;

namespace Tyuiu.KorneevaEA.Sprint1.Task6.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string x;
            Console.WriteLine("Введите символ и нажмите <ENTER>");
            Console.WriteLine("Для завершения нажмите точку");
            x = Console.ReadLine();
            Console.WriteLine("РЕЗУЛЬТАТ: ");

            Console.WriteLine("Символ: " + x + " Код: " + ds.SymbolCode(x));
            {
                ConsoleKeyInfo cons = Console.ReadKey();
                while (cons.Key != ConsoleKey.Escape)
                {
                    cons = Console.ReadKey();
                }
            }
        }
    }
}
