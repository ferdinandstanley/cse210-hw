class Word
{
    private string text;
    private bool isHidden;

    public Word(string text)
    {
        this.text = text;
        this.isHidden = false;
    }

    // Hide the word
    public void Hide()
    {
        isHidden = true;
    }

    public string Display()
    {
        if (isHidden)
        {
            return new string('_', text.Length); // Hide the Word with underscore
        }
        else
        {
            return text;
        }
    }

    // Check if word is hidden
    public bool IsHidden()
    {
        return isHidden;
    }
}