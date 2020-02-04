using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class GoodPupil : Pupil
    {
        public GoodPupil(string pupilFullName) : base(pupilFullName)
        {

        }

        public override void Study()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{fullName}");
            Read();
            Write();
            Relax();
            Console.ResetColor();
        }

        protected override void Read()
        {
            Console.Write(" читает без запинки; ");
        }

        protected override void Write()
        {
            Console.Write("пишет, но с редкими ошибками; ");
        }

        protected override void Relax()
        {
            Console.Write(" ходит на секцию баскетбола; любит собирать lego");
        }
    }
}
