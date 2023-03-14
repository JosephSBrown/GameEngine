using System;

namespace GameEngineProject.Game_Engine
{
    public class Log
    {
        public static void NormalMessage(string msg)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"[MSG] - {msg}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void InfoMessage(string info)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"[INFO] - {info}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void WarningMessage(string warning)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[ERROR] - {warning}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void ErrorMessage(string error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[ERROR] - {error}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
