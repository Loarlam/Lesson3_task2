using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class BadPupil: Pupil
    {
        public override void Study()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{fullName}");
            Read();
            Write();
            Relax();
            Console.ResetColor();
        }

        public string FullName { get { return fullName; } }

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
