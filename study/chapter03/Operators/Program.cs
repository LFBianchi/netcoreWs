using System;
using static System.Console;

namespace chapter03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int a = 3;
            int b = a++;
            WriteLine($"a is {a}, b is {b}");

            int c = 3;
            int d = ++c;
            WriteLine($"c is {c}, d is {d}");

            int e = 11;
            int f = 7;
            WriteLine($"e is {e}, f is {f}");
            WriteLine($"e + f is {e + f}");
            WriteLine($"e - f is {e - f}");
            WriteLine($"e * f is {e * f}");
            WriteLine($"e / f is {e / f}");
            WriteLine($"e % f is {e % f}");

            double g = 11.0;
            WriteLine($"g is {g:N1}, f is {f}");
            WriteLine($"g / f = {g / f}");
            */

            bool a = true;
            bool b = false;

            WriteLine($"a is {a}");
            WriteLine($"a is {b}");
            WriteLine($"a & b is {a & b}");

            WriteLine($"a & DoStuff {a & DoStuff()}");
            WriteLine($"b & DoStuff {b & DoStuff()}");

            WriteLine("Now with sort-circuiting Boolean Operators");

            WriteLine($"a && DoStuff {a && DoStuff()}");
            WriteLine($"b && DoStuff {b && DoStuff()}");

        }

        private static bool DoStuff() 
        {
            WriteLine("I'm doing some stuff.");
            return true;
        }
    }
}
