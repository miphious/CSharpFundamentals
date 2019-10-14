using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();

            book.AddGrade(91);
            book.AddGrade(89.5);
            book.AddGrade(75);
            int userInput = 0;
            while (userInput != 1)
            {
                Console.WriteLine("Please enter a grade: ");
                book.AddGrade(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("1. Finished Entering Grades. ");
                Console.WriteLine("2. Enter Another Grade");
                Console.WriteLine("Please enter 1 if you would like to continue: ");
                userInput = Convert.ToInt32(Console.ReadLine());

            }
            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine("Average Grade: " + Math.Round(stats.AverageGrade,1));
            Console.WriteLine("Highest Grade: " + stats.HighestGrade);
            Console.WriteLine("Lowest Grade: " + stats.LowestGrade);

        }
    } 
}
