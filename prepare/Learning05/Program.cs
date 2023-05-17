using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        Square s = new Square("red", 6);
        Console.WriteLine($"Square color: {s.GetColor()}, area: {s.GetArea().ToString()}");
        

        Rectangle r = new Rectangle("green", 6,4);
        Console.WriteLine($"Square color: {r.GetColor()}, area: {r.GetArea().ToString()}");

        Circle c = new Circle("blue", 8);
        Console.WriteLine($"Square color: {c.GetColor()}, area: {c.GetArea().ToString()}");

    }
}