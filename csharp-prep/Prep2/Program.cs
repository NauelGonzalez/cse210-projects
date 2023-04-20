using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your percent?");
        int percent = int.Parse(Console.ReadLine());
        string grade = "";
        string sign = "";

        if (percent % 10 >= 7)
            sign = "+";
        else 
            sign = "-";

        if (percent >= 90 && sign == "+")
            grade = "A";
        else if (percent >= 90)
            grade = "A" + sign;
        else if (percent >= 80)
            grade = "B" + sign;
        else if (percent >= 70)
            grade = "C" + sign;
        else if (percent >= 60)
            grade = "D" + sign;
        else if (percent < 60)
            grade = "F";

        if (grade != "F")
            Console.WriteLine ($"Congratulations, you pass with {grade} score");
        else
            Console.WriteLine ($"Sorry, {grade} score is not enough to pass. Good luck next time!");

    }
}