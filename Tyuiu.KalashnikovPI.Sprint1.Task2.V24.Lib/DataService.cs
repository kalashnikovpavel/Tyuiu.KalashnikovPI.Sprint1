﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KalashnikovPI.Sprint1.Task2.V24.Lib
{
    public class DataService : ISprint1Task2V24
    {
        public int CalculateDiffSquare(int value, int valueTwo)
        {
            return (value - valueTwo) * (value - valueTwo);
        }
    }
}
