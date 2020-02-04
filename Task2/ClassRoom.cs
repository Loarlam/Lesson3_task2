using System;

namespace Task2
{
    class ClassRoom
    {
        ExcellentPupil excellentPupil = new ExcellentPupil();
        GoodPupil goodPupil = new GoodPupil();
        BadPupil badPupil = new BadPupil();
        readonly Pupil[] pupil = new Pupil[4];

        int addedPupilsToList;
        string firstFullNamePupilFromList1, secondFullNamePupilFromList2;

        public int AddedPupilsToList { set { addedPupilsToList = value; } }
        public string FirstFullNamePupilromList { set { firstFullNamePupilFromList1 = value; } }
        public string SecondFullNamePupilFromList { set { secondFullNamePupilFromList2 = value; } }

        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            pupil[0] = pupil1;
            pupil[1] = pupil2;
            pupil[2] = ChooseFromPupilsList();
            pupil[3] = ChooseFromPupilsList();
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            pupil[0] = pupil1;
            pupil[1] = pupil2;
            pupil[2] = pupil3;
            pupil[3] = ChooseFromPupilsList();
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            pupil[0] = pupil1;
            pupil[1] = pupil2;
            pupil[2] = pupil3;
            pupil[3] = pupil4;
        }

        public Pupil ChooseFromPupilsList()
        {
            if (pupil.Length != 4)
            {
                Pupil pupilFromList = new Pupil();
                Random random = new Random();
                return pupilFromList;
            }
            return null;
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
                    //Внести дополнительные case с новичками
                    default:
                        Console.WriteLine("Ученик не найдем в базе данных.");
                        break;
                }

            }
        }
    }
}
