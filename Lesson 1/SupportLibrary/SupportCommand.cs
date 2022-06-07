using System;
using System.Threading;

namespace SupportLibrary
{
    public class SupportCommand
    {
        public static void Print(string ms, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(ms);
            y = Console.CursorTop;
        }

        public static void Pause(int ms)
        {
            Thread.Sleep(ms);
        }
    }
}
