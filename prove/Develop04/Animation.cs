class Animation
{


    public Animation()
    {
    }


    public void CountDown(int duration)
    {

        int counter = duration;
        while (counter > 0)
        {
            Console.Write(counter);
            Thread.Sleep(1000);
            ClearCurrentConsoleLine();
            counter--;

        }


    }


    public void Arrows(int duration)
    {

        List<string> arrowParts = new List<string>();
        for (int i = 0; i < duration; i++){
            arrowParts.Add("\u25B7 ");
        }


        for (int j = 0; j <= arrowParts.Count()-1;j++)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            foreach(string s in arrowParts){
                Console.Write(s);
            }
            Thread.Sleep(1000);
            ClearCurrentConsoleLine();
            arrowParts[j] = "\u25B6 ";

        }
      
    }

    public void Spinning(int duration)
    {
        List<string> c = new List<string>() { "|", "/", "-", "\\", "|", "-", "\\" };
        int counter = duration * 2;
        int clen = c.Count() - 1;
        while (counter > 0)
        {
            Console.Write(c[clen]);
            if (clen == 0)
                clen = 3;
            else
                clen--;
            Thread.Sleep(500);
            Console.Write(Clean(counter));
            counter--;

        }

    }

    public void ThinkingDots(int duration)
    {
        int counter = 1;
        Console.WriteLine();
        while (counter <= duration)
        {
            for (int i = 1; i <= 4; i++)
            {
                Console.Write(".");
                Thread.Sleep(250);
            }
            Console.Write(Clean(1000));
            counter++;
        }

    }


    private string Clean(int duration = 0)
    {
        int countCharacters = duration.ToString().Length;
        //if (lenght != "")
        //  countCharacters = lenght.Length;
        string clean = "";
        while (countCharacters > 0)
        {
            clean = clean + "\b \b";
            countCharacters--;
        }
        return clean;

    }

    private void ClearCurrentConsoleLine()
    {
        int currentLineCursor = Console.CursorTop;
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, currentLineCursor);
    }


}