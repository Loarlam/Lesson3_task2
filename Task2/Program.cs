﻿/*
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
            Pupil[] pupil = {
                new Pupil("Елена Громова"),
                new Pupil("Матвей Шимаев"),
                new Pupil("Тамара Ермолова"),
                new Pupil("Николай Терещенко") };
            ClassRoom classRoom = new ClassRoom(pupil[0], pupil[1], pupil[2]);

            classRoom.GetPupilInformation();

            Console.ReadKey();
        }
    }
}
