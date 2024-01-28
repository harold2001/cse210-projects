using System;

class Scripture
{
    private readonly Reference _reference;
    private readonly List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new();

        for (int i = 0; i < numberToHide; i++)
        {
            List<Word> wordsShown = GetShownWords();
            int randomIndex = random.Next(0, wordsShown.Count);
            Word word = wordsShown[randomIndex];
            word.Hide();
        }
    }

    public void GetDisplayText()
    {
        string completeScripture = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        string referenceText = _reference.GetDisplayText();

        Console.WriteLine($"{referenceText} {completeScripture}");
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }

        return true;
    }

    public List<Word> GetShownWords()
    {
        List<Word> wordsShown = _words.Where(word => word.IsHidden() == false).ToList();
        return wordsShown;
    }

    public List<Word> GetHiddenWords()
    {
        List<Word> hiddenWords = _words.Where(word => word.IsHidden() == true).ToList();
        return hiddenWords;
    }

    public void GuessWithLetter(string letter)
    {
        foreach (Word word in GetHiddenWords())
        {
            word.ShowLetter(letter);
        }
    }
}