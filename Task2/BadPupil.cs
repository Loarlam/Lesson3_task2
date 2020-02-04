using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class BadPupil: Pupil
    {
        public BadPupil(string pupilFullName): base(pupilFullName)
        {

        }

        public override void Study()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{fullName}");
            Console.ResetColor();
            Read();
            Write();
            Relax();
        }

        protected override void Read()
        {
            Console.Write(" читает плохо; ");
        }

        protected override void Write()
        {
            Console.Write("пишет с ошибками; ");
        }

        protected override void Relax()
        {
            Console.Write("любит много гулять; катается на поездах");
        }
    }
}
