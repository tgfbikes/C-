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
            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.Speak("Hello, this is a totally gnarly grade book program, bro.");

            GradeBook book = new GradeBook();
            book.Name = "Stephen's grade book";
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine(book.Name);
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Lowest", stats.LowestGrade);
            WriteResult("Highest", (int)stats.HighestGrade);
        }

        static void WriteResult( string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult( string description, float result)
        {
            Console.WriteLine($"{description}: {result}");
        }
    }
}
