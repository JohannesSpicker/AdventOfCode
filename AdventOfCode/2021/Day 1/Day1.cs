using System;
using System.Collections.Generic;
using AdventOfCode.Tools;

namespace AdventOfCode._2021
{
    public static class Day1
    {
        public static int Solution1() => DepthIncreases(GetMeasurements());

        public static int Solution2()
        {
            int[] measurements = GetMeasurements();

            List<int> measurementWindows = new List<int>();

            for (int i = 0; i < measurements.Length - 2; i++)
                measurementWindows.Add(measurements[i] + measurements[i + 1] + measurements[i + 2]);

            return DepthIncreases(measurementWindows.ToArray());
        }

        private static int DepthIncreases(int[] measurements)
        {
            int depthIncreases = 0;

            for (int i = 0; i < measurements.Length - 1; i++)
                if (measurements[i] < measurements[i + 1])
                    depthIncreases++;

            return depthIncreases;
        }

        public static void PrintSolution1() => Console.WriteLine(Solution1());
        public static void PrintSolution2() => Console.WriteLine(Solution2());

        private static int[] GetMeasurements() =>
            InputReader.ReadInputFileToIntArray(@"D:\GitRepos\AdventOfCode\AdventOfCode\2021\Day 1\Input.txt");
    }
}