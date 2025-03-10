using System;
using System.Collections.Generic;

namespace tech_lab1_task3
{
    public class Logic
    {
        public static List<string> CountLetters(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return null;
            }

            str = str.ToLower();
            str = str.Replace(" ", "");
            var results = new List<string>();
            int groupSize = 1;

            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == str[i - 1])
                {
                    groupSize++;
                }
                else
                {
                    if (groupSize > 1)
                    {
                        results.Add($"Количество подряд идущих букв '{str[i - 1]}': {groupSize}");
                    }
                    groupSize = 1;
                }
            }

            if (groupSize > 1)
            {
                results.Add($"Количество подряд идущих букв '{str[str.Length - 1]}': {groupSize}");
            }

            return results;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string sentence = Console.ReadLine();

            var counts = Logic.CountLetters(sentence);

            if (counts == null)
            {
                Console.WriteLine("Введена пустая строка.");
            }
            else if (counts.Count == 0)
            {
                Console.WriteLine("Нет подряд идущих одинаковых букв.");
            }
            else
            {
                foreach (var result in counts)
                {
                    Console.WriteLine(result);
                }
            }
        }
    }
}
