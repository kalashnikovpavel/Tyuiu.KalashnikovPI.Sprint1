﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KalashnikovPI.Sprint1.Task4.V2.Lib
{
    public class DataService : ISprint1Task4V2
    {
        public double Calculate(double x, double y)
        {
            var res = 1 / (Math.Sqrt(x+2*y));
            return res;
        }
    }
}
