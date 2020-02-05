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
            if (pupil[2] == null)
            {
                Console.WriteLine($"Вы - учитель.\nВ вашем классе {pupil.Length} ученика. На перемене играют ещё двое.\n");
                Console.Write("Позвать играющих на перемене?\n0 - нет\n1 - одного\n2 - обоих\nМой ответ = ");
                addedPupilsToList = Int32.Parse(Console.ReadLine());
                switch (addedPupilsToList)
                {
                    case 1:
                        return new Pupil(firstFullNamePupilFromList1);
                    case 2:
                        if (pupil[2] != null) return new Pupil(secondFullNamePupilFromList2);
                        else return new Pupil(firstFullNamePupilFromList1);
                    default:
                        return null;
                }
                //if (addedPupilsToList != 0)
                //{
                //    if (addedPupilsToList == 1)
                //    {
                //        Console.Write("\nИмя и фамилия ребенка через пробел = ");
                //        firstFullNamePupilFromList1 = Console.ReadLine();
                //    }
                //    else
                //    {
                //        Console.Write($"\nИмя и фамилия 1 ребенка через пробел = ");
                //        firstFullNamePupilFromList1 = Console.ReadLine();
                //        Console.Write($"\nИмя и фамилия 2 ребенка через пробел = ");
                //        secondFullNamePupilFromList2 = Console.ReadLine();
                //    }
                //}
            }
            return null;

            //if (pupil[3] == null)
            //{
            //    Console.WriteLine($"Вы - учитель.\nВ вашем классе {pupil.Length} человека. На перемене играют ещё двое.\n");

            //    Console.Write("Позвать играющих на перемене?\n0 - нет\n1 - одного\n2 - обоих\nМой ответ = ");
            //    addedPupilsToList = Int32.Parse(Console.ReadLine());
            //    if (addedPupilsToList != 0)
            //    {
            //        if (addedPupilsToList == 1)
            //        {
            //            Console.Write("\nИмя и фамилия ребенка через пробел = ");
            //            firstFullNamePupilFromList1 = Console.ReadLine();
            //        }
            //        else
            //        {
            //            Console.Write($"\nИмя и фамилия 1 ребенка через пробел = ");
            //            firstFullNamePupilFromList1 = Console.ReadLine();
            //            Console.Write($"\nИмя и фамилия 2 ребенка через пробел = ");
            //            secondFullNamePupilFromList2 = Console.ReadLine();
            //        }
            //    }
            //}

            //switch (addedPupilsToList)
            //{
            //    case 1:
            //            return new Pupil(firstFullNamePupilFromList1); 
            //    case 2:
            //        if (pupil[2] != null) return new Pupil(secondFullNamePupilFromList2);
            //        else return new Pupil(firstFullNamePupilFromList1);
            //    default:
            //        return null;
            //}
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
                        //добавить блок if. Если приходит первый, то одно описание, если второй - второе
                        goodPupil.FullNameOfGoodPupil = pupil[i].FullName;
                        goodPupil.Study();
                        //Console.WriteLine("Ученик не найдем в базе данных.");
                        break;
                }

            }
        }
    }
}
