using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct Student
{
    public Student()
    {
        Grades[0] = new int[0];
        Grades[1] = new int[0];
        Grades[2] = new int[0];
    }
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = String.Empty;
    public string Patronymic { get; set; } = String.Empty;
    public string Group { get; set; } = String.Empty;
    public int Age { get; set; } = 0;
    public int[][] Grades { get; set; } = new int[3][];
    public void AddGrade(Subject subject, int grade)
    {
        int len = Grades[(int)subject].Length;
        if (grade > 12 || grade < 1)
        {
            Console.WriteLine( "Такой оценки не сущ. изменения не вступят в силу!");
            return;
        }
        int[] temp = new int[len + 1];
        Grades[(int)subject].CopyTo(temp, 0);
        temp[len] = grade;
        Grades[(int)subject] = temp;
    }
    public void ChangeGrade(Subject subject, int index)
    {
        int len = Grades[(int)subject].Length;
        if (index >= len || index < 0)
        {
            Console.WriteLine("Выход за пределы длены, изменения не будут вступать в силу!");
            return;
        }
    }
    public void GetGrade(Subject subject)
    {
        Console.Write($"{subject}: ");
        foreach (int grade in Grades[(int)subject])
        {
            Console.Write($"{grade} ");
        }
        Console.WriteLine();
    }
    public float AverageGrade()
    {
        float count = 0;
        float grades = 0;
        foreach (var _item in Grades)
        {
            foreach (var item in _item)
            {
                count++;
                grades += item;
            }
        }
        return grades / count;
    }
    public void Print()
    {
        Console.WriteLine($"STUDENT INFO\n");
        Console.WriteLine($"Name - {Name}");
        Console.WriteLine($"Surname - {Surname}");
        Console.WriteLine($"Patronymic - {Patronymic}");
        Console.WriteLine($"Group - {Group}");
        Console.WriteLine($"Age - {Age}");
        Console.WriteLine("\nGRADES\n");
        GetGrade(Subject.Programming);
        GetGrade(Subject.Design);
        GetGrade(Subject.Administration);
        Console.WriteLine($"Average Grade - {AverageGrade()}");
    }

}
 enum Subject
{
    Programming,
    Design,
    Administration
}
