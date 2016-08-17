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
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Hello, this is a totally gnarly grade book program, bro.");

            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine("Average: " + stats.AverageGrade);
            Console.WriteLine("Lowest: " + stats.LowestGrade);
            Console.WriteLine("Highest: " + stats.HighestGrade);
        }
    }
}
