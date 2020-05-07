using System;

namespace CoverallsTest
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(GetCurrentDateString());
            Console.WriteLine(GetCurrentDateTimeString());
        }

        public static string GetCurrentDateString()
        {
            return DateTime.Now.ToString("d");
        }
        
        public static string GetCurrentDateTimeString()
        {
            return DateTime.Now.ToString("u");
        }
    }
}