﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KorneevaEA.Sprint1.Task2.V19.Lib
{
    public class DataService : ISprint1Task2V19
    {
        public double ConvertInchToKm(int value)
        {

            double x = value;
            return x / 40;
        }
    }
}
