﻿namespace _08._Letters_Change_Numbers
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            string[] words = GetInfo();
            double result = Engine(words);
            IO(result);
        }
        private static string[] GetInfo()
            => Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        private static double Engine(string[] words)
        {
            double result = default;
            foreach (var word in words)
            {
                char firstLetter = word[0];
                char lastLetter = word[word.Length - 1];
                double number = double.Parse(word.Substring(1, word.Length - 2));
                if (char.IsUpper(firstLetter))
                    number /= firstLetter - 64;
                else
                    number *= firstLetter - 96;
                if (char.IsUpper(lastLetter))
                    number -= lastLetter - 64;
                else
                    number += lastLetter - 96;
                result += number;
            }
            return result;
        }
        private static void IO(double result)
        {
            Console.WriteLine($"{result:f2}");
        }
    }
}
