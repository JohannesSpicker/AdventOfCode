using System.IO;

namespace AdventOfCode._2022.Tools
{
    public static class InputReader
    {
        public static string   ReadInputFileOneString(string   path) => File.ReadAllText(path);
        public static string[] ReadInputFileStringArray(string path) => File.ReadAllLines(path);
    }
}