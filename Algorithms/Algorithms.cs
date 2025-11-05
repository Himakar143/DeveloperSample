using System;
using System.Linq;

namespace DeveloperSample.Algorithms
{
    public static class Algorithms
    {
        public static int GetFactorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Negative Values Not Allowed");

            if (n <= 1)
                return 1;

            return n * GetFactorial(n - 1);
        }

        public static string FormatSeparators(params string[] items)
        {
            if (items == null || items.Length == 0)
                return string.Empty;

            if (items.Length == 1)
                return items[0];

            var result = items[0];
            for (int i = 1; i < items.Length - 1; i++)
            {
                result += ", " + items[i];
            }
            result += " and " + items[items.Length - 1];

            return result;
        }
    }
}