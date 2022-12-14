using System;
using System.Collections.Generic;
using AdventOfCode.Tools;

namespace AdventOfCode._2022
{
    public static class Day6
    {
        public static void PrintSolution1() => Console.WriteLine(Solution1());
        public static void PrintSolution2() => Console.WriteLine(Solution2());

        public static int Solution1()
        {
            // start of a packet is indicated by a sequence of four characters that are all different.
            //identify the first position where the four most recently received characters were all different.
            //Specifically, it needs to report the number of characters from the beginning of the buffer to the end of the first such four-character marker.
            //How many characters need to be processed before the first start -of -packet marker is detected?

            return FindFirstMarker(GetInput(), 4);
        }

        public static int Solution2() => FindFirstMarker(GetInput(), 14);

        private static int FindFirstMarker(string input, int length)
        {
            for (int i = 0; i < input.Length - length; i++)
                if (IsStartMarker(input.Substring(i, length)))
                    return i + length;

            return -1;
        }

        private static bool IsStartMarker(string subString)
        {
            List<char> comparison = new List<char>();

            foreach (char c in subString)
            {
                if (comparison.Contains(c))
                    return false;

                comparison.Add(c);
            }

            return true;
        }

        private static string GetInput() =>
            InputReader.ReadInputFileOneString(@"D:\GitRepos\AdventOfCode\AdventOfCode\2022\Day 6\Input.txt");
    }
}