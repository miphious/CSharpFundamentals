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
            
            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine("Average Grade: " + Math.Round(stats.AverageGrade,1));
            Console.WriteLine("Highest Grade: " + stats.HighestGrade);
            Console.WriteLine("Lowest Grade: " + stats.LowestGrade);

        }
    } 
}
