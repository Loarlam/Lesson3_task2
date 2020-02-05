using System;

namespace Task2
{
    class ExcellentPupil : Pupil
    {
        string fullNameOfExcellentPupil;

        public string FullNameOfPupil { set => fullNameOfExcellentPupil = value; }

        public override void Study()
        {
            Console.WriteLine($"{fullNameOfExcellentPupil}:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Read();
            Write();
            Relax();
            Console.ResetColor();
        }

        protected override void Read()
        {
            Console.WriteLine("- читает без запинки;");
        }

        protected override void Write()
        {
            Console.WriteLine("- пишет без ошибок;");
        }

        protected override void Relax()
        {
            Console.WriteLine("- занимается с репетиторами; ходит в бассейн;\n");
        }
    }
}
