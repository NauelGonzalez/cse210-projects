
public class Entry
{

    public DateTime _entryDate = DateTime.Now;
    public string _textEntry = "";
    public string _textQuestion = "";

    public void Display()
    {
        if (_textEntry != "")
        {
            Console.WriteLine($"Date: {_entryDate.ToString("yyyy-MM-dd HH:mm:ss")} - Prompt: {_textQuestion}");
            Console.WriteLine($"{_textEntry}");
        }
    }

    public string EntrySaveLine()
    {

        return _entryDate.ToString("yyyy-MM-dd HH:mm:ss") + "|" + _textQuestion + "|" + _textEntry;

    }
    public void EntryLoadLine(string entryLine)
    {
        try
        {
            int pos1 = entryLine.IndexOf("|", 0);
            int pos2 = entryLine.IndexOf("|", pos1 + 1);
            _textQuestion = entryLine.Substring(pos1 + 1, pos2 - pos1 - 1);
            _textEntry = entryLine.Substring(pos2 + 1);
            _entryDate = DateTime.ParseExact(entryLine.Substring(0, pos1), "yyyy-MM-dd HH:mm:ss",
                                          System.Globalization.CultureInfo.InvariantCulture);
        }
        catch (Exception)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Line in wrong format, could not load: \"{entryLine} \". ");
            Console.ResetColor();
            _entryDate = default;
            _textEntry = "";
            _textQuestion = "";

        }

    }

}