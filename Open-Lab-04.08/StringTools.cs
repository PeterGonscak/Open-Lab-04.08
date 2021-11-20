using System;

namespace Open_Lab_04._08
{
    public class StringTools
    {
        public string[] IsFourLetters(string[] strings)
        {
            int a = 0;
            for (int i = 0; i < strings.Length; i++)
                if (strings[i].Length == 4)
                    a++;
            string[] filter = new string[a];
            a = 0;
            for (int i = 0; i < strings.Length; i++)
                if (strings[i].Length == 4)
                {
                    filter[a] = strings[i];
                    a++;
                }
            return filter;
        }
    }
}
