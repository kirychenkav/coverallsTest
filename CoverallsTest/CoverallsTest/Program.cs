using System;

namespace CoverallsTest
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(GetCurrentDateString());
        }

        public static string GetCurrentDateString()
        {
            return DateTime.Now.ToString("u");
        }
    }
}