﻿using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ShindinDN.Sprint6.Task2.V29.Lib
{
    public class DataService : ISprint6Task2V29
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            int x;
            for (x = startValue; x <= stopValue; x++)
            {
                double del = (2 * x - 1);
                if (del == 0)
                {
                    y = 0;
                }
                else
                y = Math.Round(((2 * Math.Cos(x) + 2) / del) + Math.Cos(x) - 5 * x + 3, 2);
                valueArray[count] = y;
                count++;
            }

            return valueArray;
        }
    }
}
