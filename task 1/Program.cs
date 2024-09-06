using System;
using task_1;

class Task
{
    static void Main()
    {
        Console.Write("Enter author name and surname = ");
        string author = Console.ReadLine();
        
        Console.Write("Enter book name = ");
        string title = Console.ReadLine();

        Console.Write("Enter price of book = ");
        decimal price = Decimal.Parse(Console.ReadLine());
        
        Book book = new Book(author, title, price);
        Console.WriteLine("\n" + book + "\n");

        GoldenBook golden_book = new GoldenBook(author, title, price);
        Console.WriteLine(golden_book);
    }
    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}