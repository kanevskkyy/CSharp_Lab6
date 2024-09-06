using System;
using System.Collections.Generic;
using task_4;


public class Program
{
    static void Main()
    {
        Console.Write("Enter information of foods = ");
        string input = Console.ReadLine();
        try
        {
            if (input.Length > 1000) throw new ArgumentException("Length of symbols cannot be more than 1000");
        }
        catch(ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
            Environment.Exit(0);
        }

        string[] foods = input.Split();
        try
        {
            if(foods.Length < 1 || foods.Length > 100) throw new ArgumentException("Amount of foods should be in range [1 .. 100]");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
            Environment.Exit(0);
        }

        int result = 0;
        for (int i = 0; i < foods.Length; i++)
        {
            Food food = FoodFactory.CreateFood(foods[i]);
            result += food.HappinessPoints();
        }

        Mood mood = MoodFactory.CreateMood(result);
        Console.WriteLine($"Total points : {result}");
        Console.WriteLine($"Mood : {mood.MoodName()}");
    }
}
