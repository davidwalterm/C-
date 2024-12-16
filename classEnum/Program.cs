using System;

namespace MyApplication
{

    enum Level
    {
        Low,
        Medium,
        High
    }
    class Program
    {
        static void Main()
        {
            Level myVar = Level.Medium;
            Console.WriteLine(myVar);

        }
    }
}