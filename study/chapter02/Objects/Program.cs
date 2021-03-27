using System;

namespace Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            object heigth = 1.88;
            object name = "Amir";

            Console.WriteLine($"{name} is {heigth} metres tall.");

            //int lenght1 = name.Length;
            int length2 = ((string)name).Length;

            Console.WriteLine($"{name} has {length2} characters.");

            dynamic anotherName = "Ahmed";

            int length3 = anotherName.Length;

            Console.WriteLine($"{anotherName} has {length3} characters.");

            /*
            var population = 66_000_000; // 66 million in UK
            var weight = 1.88; // in kilograms
            var price = 4.99M; // in pounds sterling
            var fruit = "Apples"; // strings use double-quotes
            var letter = 'Z'; // chars use single-quotes
            var happy = true; // Booleans have value of true or false
            */

            Console.WriteLine($"default(int) = {default(int)}");
            Console.WriteLine($"default(bool) = {default(bool)}");
            Console.WriteLine($"default(DateTime) = {default(DateTime)}");
            Console.WriteLine($"default(string) = {default(string)}");

            //Working with arrays.

            string[] names = new string[4];

            names[0] = "Kate";
            names[1] = "Jack";
            names[2] = "Rebecca";
            names[3] = "Tom";

            for (int i = 0; i < names.Length; i++) 
            {
                Console.WriteLine(names[i]);
            }        
        }
    }
}
