using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        Square s = new Square("red", 6);
        Rectangle r = new Rectangle("green", 6,4);
        Circle c = new Circle("blue", 8);


        List<Shape> shapeList = new List<Shape>();
        shapeList.Add(s);
        shapeList.Add(r);
        shapeList.Add(c);

        Console.WriteLine(shapeList.Count());

        for (int i = shapeList.Count()-1; i >= 0;i--){
                Console.WriteLine($"Square color: {shapeList[i].GetColor()}, area: {shapeList[i].GetArea().ToString()} cm2");
        }


        Console.WriteLine();

        foreach (Shape shap in shapeList){
            Console.WriteLine($"Square color: {shap.GetColor()}, area: {shap.GetArea().ToString()} cm2");
        }

    }
}