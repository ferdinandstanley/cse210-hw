using System;

class Program
{
    static void Main(string[] args)
    {
        
        Assignment a1 = new Assignment("Stanley North", "Algebra");
        Console.WriteLine(a1.GetSummary());

        
        MathAssignment a2 = new MathAssignment("East Stanley", "Ratio", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Chinua Achiebe", "Our History", "Things Fall Apart");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}