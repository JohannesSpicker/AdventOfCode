using System;
using AdventOfCode.Tools;

namespace AdventOfCode._2022
{
    public static class Day2
    {
        public static void PrintSolution1() => Console.WriteLine(Solution1());
        public static void PrintSolution2() => Console.WriteLine(Solution2());

        public static int Solution1()
        {
            string[] input = GetInput();

            int score = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string[] inputSplit = input[i].Split();
                score += GetScore(GetForm(inputSplit[0][0]), GetForm(inputSplit[1][0]));
            }

            return score;
        }

        public static int Solution2()
        {
            string[] input = GetInput();

            int score = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string[] inputSplit = input[i].Split();
                Form     opponent   = GetForm(inputSplit[0][0]);
                score += GetScore(opponent, GetMyForm(opponent, inputSplit[1][0]));
            }

            return score;

            Form GetMyForm(Form opponent, char result)
            {
                switch (result)
                {
                    case 'Y': return opponent;
                    case 'X':
                        switch (opponent)
                        {
                            case Form.Rock:     return Form.Scissors;
                            case Form.Paper:    return Form.Rock;
                            case Form.Scissors: return Form.Paper;
                        }

                        break;
                    case 'Z':
                        switch (opponent)
                        {
                            case Form.Rock:     return Form.Paper;
                            case Form.Paper:    return Form.Scissors;
                            case Form.Scissors: return Form.Rock;
                        }

                        break;
                }

                return Form.Scissors;
            }
        }

        private static string[] GetInput() =>
            InputReader.ReadInputFileStringArray(@"D:\GitRepos\AdventOfCode\AdventOfCode\2022\Day 2\Input.txt");

        private static Form GetForm(char c)
        {
            switch (c)
            {
                case 'A':
                case 'X':
                    return Form.Rock;
                case 'B':
                case 'Y':
                    return Form.Paper;
                case 'C':
                case 'Z':
                    return Form.Scissors;
            }

            return Form.Scissors;
        }

        private static int GetScore(Form opponent, Form me)
        {
            int score = 0;

            switch (me)
            {
                case Form.Rock:
                    score += 1;

                    break;
                case Form.Paper:
                    score += 2;

                    break;
                case Form.Scissors:
                    score += 3;

                    break;
            }

            if (opponent == me)
                return score + 3;

            switch (opponent)
            {
                case Form.Rock:
                    switch (me)
                    {
                        case Form.Paper:    return score + 6;
                        case Form.Scissors: return score;
                    }

                    break;
                case Form.Paper:
                    switch (me)
                    {
                        case Form.Rock:     return score;
                        case Form.Scissors: return score + 6;
                    }

                    break;
                case Form.Scissors:
                    switch (me)
                    {
                        case Form.Rock:  return score + 6;
                        case Form.Paper: return score;
                    }

                    break;
            }

            return score;
        }

        private enum Form
        {
            Rock,
            Paper,
            Scissors
        }
    }
}