using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class ClassRoom
    {
        /*ФИО - в pupil; через case выясняем, как учится ученик*/
        readonly Pupil[] pupil;

        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            pupil = new Pupil[2];
            pupil[0] = pupil1;
            pupil[1] = pupil2;
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            pupil = new Pupil[3];
            pupil[0] = pupil1;
            pupil[1] = pupil2;
            pupil[2] = pupil3;
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            pupil = new Pupil[4];
            pupil[0] = pupil1;
            pupil[1] = pupil2;
            pupil[2] = pupil3;
            pupil[3] = pupil4;
        }
    }
}
