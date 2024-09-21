using System;

class Program
{
    static void Main(string[] args)
    {
        // For Parts 1 and 2, where the user specified the number...
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());
        
        // For Part 3, where we use a random number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        Console.WriteLine("I'm thinking of a number between 1 and 100. Can you guess what it is?");

    
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();

            if (response != "no")
            {
                Console.WriteLine("Great news");
            }
            
            else if (response !="yes")
            {
                Console.WriteLine("Ooops");
            }

            Console.WriteLine("Thanks for playing!");

        }
            
    }
}