using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string userColor;
            Console.WriteLine("Print your faviurite color please!");
            userColor = Console.ReadLine().ToLower();
            if (userColor == "red")
            {
                Console.WriteLine("You are romantic");
            }
            else if (userColor == "blue")
            {
                Console.WriteLine("You are cheerful");
            }
            else if (userColor == "reliable")
            {
                Console.WriteLine("You are cheerful");
            }
            else
            {
                Console.WriteLine($"You are {userColor} Unicorn");
            }
        }
    }
}
