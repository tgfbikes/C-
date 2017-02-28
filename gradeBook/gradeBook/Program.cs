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
            string typeOfGradeBook = "throw away";
            IGradeTracker book = CreateGradeBook(typeOfGradeBook);

            GetBookName(book);

            AddGrades(book);

            WriteResults(book);
        }

        private static IGradeTracker CreateGradeBook(string typeOfGradeBook)
        {
            switch (typeOfGradeBook)
            {
                case "throw away":
                    return new ThrowAwayGradeBook();
                case "regular":
                    return new GradeBook();
                default:
                    return new GradeBook();
            }
        }

        private static void WriteResults(IGradeTracker book)
        {
            GradeStatistics stats = book.ComputeStatistics();

            WriteResult("Average", stats.AverageGrade);
            WriteResult("Lowest", stats.LowestGrade);
            WriteResult("Highest", stats.HighestGrade);
            WriteResult("Letter Grade", stats.LetterGrade);
            WriteResult("Letter Grade Description", stats.LetterGradeDescription);
        }

        private static void AddGrades(IGradeTracker book)
        {
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
        }

        private static void GetBookName(IGradeTracker book)
        {
            try
            {
                Console.WriteLine("Enter a name");
                book.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void WriteResult( string description, float result)
        {
            Console.WriteLine($"{description}: {result}");
        }

        static void WriteResult( string description, string result)
        {
            Console.WriteLine($"{description}: {result}");
        }
    }
}
