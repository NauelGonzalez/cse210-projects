using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        Square s = new Square("red", 6);
        Rectangle r = new Rectangle("green", 6,4);
        Circle c = new Circle("blue", 8);


        List<Shape> l = new List<Shape>();
        l.Append(s);
        l.Append(r);
        l.Append(c);

        foreach (Shape shap in l){
                Console.WriteLine($"Square color: {shap.GetColor()}, area: {shap.GetArea().ToString()}");
        }

    }
}