using System;
using System.Collections.Generic;
using AdventOfCode.Tools;

namespace AdventOfCode._2021
{
    public class Day2
    {
        public static void PrintSolution1() => Console.WriteLine(Solution1());

        public static void PrintSolution2() => Console.WriteLine(Solution2());

        private static int Solution1()
        {
            List<CourseCommand> commands = GetCourseCommands();

            //add input to pos
            SubmarinePosition pos = new SubmarinePosition();

            foreach (CourseCommand command in commands)
                switch (command.direction)
                {
                    case "forward":
                        pos.horizontal += command.magnitude;

                        break;
                    case "down":
                        pos.depth += command.magnitude;

                        break;
                    case "up":
                        pos.depth -= command.magnitude;

                        break;
                }

            return pos.horizontal * pos.depth;
        }

        private static int Solution2()
        {
            List<CourseCommand> commands = GetCourseCommands();

            SubmarinePosition pos = new SubmarinePosition();
            int               aim = 0;

            foreach (CourseCommand command in commands)
                switch (command.direction)
                {
                    case "forward":
                        pos.horizontal += command.magnitude;
                        pos.depth      += aim * command.magnitude;

                        break;
                    case "down":
                        aim += command.magnitude;

                        break;
                    case "up":
                        aim -= command.magnitude;

                        break;
                }

            return pos.horizontal * pos.depth;
        }

        private static List<CourseCommand> GetCourseCommands()
        {
            //get input
            string[] course = GetCourse();

            //format input
            List<CourseCommand> commands = new List<CourseCommand>();

            foreach (string command in course)
            {
                string[] split = command.Split();
                commands.Add(new CourseCommand(split[0], int.Parse(split[1])));
            }

            return commands;
        }

        private static string[] GetCourse() =>
            InputReader.ReadInputFileStringArray(@"D:\GitRepos\AdventOfCode\AdventOfCode\2021\Day 2\Input.txt");

        private struct SubmarinePosition
        {
            public int horizontal;
            public int depth;
        }

        private struct CourseCommand
        {
            public CourseCommand(string direction, int magnitude)
            {
                this.direction = direction;
                this.magnitude = magnitude;
            }

            public string direction;
            public int    magnitude;
        }
    }
}