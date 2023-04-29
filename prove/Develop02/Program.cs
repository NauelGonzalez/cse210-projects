using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = -1;
        Journal journal = new Journal();
        while (choice != 7)
        {
            PrintMenu();

            try
            {
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {

                    case 1:
                        PromptGen p = new PromptGen();
                        Entry e = new Entry();

                        e._textQuestion = p.getPrompt();
                        e._textEntry = Console.ReadLine();
                        e._entryDate = DateTime.Now;
                        journal.AddEntry(e);

                        break;
                    case 2:
                        journal.RemoveEntry();
                        Console.WriteLine("type any key to continue...");
                        Console.Read();
                        break;
                    case 3:
                        if (journal._entries.Count > 0)
                            journal.Display();
                        else
                            Console.WriteLine("No entries to display. Add some entries using option 1");
                        Console.WriteLine("type any key to continue...");
                        Console.Read();
                        break;
                    case 4:
                        journal.LatestEntry();
                        Console.WriteLine("type any key to continue...");
                        Console.Read();
                        break;
                    case 5:
                        journal.LoadJournal();
                        Console.WriteLine("type any key to continue...");
                        Console.Read();
                        break;
                    case 6:
                        journal.SaveJournal();
                        Console.WriteLine("type any key to continue...");
                        Console.Read();
                        break;
                    case 7:
                        Console.WriteLine("Thanks for using the Journal Program.");
                        break;
                    default:
                        choice = -1;
                        break;
                }


            }
            catch
            {
                choice = -1;
            }


        }




    }

    static void PrintMenu()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine();
        Console.WriteLine("Please select one of the Following Choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Delete lastest entry");
        Console.WriteLine("3. Display");
        Console.WriteLine("4. Display last entry");
        Console.WriteLine("5. Load");
        Console.WriteLine("6. Save");
        Console.WriteLine("7. Quit");
    }

}