/*
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создать класс, представляющий учебный класс ClassRoom.  
Создайте класс ученик Pupil.  В теле класса создайте методы void Study(), void Read(), void Write(), void Relax().  
Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil  от класса базового класса Pupil и переопределите каждый из методов, в зависимости от успеваемости ученика.   
Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников. 
Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента.  
Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать, писать, отдыхать.  
*/
using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int addedPupils;
            Pupil[] pupil = new Pupil[4];
            pupil[0] = new Pupil("Елена Громова");
            pupil[1] = new Pupil("Матвей Шимаев");
            pupil[2] = new Pupil("Тамара Ермолова");
            pupil[3] = new Pupil("Николай Терещенко");
            ClassRoom classRoom = new ClassRoom(pupil[0], pupil[1], pupil[2], pupil[3]);

            Console.WriteLine($"Вы - учитель.\nВ вашем классе {pupil.Length} человека. На перемене играют ещё двое.\n");
            Console.Write("Позвать играющи на перемене?\n0 - нет\n1 - одного\n2 - обоих\nМой ответ = ");
            addedPupils = Int32.Parse(Console.ReadLine());
            if (addedPupils != 0)
            {
                if (addedPupils == 1)
                {
                    classRoom.AddedPupilsToList = addedPupils;
                    Console.Write("\nИмя и фамилия ребенка через пробел = ");
                    classRoom.FirstFullNamePupilromList = Console.ReadLine();
                }
                else
                {
                    classRoom.AddedPupilsToList = addedPupils;
                    Console.Write($"\nИмя и фамилия 1 ребенка через пробел = ");
                    classRoom.FirstFullNamePupilromList = Console.ReadLine();
                    Console.Write($"\nИмя и фамилия 2 ребенка через пробел = ");
                    classRoom.FirstFullNamePupilromList = Console.ReadLine();
                }
            }

            classRoom.GetPupilInformation();

            Console.ReadKey();
        }
    }
}
