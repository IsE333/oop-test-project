using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Mathemathics
    {
        public const int PassGrade = 40;
        public double FirstShortExam { get; set; }
        public double SecondShortExam { get; set; }
        public double MidtermExam { get; set; }
        public double FinalExam { get; set; }
        public double Average { get; set; }

        public Mathemathics()
        {
            FirstShortExam = 0;
            SecondShortExam = 0;
            MidtermExam = 0;
            FinalExam = 0;

            SetGrades();
            GetAverage();
        }

        public double GetAverage()
        {
            double sum = FirstShortExam * 15 + SecondShortExam * 15 + MidtermExam * 30 + FinalExam * 40;
            Average = sum / 100;
            return Average;
        }

        public void SetGrades()
        {
            Console.Write("Matematik 1. Kısa Sınav: ");
            bool result = double.TryParse(Console.ReadLine(), out double firstShortExam);
            if (result)
                FirstShortExam = firstShortExam;

            Console.Write("Matematik 2. Kısa Sınav: ");
            result = double.TryParse(Console.ReadLine(), out double secondShortExam);
            if (result)
                SecondShortExam = secondShortExam;

            Console.Write("Matematik Vize Sınav: ");
            result = double.TryParse(Console.ReadLine(), out double midtermExam);
            if (result)
                MidtermExam = midtermExam;

            Console.Write("Matematik Final Sınav: ");
            result = double.TryParse(Console.ReadLine(), out double finalExam);
            if (result)
                FinalExam = finalExam;
        }

        public string IsPass()
        {
            if (Average >= PassGrade) 
                return "Matematikten Geçti";
            return "Matematikten Kaldı";
        }
    }
}
