class Scripture
{
    public string Reference { get; set; }
    public string Text { get; set; }
    public bool[] HiddenWords { get; set; }

    public Scripture(string reference, string text)
    {
        Reference = reference;
        Text = text;
        HiddenWords = new bool[text.Split(' ').Length];
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int hiddenCount = 0;
        for (int i = 0; i < HiddenWords.Length; i++)
        {
            if (!HiddenWords[i] && random.NextDouble() < 0.5)
            {
                HiddenWords[i] = true;
                hiddenCount++;
            }
        }
        if (hiddenCount == 0)
        {
            HiddenWords[random.Next(HiddenWords.Length)] = true;
        }
    }

    public string GetDisplayText()
    {
        string[] words = Text.Split(' ');
        string displayText = "";
        for (int i = 0; i < words.Length; i++)
        {
            if (HiddenWords[i])
            {
                displayText += "_____ ";
            }
            else
            {
                displayText += words[i] + " ";
            }
        }
        return displayText;
    }
}