

using System;

class Scripture
{

    private List<Word> _words = new List<Word>();
    private Reference _reference;

    public Scripture(){
        LoadScriptures();
    }

    public Scripture(string scriptureText, Reference reference)
    {
        _reference = reference;
        CreateScripture(scriptureText);
    }

    private void CreateScripture(string scriptureText)
    {
        string[] words = scriptureText.Split(' ');
        foreach (string word in words)
        {
            Word w = new Word(word);
            _words.Add(w);
        }

    }

    public void Display()
    {
        _reference.DisplayReference();
        Console.WriteLine("---------------------");
        foreach (Word w in _words)
        {
            w.Display();
            Console.Write(" ");
        }
    }

    public int CountVisibleWords()
    {
        int count = 0;
        foreach (Word w in _words)
        {
            if (w.GetIsVisible() == true)
                count++;
        }
        return count;
    }

    public void HideWord()
    {
        List<int> ValidWordsIndex = new List<int>();   //Stores index of words that are not hidden
        Random rnd = new Random();
        int CountWordsToDelete = rnd.Next(1, 4);   //Determines how many words to delete 1-3
        foreach (Word w in _words)
        {
            if (w.GetIsVisible() == true)
                ValidWordsIndex.Add(_words.IndexOf(w));  //If word is not hidden add it to ValidWordsIndex list
        }

        while (CountWordsToDelete > 0)
        {
            int hidePosition = rnd.Next(0, ValidWordsIndex.Count); //Selects one random Index position for the "available" words.
            _words[ValidWordsIndex[hidePosition]].SetVisible(false);  //Gets the list of Words, selects the index value from the random choosen position on  previous line and set that to hidden
            CountWordsToDelete--;
        }

        Console.Clear();
        Display();

    }

    private void LoadScriptures()
    {
        string fullPath = "scriptures.txt";
        string[] lines = File.ReadAllLines(fullPath);
        Random r = new Random();
        int rnumber = r.Next(0, lines.Length);
        string[] scripture = lines[rnumber].Split('|');
        if (scripture[4] == "")
        {
            _reference = new Reference(scripture[1], scripture[2], int.Parse(scripture[3]));
            CreateScripture(scripture[0]);
        }
        else
        {
            _reference = new Reference(scripture[1], scripture[2], int.Parse(scripture[3]), int.Parse(scripture[4]));
            CreateScripture(scripture[0]);
        }


    }

}
