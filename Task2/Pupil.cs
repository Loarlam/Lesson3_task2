using System;

namespace Task2
{
    class Pupil
    {
        readonly string fullNameOfPupil;

        public Pupil()
        {

        }

        public Pupil(string pupilFullName)
        {
            fullNameOfPupil = pupilFullName;
        }

        public string FullName => fullNameOfPupil;

        public virtual void Study()
        {
            Console.WriteLine($"{fullNameOfPupil}:");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Read();
            Write();
            Relax();
            Console.ResetColor();
        }

        protected virtual void Read()
        {
            Console.WriteLine("- умею читать;");
        }

        protected virtual void Write()
        {
            Console.WriteLine("- пишу без ошибок;");
        }

        protected virtual void Relax()
        {
            Console.WriteLine("- занимаюсь всем на свете, и всё успеваю!\n");
        }
    }
}
