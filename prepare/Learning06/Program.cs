using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square s1 = new Square("pink", 5);
        Square s2 = new Square("purple", 3);
        Rectangle s3 = new Rectangle("white", 2,4);
        Rectangle s4 = new Rectangle("yellow",10, 5);
        Circle s5 = new Circle("red", 4);
        Circle s6 = new Circle("black", 1.5);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"The {color} shape has the area of {area}.");
        }

    }
}