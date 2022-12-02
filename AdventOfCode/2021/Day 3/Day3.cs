using System;
using System.Collections;
using System.Linq;
using AdventOfCode.Tools;

namespace AdventOfCode._2021
{
    public static class Day3
    {
        public static void PrintSolution1() => Console.WriteLine(Solution1());

        public static void PrintSolution2() => Console.WriteLine(Solution2());

        public static string Solution1()
        {
            string gammaString = GetGammaRate();

            long gamma   = long.Parse(gammaString);
            long epsilon = ~-gamma;

            //int epsilon = ~gamma;

            return gamma + "\n" + epsilon;
        }

        private static string GetGammaRate()
        {
            string[] report = GetInput();
            
            string solution = "";

            for (int i = 0; i < report[0].Length; i++)
                solution += report.Where(x => x[i] == '1').Count() < report.Length / 2f ? '0' : '1';

            return solution;
        }

        public static int Solution2() => -1;

        private static void bla()
        {
            //110101010010
            string[] thing =
                InputReader.ReadInputFileStringArray(@"D:\GitRepos\AdventOfCode\AdventOfCode\2021\Day 3\Input.txt");

            char blaa = thing[0][1];
        }

        private static string[] GetInput() =>
            InputReader.ReadInputFileStringArray(@"D:\GitRepos\AdventOfCode\AdventOfCode\2021\Day 3\Input.txt");
    }
}