using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode.Tools;

namespace AdventOfCode._2022
{
    public class Day1
    {
        public static int Solution1() => GetElfTotals(GetInput()).Max();
        public static int Solution2() => GetElfTotals(GetInput()).OrderByDescending(x => x).Take(3).ToArray().Sum();

        public static void PrintSolution1() => Console.WriteLine(Solution1());
        public static void PrintSolution2() => Console.WriteLine(Solution2());

        private static string[] GetInput() =>
            InputReader.ReadInputFileStringArray(@"D:\GitRepos\AdventOfCode\AdventOfCode\2022\Day 1\Input.txt");

        private static List<int> GetElfTotals(string[] calories)
        {
            List<int> elfTotals    = new List<int>();
            int       currentTotal = 0;

            for (int i = 0; i < calories.Length; i++)
            {
                string line = calories[i];

                if (line != "")
                    currentTotal += int.Parse(line);
                else
                {
                    elfTotals.Add(currentTotal);
                    currentTotal = 0;
                }
            }

            return elfTotals;
        }
    }
}