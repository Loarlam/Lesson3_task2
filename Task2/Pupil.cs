using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Pupil
    {
        readonly protected string fullName;

        public Pupil(string pupilFullName)
        {
            fullName = pupilFullName;
        }

        public virtual void Study()
        {
            //Тут я напишу что-то, 
            //чего не будет в классах 
            //excelent, good, bad.
            //Затем вызову из этих классов base.Study()
        }

        protected virtual void Read()
        {

        }

        protected virtual void Write()
        {

        }

        protected virtual void Relax()
        {

        }
    }
}
