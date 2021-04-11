using System;
using static System.Console;

namespace CastingConverting
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            double b  = a;

            WriteLine($"The variable a ({a}) is a integer that can be safeli casted to a double: {b}.");

            double c = 9.8;
            int d = (int)c;

            WriteLine($"The variable c ({c}) is a double that can casted to a int but we loose some data: {d}.");

            long e = 10;
            int f = (int)e;

            WriteLine($"When e is {e}, (int)e is {f}");

            e = long.MaxValue;
            f = (int)e;

            WriteLine($"When e is {e}, (int)e is {f}");

            e = 5_000_000_000;
            f = (int)e;

            WriteLine($"When e is {e}, (int)e is {f}");
            WriteLine("You get the point, you cast you may loose some stuff.");
        }
    }
}
