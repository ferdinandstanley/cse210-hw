using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 95)
        {
            letter = "A";
        }
        else if (percent >= 75)
        {
            letter = "B";
        }
        else if (percent >= 65)
        {
            letter = "C";
        }
        else if (percent >= 55)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (percent >= 75)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Try again next time");
        }
    }
}