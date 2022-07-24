using System;

namespace Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Student student = new();
            student.Name = "Omar";
            student.Surname = "Nuriyev";
            student.Patronymic = "Ramin";
            student.Age = 15;
            student.AddGrade(Subject.Programming, 1);
            student.AddGrade(Subject.Programming, 12);
            student.Print();




        }
    }
}