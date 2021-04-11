using System;
using static System.Console;

namespace IteractionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i < 10) 
            {
                WriteLine(i);
                i += 1;
            }

            string password = string.Empty;

            int count = 0;
            bool fail = false;

            do
            {
                Write("Enter your password: ");
                password = ReadLine();
                count += 1;
                if (count >= 10) 
                {
                    fail = true;
                    break;
                }
            }
            while (password != "edinoelia");

            if (fail)
            {
                WriteLine("Nops, errou.");
            }
            else
            {
                WriteLine("Ta sabeno legal.");
            }

            for (int y =0; y <= 10; y += 1)
            {
                WriteLine(y);
            }

            string[] names = {"Adam", "Barry", "Charlie"};

            foreach (string name in names)
            {
                WriteLine($"{name} has {name.Length} characters.");
            }
        }
    }
}
