using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode.Tools;

namespace AdventOfCode._2022
{
    public static class Day5
    {
        public static void PrintSolution1() => Console.WriteLine(Solution1());
        public static void PrintSolution2() => Console.WriteLine(Solution2());

        public static string Solution1()
        {
            IEnumerable<string> input  = GetOrderInput();
            List<char>[]        crates = StartingCrates();

            foreach (string orderString in input)
            {
                string[] splitOrder = orderString.Split(' ');

                Order order = new Order
                {
                    amount = int.Parse(splitOrder[1]),
                    from   = int.Parse(splitOrder[3]),
                    to     = int.Parse(splitOrder[5])
                };

                for (int i = 0; i < order.amount && 0 < crates[order.from].Count; i++)
                {
                    crates[order.to].Add(crates[order.from].Last());
                    crates[order.from].RemoveAt(crates[order.from].Count - 1);
                }
            }

            string solution = "";

            foreach (List<char> crate in crates)
                solution += crate.LastOrDefault();

            return solution;
        }

        public static string Solution2()
        {
            IEnumerable<string> input  = GetOrderInput();
            List<char>[]        crates = StartingCrates();

            foreach (string orderString in input)
            {
                string[] splitOrder = orderString.Split(' ');

                Order order = new Order
                {
                    amount = int.Parse(splitOrder[1]),
                    from   = int.Parse(splitOrder[3]),
                    to     = int.Parse(splitOrder[5])
                };

                List<char> from = crates[order.from];
                List<char> to   = crates[order.to];
                List<char> temp = new List<char>();

                for (int i = from.Count - order.amount; i < from.Count; i++)
                    temp.Add(from[i]);

                for (int i = 0; i < order.amount; i++)
                    from.RemoveAt(crates[order.from].Count - 1);

                foreach (char box in temp)
                    to.Add(box);
            }

            string solution = "";

            foreach (List<char> crate in crates)
                solution += crate.LastOrDefault();

            return solution;
        }

        private static List<char>[] StartingCrates() => new[]
        {
            new List<char>(), new List<char> { 'B', 'G', 'S', 'C' }, new List<char>
            {
                'T',
                'M',
                'W',
                'H',
                'J',
                'N',
                'V',
                'G'
            },
            new List<char> { 'M', 'Q', 'S' }, new List<char>
            {
                'B',
                'S',
                'L',
                'T',
                'W',
                'N',
                'M'
            },
            new List<char>
            {
                'J',
                'Z',
                'F',
                'T',
                'V',
                'G',
                'W',
                'P'
            },
            new List<char>
            {
                'C',
                'T',
                'B',
                'G',
                'Q',
                'H',
                'S'
            },
            new List<char>
            {
                'T',
                'J',
                'P',
                'B',
                'W'
            },
            new List<char>
            {
                'G',
                'D',
                'C',
                'Z',
                'F',
                'T',
                'Q',
                'M'
            },
            new List<char>
            {
                'N',
                'S',
                'H',
                'B',
                'P',
                'F'
            }
        };

        private static string[] GetInput() =>
            InputReader.ReadInputFileStringArray(@"D:\GitRepos\AdventOfCode\AdventOfCode\2022\Day 5\Input.txt");

        private static IEnumerable<string> GetOrderInput() => GetInput().Skip(10);

        private struct Order
        {
            public int amount;
            public int from;
            public int to;
        }
    }
}