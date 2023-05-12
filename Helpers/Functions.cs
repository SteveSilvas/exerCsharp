using System;

namespace CSharp.Helpers
{
    public static class Functions
    {
        public static string ReadNonEmptyLine()
        {
            string? input = null;

            while (string.IsNullOrWhiteSpace(input))
            {
                input = Console.ReadLine();
            }

            return input;
        }
    }
}
