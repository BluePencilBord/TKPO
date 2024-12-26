using System;
using System.Collections.Generic;

public class Course
{
    public string Name { get; }
    private List<Teacher> teachers;
    private List<Student> students;

    public Course(string name)
    {
        Name = name;
        teachers = new List<Teacher>();
        students = new List<Student>();
    }

    public void AddTeacher(Teacher teacher)
    {
        teachers.Add(teacher);
        Console.WriteLine($"Преподаватель {teacher.Name} добавлен на курс {Name}.");
    }

    public void AddStudent(Student student)
    {
        students.Add(student);
        Console.WriteLine($"Студент {student.Name} записан на курс {Name}.");
    }

    public List<Teacher> GetTeachers()
    {
        return new List<Teacher>(teachers);
    }

    public List<Student> GetStudents()
    {
        return new List<Student>(students);
    }
}

public class Teacher
{
    public string Name { get; }

    public Teacher(string name)
    {
        Name = name;
    }

    public void GradeStudent(Course course, Student student, int grade, Archive archive)
    {
        if (!course.GetStudents().Contains(student))
        {
            Console.WriteLine($"Студент {student.Name} не записан на курс {course.Name}.");
            return;
        }

        if (!course.GetTeachers().Contains(this))
        {
            Console.WriteLine($"Преподаватель {Name} не назначен на курс {course.Name}.");
            return;
        }

        archive.SaveGrade(course, student, new Grade(this, student, grade));
    }
}

public class Student
{
    public string Name { get; }

    public Student(string name)
    {
        Name = name;
    }

    public void Enroll(Course course)
    {
        course.AddStudent(this);
    }
}

public class Grade
{
    public Teacher Teacher { get; }
    public Student Student { get; }
    public int Value { get; }

    public Grade(Teacher teacher, Student student, int value)
    {
        Teacher = teacher;
        Student = student;
        Value = value;
    }
}

public class Archive
{
    private List<(Course course, Student student, Grade grade)> records;

    public Archive()
    {
        records = new List<(Course, Student, Grade)>();
    }

    public void SaveGrade(Course course, Student student, Grade grade)
    {
        records.Add((course, student, grade));
        Console.WriteLine($"Оценка {grade.Value} сохранена для студента {student.Name} на курсе {course.Name} (Преподаватель: {grade.Teacher.Name}).");
    }

    public void ShowArchive()
    {
        Console.WriteLine("\nАрхив оценок:");
        foreach (var record in records)
        {
            Console.WriteLine($"Курс: {record.course.Name}, Студент: {record.student.Name}, Оценка: {record.grade.Value}, Преподаватель: {record.grade.Teacher.Name}");
        }
    }
}

public class Program
{
    static void Main(string[] args)
    {
        var course = new Course("Программирование 101");
        var teacher1 = new Teacher("Профессор Иванов");
        var teacher2 = new Teacher("Доктор Петров");
        var student = new Student("Алиса");

        var archive = new Archive();

        course.AddTeacher(teacher1);
        course.AddTeacher(teacher2);
        student.Enroll(course);

        teacher1.GradeStudent(course, student, 95, archive);
        teacher2.GradeStudent(course, student, 88, archive);

        archive.ShowArchive();
    }
}