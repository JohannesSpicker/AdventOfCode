using System.IO;

namespace AdventOfCode.Tools
{
    public static class InputReader
    {
        public static string   ReadInputFileOneString(string   path) => File.ReadAllText(path);
        public static string[] ReadInputFileStringArray(string path) => File.ReadAllLines(path);

        public static int[] ReadInputFileToIntArray(string path)
        {
            string[] strings = ReadInputFileStringArray(path);

            int[] numbers = new int[strings.Length];

            for (int i = 0; i < strings.Length; i++)
                numbers[i] = int.Parse(strings[i]);

            return numbers;
        }
    }
}