using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class ClassRoom
    {
        ExcellentPupil excellentPupil = new ExcellentPupil();
        GoodPupil goodPupil= new GoodPupil();

        Pupil[] pupil = new Pupil[4];

        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            pupil[0] = pupil1;
            pupil[1] = pupil2;
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            pupil[0] = pupil1;
            pupil[1] = pupil2;
            pupil[2] = pupil3;
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            pupil[0] = pupil1;
            pupil[1] = pupil2;
            pupil[2] = pupil3;
            pupil[3] = pupil4;
        }

        public void GetPupilInformation()
        {
            for (int i = 0; i < pupil.Length; i++)
            {
                switch (excellentPupil.FullName)
                {
                    case "Елена Громова":
                        excellentPupil.Study();
                        break;
                    case "Матвей Шимаев":
                        excellentPupil.Study();
                        break;
                    case "Тамара Ермолова":
                        excellentPupil.Study();
                        break;
                    case "Николай Терещенко":
                        excellentPupil.Study();
                        break;
                    default:
                        Console.WriteLine("Ученик не найдем в базе данных.");
                        break;
                }

            }
        }
    }
}
