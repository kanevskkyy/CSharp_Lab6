using System;
using task_2;

class Task
{
    static void Main()
    {
        Console.Write("Enter information about student : {Name} {Surname} {Faculty number} = ");
        string[] student_information = Console.ReadLine().Split();
        Student student = new Student(student_information[0], student_information[1], int.Parse(student_information[2]));

        Console.Write("Enter information about worker : {Name} {Surname} {Week salary} {Hours per day} = ");
        string[] worker_information = Console.ReadLine().Split();
        Worker worker = new Worker(worker_information[0], worker_information[1], double.Parse(worker_information[2]), double.Parse(worker_information[3]));

        Console.WriteLine(student);
        Console.Write(worker);

    }
    public static void line()
    {
        Console.WriteLine("=======================================");
    }
}