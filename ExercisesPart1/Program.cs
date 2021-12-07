using System;

namespace ExercisesPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, lastname, year;
            int age;
            int currentYear = DateTime.Now.Year;
            Console.WriteLine("Print name");
            name = Console.ReadLine();
            Console.WriteLine("Print lastname");
            lastname = Console.ReadLine();
            Console.WriteLine($"Hello {name} {lastname}");
            Console.WriteLine("The year you were born?");
            year = Console.ReadLine();
            age = currentYear - Convert.ToInt32(year);
            if (age>=13)
            {
                Console.WriteLine("Welcome to Instagram");
            }
            else
            {
                Console.WriteLine("You are too young to have an Instagram account");
            }
        }
    }
}
