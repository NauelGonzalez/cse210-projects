using System;

class Program
{
    static void Main(string[] args)
    {

        int number = -1;
        List<int> numbers = new List<int>();
        int max = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        Console.WriteLine($"The sum is {numbers.Sum()}");
        Console.WriteLine($"The average is {numbers.Average()}");
        foreach (int n in numbers)
        {
            if (n > max)
                max = n;
        }
        Console.WriteLine($"The max value is {max}");
    }





}
