using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] splitWords = text.Split(' ');
        foreach (string wordText in splitWords)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        // Se implementará la lógica completa en el proyecto final
    }

    public string GetDisplayText()
    {
        string renderedText = "";
        foreach (Word word in _words)
        {
            renderedText += word.GetDisplayText() + " ";
        }
        return $"{_reference.GetDisplayText()} {renderedText.Trim()}";
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }
}