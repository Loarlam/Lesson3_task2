using System;

namespace Task2
{
    class GoodPupil : Pupil
    {
        string fullNameOfGoodPupil;

        public string FullNameOfGoodPupil { set => fullNameOfGoodPupil = value; }

        public override void Study()
        {
            Console.WriteLine($"{fullNameOfGoodPupil} (хорошист):");
            Console.ForegroundColor = ConsoleColor.Blue;
            Read();
            Write();
            Relax();
            Console.ResetColor();
        }

        protected override void Read()
        {
            Console.WriteLine("- читает, но с редкими ошибками в словах;");
        }

        protected override void Write()
        {
            Console.WriteLine("- пишет, но с редкими ошибками;");
        }

        protected override void Relax()
        {
            Console.WriteLine("- ходит на секцию баскетбола;\n");
        }
    }
}
