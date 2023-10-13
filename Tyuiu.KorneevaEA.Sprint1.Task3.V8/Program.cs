using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KorneevaEA.Sprint1.Task3.V8.Lib;

namespace Tyuiu.KorneevaEA.Sprint1.Task3.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Корнеева Е.А. | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы основного присваивания.                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнила: Корнеева Елизавета Андреевна | АСОиУб-23-3                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double procent;
            double timeDays;
            double startAmount = 2500;


            Console.WriteLine("Введите % годовых:");
            procent = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите время хранения (в днях):");
            timeDays = Convert.ToDouble(Console.ReadLine());

            double summa = 2500 + Math.Round(ds.IncomeAmount(startAmount, procent, timeDays), 2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Доход: " + Math.Round(ds.IncomeAmount(startAmount, procent, timeDays), 2) + ";  Сумма по окончанию срока вклада: " + summa);


            Console.ReadLine();
        }
    }
}
