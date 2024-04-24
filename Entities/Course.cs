using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Course
    {
        public const int PassGrade = 40;
        public string Name { get; set; }
        public int Credit { get; set; }
        public double FirstShortExam { get; set; }
        public double SecondShortExam { get; set; }
        public double MidtermExam { get; set; }
        public double FinalExam { get; set; }
        public double Average { get; set; }
        public Course(string name, int credit)
        {
            Name = name;
            Credit = credit;
            FirstShortExam = 0;
            SecondShortExam = 0;
            MidtermExam = 0;
            FinalExam = 0;
        }
        public double GetAverage()
        {
            double sum = FirstShortExam * 15 + SecondShortExam * 15 + MidtermExam * 30 + FinalExam * 40;
            Average = sum / 100;
            return Average;
        }

        public void SetGrades()
        {
            Console.Write(Name + " 1. Kısa Sınav: ");
            bool result = double.TryParse(Console.ReadLine(), out double firstShortExam);
            if (result)
                FirstShortExam = firstShortExam;

            Console.Write(Name + " 2. Kısa Sınav: ");
            result = double.TryParse(Console.ReadLine(), out double secondShortExam);
            if (result)
                SecondShortExam = secondShortExam;

            Console.Write(Name + " Vize Sınav: ");
            result = double.TryParse(Console.ReadLine(), out double midtermExam);
            if (result)
                MidtermExam = midtermExam;

            Console.Write(Name + " Final Sınav: ");
            result = double.TryParse(Console.ReadLine(), out double finalExam);
            if (result)
                FinalExam = finalExam;
        }

        public string IsPass()
        {
            if (Average >= PassGrade)
                return Name + ": Geçti";
            return Name + ": Kaldı";
        }

    }
}
