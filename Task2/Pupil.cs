using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Pupil
    {
        string fullName;

        public Pupil()
        {

        }

        public Pupil(string pupilFullName)
        {
            fullName = pupilFullName;
        }

        public string FullName { get { return fullName; } }

        public virtual void Study()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"{fullName}");
            Read();
            Write();
            Relax();
            Console.ResetColor();
        }

        protected virtual void Read()
        {
            Console.Write(" умею читать; ");
        }

        protected virtual void Write()
        {
            Console.Write("пишу без ошибок; ");
        }

        protected virtual void Relax()
        {
            Console.Write("занимаюсь всем на свете, и всё успеваю!");
        }
    }
}
