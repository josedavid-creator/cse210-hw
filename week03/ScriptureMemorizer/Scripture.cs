using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordsArray = text.Split(' ');
        foreach (string wordText in wordsArray)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        List<Word> unhiddenWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                unhiddenWords.Add(word);
            }
        }

        if (unhiddenWords.Count < numberToHide)
        {
            numberToHide = unhiddenWords.Count;
        }

        Random random = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(unhiddenWords.Count);
            unhiddenWords[index].Hide();
            
            unhiddenWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string scriptureText = "";
        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }
        
        return $"{_reference.GetDisplayText()} {scriptureText.TrimEnd()}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}