using System;

namespace Library
{
    public class Printer
    {
        public void Print(string message)
        {
            Console.WriteLine($"Version 1.3.0 says {message}! It's a breaking change.");
        }
    }
}
