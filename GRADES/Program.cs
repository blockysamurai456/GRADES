using System;
using System.Speech.Synthesis;

namespace GRADES
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer talk = new SpeechSynthesizer();
             talk.Speak("hello this the grading machine");

            BookOfGrades book1 = new BookOfGrades();
            book1.AddGrade(73);
            book1.AddGrade(82.7f);
            book1.AddGrade(75);

            Gstats stats = book1.ComputeStatistics();
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);      

        }
    }
}
