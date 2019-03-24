using System;
using System.Collections.Generic;
using System.IO;

namespace Grades
{
//    public class GradeBook : object // inheriting from object is the default inheritance for a class
    public class GradeBook : GradeTracker
    {
        public GradeBook()
        {
            _name = "Empty";
            grades = new List<float>();
        }

        public override GradeStatistics ComputeStatistics()
        {
            Console.WriteLine("GradeBook::ComputeStatistics");
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;
            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }

            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

        protected List<float> grades;

        public override void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public override void WriteGrades(TextWriter destination)
        {
//            for (int i = 0; i < grades.Count; i++)
//            {
//                destination.WriteLine(grades[i]);
//            }
            for (int i = grades.Count; i > 0; i--)
            {
                destination.WriteLine(grades[i - 1]);
            }
        }
    }
}