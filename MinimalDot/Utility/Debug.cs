using System;

namespace ConsoleApp1
{
    public class Debug
    {
        public static void Log(string s, ConsoleColor color = ConsoleColor.Black, ConsoleColor bckCol = ConsoleColor.White)
        {
            // Console.ForegroundColor = color;
            // Console.BackgroundColor = bckCol;
            // Console.
            Console.WriteLine(s);
        }
        
        public static void LogError(string s)
        {
            Console.WriteLine(s);
        }
    }
}