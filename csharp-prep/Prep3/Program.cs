using System;

internal class NewBaseType
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        int MN = 0;
        int guess = -1;
        int count = 0;
        string keepPlaying = "yes";

       
        while (keepPlaying.ToLower() == "yes"){
            guess = -1;
            MN = randomGenerator.Next(1, 11);
            count = 0;
            while (MN != guess)
            {
                Console.WriteLine("What is your guess?");
                guess = int.Parse(Console.ReadLine());
                if (MN > guess)
                    Console.Write("Higher \n");
                else if (MN == guess)
                    Console.Write("You guessed it!");
                else
                    Console.Write("Lower \n");
                count++;
            };
            Console.WriteLine($"You made {count} guesses");
            Console.WriteLine("To keep plying type 'yes'");
            keepPlaying = Console.ReadLine();
        }
    }
}
