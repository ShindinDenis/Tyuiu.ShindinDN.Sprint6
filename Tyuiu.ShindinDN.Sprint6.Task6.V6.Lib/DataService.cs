﻿using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ShindinDN.Sprint6.Task6.V6.Lib
{
    public class DataService : ISprint6Task6V6
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);
                    foreach (string word in words)
                    {
                        if (word.Contains("b"))
                        {
                            resStr = resStr + " " + word;
                        }
                    }

                }
            }
            return resStr;
        }
    }
}
