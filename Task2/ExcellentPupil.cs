using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class ExcellentPupil : Pupil
    {
        public override void Study()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{base.FullName}");
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
            Console.Write("пишет без ошибок; ");
        }

        protected override void Relax()
        {
            Console.WriteLine("занимается с репетиторами; ходит в бассейн; интересуется устройством вселенной");
        }
    }
}
