﻿using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ShindinDN.Sprint6.Task5.V5.Lib
{
    public class DataService : ISprint6Task5V5
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (Convert.ToDouble(line) % 2 == 0)
                    {
                        len++;
                    }
                }
            }

            double[] numsArray = new double[len];

            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (Convert.ToDouble(line) % 2 == 0)
                    {
                        numsArray[index] = Convert.ToDouble(line);
                        index++;
                    }
                }

                return numsArray;
            }
        }
    }
}
