using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Console.WriteLine();
        Console.WriteLine();
        Assignment a = new Assignment("Nauel Gonzalez"," CSE210");
        //Console.WriteLine(a.GetSummary());        

        MathAssignment ma = new MathAssignment("Nauel Gonzalez","CSE210","Week 4","Math 1-3");
        //Console.WriteLine(ma.GetSummary());
        //Console.WriteLine(ma.GetHomeworkList());

        WritingAssignment wa = new WritingAssignment("Nauel Gonzalez", "CSE210", "A writing Assingment");
        Console.WriteLine(wa.GetSummary());
        Console.WriteLine(wa.GetWritingInformation());
    }
}