using System;
using System.Collections.Generic;


public abstract class Person
{
    public string Name { get; set; }
    public Person(string name) => Name = name;

    public abstract void DisplayRole();
}

public interface IUniversityEmployee
{
    void PerformDuties();
}

public interface IStudent
{
    void Study();
}

public class Student : Person, IStudent
{
    public string Group { get; set; }

    public Student(string name, string group) : base(name)
    {
        Group = group;
    }

    public override void DisplayRole()
    {
        Console.WriteLine($"Я студент. Имя: {Name}, Группа: {Group}.");
    }

    public void Study()
    {
        Console.WriteLine($"{Name} изучает материалы.");
    }
}

public class Teacher : Person, IUniversityEmployee
{
    public string Subject { get; set; }

    public Teacher(string name, string subject) : base(name)
    {
        Subject = subject;
    }

    public override void DisplayRole()
    {
        Console.WriteLine($"Я преподаватель. Имя: {Name}, Предмет: {Subject}.");
    }

    public void PerformDuties()
    {
        Console.WriteLine($"{Name} проводит лекции по {Subject}.");
    }
}

public class HeadOfDepartment : Person, IUniversityEmployee
{
    public string Department { get; set; }

    public HeadOfDepartment(string name, string department) : base(name)
    {
        Department = department;
    }

    public override void DisplayRole()
    {
        Console.WriteLine($"Я заведующий кафедрой. Имя: {Name}, Кафедра: {Department}.");
    }

    public void PerformDuties()
    {
        Console.WriteLine($"{Name} управляет кафедрой {Department}.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var student = new Student("Алексей", "Математика");
        var teacher = new Teacher("Иван Иванович", "Физика");
        var head = new HeadOfDepartment("Ольга Петровна", "Компьютерные науки");

        List<Person> people = new List<Person> { student, teacher, head };

        Console.WriteLine("Список персон:");
        foreach (var person in people)
        {
            person.DisplayRole();
        }

        Console.WriteLine("\nВыполнение обязанностей сотрудников:");
        var employees = new List<IUniversityEmployee> { teacher, head };
        foreach (var employee in employees)
        {
            employee.PerformDuties();
        }
    }
}