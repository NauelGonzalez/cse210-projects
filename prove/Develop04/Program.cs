using System;

class Program
{
    static void Main(string[] args)
    {


        int choice = -1;
        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start Listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice){
                case 1:
                    BreathActivity ba = new BreathActivity();
                    ba.RunActivity();
                    break;

                default:
                    Console.ReadLine();
                    break;
            }


}

    }
}