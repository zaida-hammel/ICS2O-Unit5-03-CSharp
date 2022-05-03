using System;

class Program
{
    public static void Main(string[] args)
    {
        int userAge;

        Console.WriteLine("Write your age:");
        userAge = int.Parse(Console.ReadLine());
        if (userAge > 17)
        {
            Console.WriteLine("You are eligible to watch R rated movies alone.");
            Console.ReadLine();
        }
        else if (userAge > 12)
        {
            Console.WriteLine("You are eligible to watch PG 13 rated movies alone.");
            Console.ReadLine();
        }
        else if (userAge > 4)
        {
            Console.WriteLine("You are eligible to watch G and PG rated movies alone.");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("You are eligible to watch G and PG rated movies alone.");
            Console.ReadLine();
        }
    }
}