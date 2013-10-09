using System;

namespace cSharpStarterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int loopLength = 5;
            int i;

            for (i = 0; i < loopLength; i++)
            {
                if ((i % 2) == 0)
                {
                    Console.WriteLine(i + ": Hello, World!");
                }
            }
        }
    }
}
