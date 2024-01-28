using System;
using System.Diagnostics;
using System.Text;

class Word
{
    private readonly string _text;
    private StringBuilder _textToShow;
    private bool _isHidden = false;

    public Word(string text)
    {
        _text = text;
        _textToShow = new StringBuilder(text);
    }

    public void Hide()
    {
        _isHidden = true;
        _textToShow = new StringBuilder(new string('_', _text.Length));
    }

    public void Show()
    {
        Console.WriteLine(_text);
        _isHidden = false;
        _textToShow = new StringBuilder(_text);
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _textToShow.ToString();
    }

    private bool IsStringComplete()
    {
        foreach (char character in _textToShow.ToString())
        {
            if (character == '_')
            {
                return false;
            }
        }

        return true;
    }

    public void ShowLetter(string userLetter)
    {
        if (_isHidden == true)
        {
            userLetter = userLetter.ToLower();

            for (int i = 0; i < _text.Length; i++)
            {
                string originalLetter = _text[i].ToString().ToLower();
                string letterToShow = _textToShow[i].ToString().ToLower();

                if (letterToShow == "_" && userLetter == originalLetter)
                {
                    _textToShow[i] = originalLetter[0];
                }
            }

            if (IsStringComplete() == true)
            {
                Show();
                return;
            }
        }
    }
}