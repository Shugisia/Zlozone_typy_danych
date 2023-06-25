using System;

public enum Plec
{
    Mezczyzna,
    Kobieta
}

public struct Student
{
    public string lastName;
    public int studentId;
    public float grade;
    public Plec gender;
}

public class Program
{
    public static void Main(string[] args)
    {
        Student[] group = new Student[5];

        for (int i = 0; i < group.Length; i++)
        {
            FillStudentData(ref group[i]);
        }

        foreach (Student student in group)
        {
            DisplayStudent(student);
        }

        float averageGrade = CalculateAverageGrade(group);
        Console.WriteLine("Średnia ocen wszystkich studentów: " + averageGrade);
    }

    public static void FillStudentData(ref Student student)
    {
        Console.WriteLine("Podaj nazwisko studenta:");
        student.lastName = Console.ReadLine();

        Console.WriteLine("Podaj numer albumu studenta:");
        student.studentId = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj ocenę studenta:");
        float grade = float.Parse(Console.ReadLine());
        student.grade = ClampGrade(grade);

        Console.WriteLine("Podaj płeć studenta (0 - Mężczyzna, 1 - Kobieta):");
        student.gender = (Plec)int.Parse(Console.ReadLine());
    }

    public static float ClampGrade(float grade)
    {
        if (grade < 2.0f)
            return 2.0f;
        if (grade > 5.0f)
            return 5.0f;
        return grade;
    }

    public static void DisplayStudent(Student student)
    {
        Console.WriteLine($"Nazwisko: {student.lastName}, Numer albumu: {student.studentId}, Ocena: {student.grade}, Płeć: {student.gender}");
    }

    public static float CalculateAverageGrade(Student[] group)
    {
        float sum = 0f;
        foreach (Student student in group)
        {
            sum += student.grade;
        }
        return sum / group.Length;
    }
}
