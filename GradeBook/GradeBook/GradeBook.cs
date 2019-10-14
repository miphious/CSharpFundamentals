using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    class GradeBook
    {
        //ctor then tab twice to create constrcutor
        public GradeBook()
        {
            grades = new List<double>();
        }
        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            double sum = 0;
            foreach (float grade in grades)
            {
                sum += grade;
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
            }
            if (grades.Count != 0)
            {
                stats.AverageGrade = sum / grades.Count;
            }
            else
            {
                Console.WriteLine("Please enter some grades first!");
            }
            
            return stats;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
        List<double> grades;
        public static double MinimunGrade = 0;
        public static double MaximumGrade = 100;

    }

}
