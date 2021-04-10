using System;
using static System.Console;

namespace BitwiseAndShiftOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b  = 6;

            WriteLine($"a = {a}");
            WriteLine($"b = {b}");
            WriteLine($"a & b = {a & b}");
            WriteLine($"a | b = {a | b}");
            WriteLine($"a ^ b = {a ^ b}");

            WriteLine($"a << 3 = {a << 3}");  //yields the same result as multiplying by 8.
            WriteLine($"a * 8 = {a * 8}");
            WriteLine($"b >> 1 = {b >> 1}");
        }
    }
}
