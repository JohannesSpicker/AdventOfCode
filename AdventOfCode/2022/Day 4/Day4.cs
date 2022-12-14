using System;
using AdventOfCode.Tools;

namespace AdventOfCode._2022
{
    public static class Day4
    {
        public static void PrintSolution1() => Console.WriteLine(Solution1());
        public static void PrintSolution2() => Console.WriteLine(Solution2());

        public static int Solution1()
        {
            //how many ranges do completely overlap?
            int overlaps = 0;

            foreach (string pair in GetInput())
            {
                string[] splitPair     = pair.Split(',');
                string[] splitStrings1 = splitPair[0].Split('-');
                string[] splitStrings2 = splitPair[1].Split('-');

                int[] range1 = new int[2] { int.Parse(splitStrings1[0]), int.Parse(splitStrings1[1]) };
                int[] range2 = new int[2] { int.Parse(splitStrings2[0]), int.Parse(splitStrings2[1]) };

                if ((range1[0]    <= range2[0] && range2[1] <= range1[1])
                    || (range2[0] <= range1[0] && range1[1] <= range2[1]))
                    overlaps++;
            }

            return overlaps;
        }

        public static int Solution2()
        {
            //how many ranges do overlap at all?
            int overlaps = 0;

            foreach (string pair in GetInput())
            {
                string[] splitPair     = pair.Split(',');
                string[] splitStrings1 = splitPair[0].Split('-');
                string[] splitStrings2 = splitPair[1].Split('-');

                int[] range1 = new int[2] { int.Parse(splitStrings1[0]), int.Parse(splitStrings1[1]) };
                int[] range2 = new int[2] { int.Parse(splitStrings2[0]), int.Parse(splitStrings2[1]) };

                if (!((range1[0]    < range2[0] && range1[1] < range2[0])
                      || (range2[0] < range1[0] && range2[1] < range1[0])))
                    overlaps++;
            }

            return overlaps;
        }

        private static string[] GetInput() =>
            InputReader.ReadInputFileStringArray(@"D:\GitRepos\AdventOfCode\AdventOfCode\2022\Day 4\Input.txt");
    }
}