using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture s = new Scripture(); //Create a new scripture using "random scripture" constructor. This cons will get random scripture from text file.

        string option = "";

        while (s.CountVisibleWords() >= 1 && option.ToUpper() != "QUIT")
        {
            if (option.ToUpper() == "OPTIONS")  //Added this for exceed requirements, this will allow user to get new random scripture or create custom one.
            {
                s = SetOptions(s);
                option = "";
            }
            Console.Clear();
            s.Display();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press enter to keep playing, type 'options' to change game settings or type 'quit' to exit");
            option = Console.ReadLine();
            s.HideWord();  //Hide method will hide only alphanumeric characters, leaving punctuations to make game more "friendly"

        }



        //Function to change game options
        Scripture SetOptions(Scripture s) 
        {
            Console.Clear();
            Console.WriteLine("Choose one of the following options to configure game:");
            Console.WriteLine("1 - Get a new random scripture");
            Console.WriteLine("2 - Create a new custom scripture");
            Console.WriteLine();
            int o = int.Parse(Console.ReadLine());
            if (o == 1)
            {
                s = new Scripture();
            }
            if (o == 2)
            {
                string book = "";
                string chapter = "";
                int from = -1;
                int to = -1;
                string scriptureText = "";


                Console.WriteLine("Please type the Book name: ");
                book = Console.ReadLine();
                Console.WriteLine("Please type the chapter: ");
                chapter = Console.ReadLine();
                Console.WriteLine("Please type the starting verse number: ");
                from = int.Parse(Console.ReadLine());
                Console.WriteLine("Please type the finish verse number. If it is a single verse scripture then type the start verse again: ");
                to = int.Parse(Console.ReadLine());
                Console.WriteLine("Please type the verse text: ");
                scriptureText = Console.ReadLine();

                if (to <= from)
                {
                    Reference r = new Reference(book, chapter, from);
                    s = new Scripture(scriptureText, r);
                }
                else
                {
                    Reference r = new Reference(book, chapter, from, to);
                    s = new Scripture(scriptureText, r);
                }

            }
            return s;
        }

    }



}

