using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode.Tools;

namespace AdventOfCode._2022
{
    public static class Day3
    {
        public static void PrintSolution1() => Console.WriteLine(Solution1());
        public static void PrintSolution2() => Console.WriteLine(Solution2());

        public static int Solution1()
        {
            string[] input = GetInput();

            //question is: find the item in both compartments, do addition.
            //there are no odds.

            //split
            //find intersection
            //map to priority
            //sum

            IEnumerable<IEnumerable<char>> rums = input.Select(str => str.Take(str.Length / 2));
            IEnumerable<IEnumerable<char>> rams = input.Select(str => str.Skip(str.Length / 2));

            //i got two iterators over (char)iterators
            //i want to intersect the relative char-iterators

            //var rumsrams = rums.Select() 

            List<IEnumerable<char>> fronts = rums.ToList();
            List<IEnumerable<char>> backs  = rams.ToList();

            List<char> sharedItems = new List<char>();

            for (int i = 0; i < fronts.Count; i++)
            {
                List<char> front = fronts[i].ToList();
                List<char> back  = backs[i].ToList();

                sharedItems.AddRange(front.Intersect(back));
            }

            return sharedItems.Sum(c => GetPriority(c)); }

        public static int Solution2()
        {
            string[] input = GetInput();

            int priorities = 0;

            for (int i = 0; i < input.Length; i = i + 3)
                priorities += GetPriority(input[i].Intersect(input[i + 1]).Intersect(input[i + 2]).First());

            return priorities;
        }

        private static int GetPriority(char c)
        {
            switch (c)
            {
                case 'a': return 1;
                case 'b': return 2;
                case 'c': return 3;
                case 'd': return 4;
                case 'e': return 5;
                case 'f': return 6;
                case 'g': return 7;
                case 'h': return 8;
                case 'i': return 9;
                case 'j': return 10;
                case 'k': return 11;
                case 'l': return 12;
                case 'm': return 13;
                case 'n': return 14;
                case 'o': return 15;
                case 'p': return 16;
                case 'q': return 17;
                case 'r': return 18;
                case 's': return 19;
                case 't': return 20;
                case 'u': return 21;
                case 'v': return 22;
                case 'w': return 23;
                case 'x': return 24;
                case 'y': return 25;
                case 'z': return 26;
                case 'A': return 27;
                case 'B': return 28;
                case 'C': return 29;
                case 'D': return 30;
                case 'E': return 31;
                case 'F': return 32;
                case 'G': return 33;
                case 'H': return 34;
                case 'I': return 35;
                case 'J': return 36;
                case 'K': return 37;
                case 'L': return 38;
                case 'M': return 39;
                case 'N': return 40;
                case 'O': return 41;
                case 'P': return 42;
                case 'Q': return 43;
                case 'R': return 44;
                case 'S': return 45;
                case 'T': return 46;
                case 'U': return 47;
                case 'V': return 48;
                case 'W': return 49;
                case 'X': return 50;
                case 'Y': return 51;
                case 'Z': return 52;
                default:  return 0;
            }
        }

        private static string[] GetInput() =>
            InputReader.ReadInputFileStringArray(@"D:\GitRepos\AdventOfCode\AdventOfCode\2022\Day 3\Input.txt");
    }
}