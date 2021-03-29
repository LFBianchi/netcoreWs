using System;
using static System.Console;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            object listOfTypes = new object[11];

            sbyte a = 0;
            byte b = 0;
            short c = 0;
            ushort d = 0;
            int e = 0;
            uint f = 0;
            long g = 0;
            ulong h = 0;
            float i = 0;
            double j = 0;
            decimal k = 0M;


            foreach(oject type in listOfTypes)
            {
                print(sizeof(type));
            }   
            sizeof(int);
        }
    }
}
