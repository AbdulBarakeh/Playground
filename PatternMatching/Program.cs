using System.Text.RegularExpressions;

namespace PatternMatching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var count = Matching.Count("aabbaabbaa", "aa");
            var contains = Matching.Contains("aabbaabbaa", "aa");
            Console.WriteLine(count);
            Console.WriteLine(contains);
        }
    }

    public static class Matching
    {
        public static bool Contains(string pattern, string match)
        {
            return pattern.Contains(match);
        }

        public static int Count(string pattern, string match)
        {
            int count = 0;
            if (pattern.Contains(match))
            {
                count = Regex.Matches(pattern, match).Count;
                return count;
            }
            return count;
        }
    }
}