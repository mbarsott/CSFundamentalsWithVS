using System;

namespace Grades
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var book = new GradeBook();
//            book.NameChanged += new NameChangedDelegate(OnNameChanged);
//            book.NameChanged += new NameChangedDelegate(OnNameChanged2);
//            book.NameChanged += null;
            book.NameChanged += OnNameChanged;
//            book.NameChanged += OnNameChanged2;
//            book.NameChanged += OnNameChanged2;
//            book.NameChanged -= OnNameChanged2;
            book.Name = "Marcelo's Grade Book";
            book.Name = null;
            book.Name = "Grade Book";
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            var stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", (int) stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
        }

//        static void OnNameChanged2(string from, string to)
//        {
//            Console.WriteLine("***");
//        }

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Grade book changing name from {args.ExistingName} to {args.NewName}");
        }

        private static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + " " + result);
        }

        private static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description}: {result:F2}"); // C#6 and later
//            Console.WriteLine("{0}: {1:F2}", description, result); // F2 float with 2 decimals; C for currency, etc.
        }
    }
}