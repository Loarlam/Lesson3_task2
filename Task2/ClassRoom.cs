using System;

namespace Task2
{
    class ClassRoom
    {
        ExcellentPupil excellentPupil = new ExcellentPupil();
        GoodPupil goodPupil = new GoodPupil();
        BadPupil badPupil = new BadPupil();
        readonly Pupil[] pupil = new Pupil[4];

        int addedPupilsToList = 0;

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

        Pupil ChooseFromPupilsList()
        {
            if (addedPupilsToList == 2)
            {
                Console.Write($"\nИмя и фамилия 2 ребенка через пробел = ");
                return new Pupil(Console.ReadLine());
            }

            if (pupil[2] == null)
            {
                Console.WriteLine("Вы - учитель.\nВ вашем классе два ученика. На перемене играют ещё двое.\n");
                Console.Write("Позвать играющих на перемене?\n0 - нет\n1 - одного\n2 - обоих\nМой ответ = ");
                addedPupilsToList = Int32.Parse(Console.ReadLine());
                switch (addedPupilsToList)
                {
                    case 1:
                        Console.Write("\nИмя и фамилия ребенка через пробел = ");
                        return new Pupil(Console.ReadLine());
                    case 2:
                        Console.Write($"\nИмя и фамилия 1 ребенка через пробел = ");
                        return new Pupil(Console.ReadLine());
                    default:
                        return null;
                }
            }

            if (pupil[2] != null)
            {
                Console.WriteLine("Вы - учитель.\nВ вашем классе три ученика. На перемене играет ещё один.\n");
                Console.Write("Позвать играющего на перемене?\n0 - нет\n1 - да\nМой ответ = ");
                addedPupilsToList = Int32.Parse(Console.ReadLine());
                switch (addedPupilsToList)
                {
                    case 1:
                        Console.Write("\nИмя и фамилия ребенка через пробел = ");
                        return new Pupil(Console.ReadLine());
                    default:
                        return null;
                }
            }
            return null;
        }

        public void GetPupilInformation()
        {
            Console.WriteLine("\nСписок учеников:");
            for (int i = 0; i < pupil.Length; i++)
            {
                if (pupil[i] != null)
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
                            goodPupil.FullNameOfGoodPupil = pupil[i].FullName;
                            goodPupil.Study();
                            continue;
                    }
                }
            }
        }
    }
}
