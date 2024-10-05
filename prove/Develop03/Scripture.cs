class Scripture
{
    private ScriptureReference reference;
    private List<Word> words;
    private Random rand;

    public Scripture(ScriptureReference reference, string text)
    {
        this.reference = reference;
        words = new List<Word>();
        rand = new Random();

        // Split the text into words and create Word objects
        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            words.Add(new Word(word));
        }
    }

    // Display the scripture with reference
    public void Display()
    {
        Console.WriteLine(reference.DisplayReference());

        foreach (Word word in words)
        {
            Console.Write(word.Display() + " ");
        }
        Console.WriteLine();
    }

    // Hide a few random words
    public void HideRandomWords()
    {
        int numberOfWordsToHide = rand.Next(1, 4); // Hide 1 to 3 words at a time
        for (int i = 0; i < numberOfWordsToHide; i++)
        {
            int randomIndex = rand.Next(words.Count);
            words[randomIndex].Hide();
        }
    }

    // Check if all words are hidden
    public bool AllWordsHidden()
    {
        foreach (Word word in words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}