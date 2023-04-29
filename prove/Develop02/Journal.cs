
public class Journal
{

    public List<Entry> _entries = new List<Entry>();
    public string _fileName = "";

    public void Display()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
            Console.WriteLine();
        }
    }

    public void AddEntry(Entry e)
    {
        _entries.Add(e);
    }

     public void RemoveEntry()
    {
        try{
        _entries.RemoveAt(_entries.Count - 1);
        }
        catch{
            Console.WriteLine("Cannot remove the element. Use the display function and make sure you have elements to remove.");
        }
    }

    public void LatestEntry()
    {
        if (_entries.Count > 0)
        {
            _entries[_entries.Count - 1].Display();
        }
        else
            Console.WriteLine("There are no entries recorded on Journal.");
    }

    public void SaveJournal()
    {
        try
        {
            Console.WriteLine("Enter the full path and filename");
            string fullPath = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                foreach (Entry e in _entries)
                {
                    writer.WriteLine(e.EntrySaveLine());
                }
            }
        }
        catch (Exception e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"There was an error, please validate the filename and try again. Error details: {e}");
            Console.ResetColor();
        }
    }


    public void LoadJournal()
    {
        try
        {
            Console.WriteLine("Enter the full path and filename");
            string fullPath = Console.ReadLine();
            

            string[] lines = File.ReadAllLines(fullPath);
            foreach (string line in lines)
            {
                Entry e = new Entry();
                e.EntryLoadLine(line);
                if (e._textEntry != "")
                   _entries.Add(e);
                
            }

        }
        catch (Exception e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"There was an error, please validate the filename and try again. Error details: {e}");
            Console.ResetColor();
        }
    }

}