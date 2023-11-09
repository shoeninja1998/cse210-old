using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new();

        Square shape1 = new("Blue", 1);
        Rectangle shape2 = new("Red", 5, 8);
        Circle shape3 = new("Yellow", 4);

        shapes.Add(shape1);
        shapes.Add(shape2);
        shapes.Add (shape3);

        foreach (Shape s in shapes){
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The shape is {area} inches big and is the color {color}.");
        }


    }
}