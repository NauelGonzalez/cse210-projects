

using System;
using System.Text.RegularExpressions;

class Word
{

    private string _word;
    private bool _isVisible;


    public Word() { }
    public Word(string word)
    {
        _word = word;
        _isVisible = true;
    }

    public Word(string word, bool status)
    {
        _word = word;
        _isVisible = status;
    }

    private string hide()
    {

        Regex rgx = new Regex("[a-zA-Z0-9 -]");  //Will replace only letters and numbers, leaving punctuations to work as guide.
        string hiddenWord = rgx.Replace(_word, "_");
        return hiddenWord;
    }

    public void Display()
    {
        if (_isVisible == false)
            Console.Write(hide());
        else
            Console.Write(_word);
    }

    public string GetWord()
    {

        if (_isVisible == false)
            return hide();
        else
            return _word;
    }
    public void SetVisible(bool status)
    {
        _isVisible = status;
    }
    public void SetWord(string word)
    {
        _word = word;
    }

    public bool GetIsVisible()
    {
        return _isVisible;
    }

    //Not using this for now. If have time will adapt program to hide only certain lenght words.
    public int GetLenght()
    {
        return _word.Length;
    }

}
