using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?:");
            string name = Console.ReadLine();
            Console.WriteLine("How many hours of sleep did your get last night?");
            int hoursOfSleep = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, " + name);
            if (hoursOfSleep >= 8) 
            {
                Console.WriteLine("You are well rested");
            }
            else
            {
                Console.WriteLine("you need more sleep");
            }

        }
    }
}
