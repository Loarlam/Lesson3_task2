﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{base.FullName}");
            Read();
            Write();
            Relax();
            Console.ResetColor();
        }

        protected override void Read()
        {
            Console.Write(" читает, но с редкими ошибками в словах; ");
        }

        protected override void Write()
        {
            Console.Write("пишет, но с редкими ошибками; ");
        }

        protected override void Relax()
        {
            Console.WriteLine(" ходит на секцию баскетбола; любит собирать lego");
        }
    }
}
