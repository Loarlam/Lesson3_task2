using System;

namespace Task2
{
    class BadPupil : Pupil
    {
        string fullNameOfBadPupil;

        public string FullNameOfBadPupil { set => fullNameOfBadPupil = value; }

        public override void Study()
        {
            Console.WriteLine($"{fullNameOfBadPupil}:");
            Console.ForegroundColor = ConsoleColor.Red;
            Read();
            Write();
            Relax();
            Console.ResetColor();
        }

        protected override void Read()
        {
            Console.WriteLine("- читает плохо;");
        }

        protected override void Write()
        {
            Console.WriteLine("- пишет с ошибками;");
        }

        protected override void Relax()
        {
            Console.WriteLine("- бегает по гаражам; катается на поездах\n");
        }
    }
}
