using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a scripture reference and text
        ScriptureReference reference = new ScriptureReference("1 Nephi", 3, 8, 9);
        string text = "And it came to pass that when my father had heard these words he was exceedingly \nglad "+
        @"for he knew that I had been blessed of the Lord.... "+
        @"9.And I, Nephi, and my brethren took our journey in the wilderness with our tents, to go up to the land of Jerusalem.";
        Scripture scripture = new Scripture(reference, text);

        // Main loop
        bool running = true;
        while (running)
        {
            Console.Clear();
            scripture.Display(); // Display the scripture with reference

            // Prompt user for input
            Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                running = false;
            }
            else
            {
                scripture.HideRandomWords(); // Hide random words progressively
                if (scripture.AllWordsHidden())
                {
                    Console.Clear();
                    scripture.Display();
                    Console.WriteLine("\nAll words are hidden. The program will now end.");
                    running = false;
                }
            }
        }
    }
}