using System;

namespace Task2
{
    class ClassRoom
    {
        readonly ExcellentPupil excellentPupil = new ExcellentPupil();
        readonly GoodPupil goodPupil = new GoodPupil();
        readonly BadPupil badPupil = new BadPupil();
        readonly Pupil[] pupil = new Pupil[4];

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
                switch (pupil[i].FullName)
                {
                    case "Елена Громова":
                        excellentPupil.FullNameOfPupil = pupil[i].FullName;
                        excellentPupil.Study();
                        break;
                    case "Матвей Шимаев":
                        badPupil.FullNameOfBadPupil = pupil[i].FullName;
                        badPupil.Study();
                        break;
                    case "Тамара Ермолова":
                        goodPupil.FullNameOfGoodPupil = pupil[i].FullName;
                        goodPupil.Study();
                        break;
                    case "Николай Терещенко":
                        excellentPupil.FullNameOfPupil = pupil[i].FullName;
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
