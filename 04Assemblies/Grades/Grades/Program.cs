using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);

//            SpeechSynthesizer synth = new SpeechSynthesizer();
//            synth.Speak("The average grade is " + stats.AverageGrade);
//            synth.Speak("The highest grade is " + stats.HighestGrade);
//            synth.Speak("The lowest grade is " + stats.LowestGrade);
        }
    }
}
