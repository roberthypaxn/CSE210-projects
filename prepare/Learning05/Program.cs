using System;

class Program
{
    static void Main(string[] args)
    {
        Square sq = new Square("indigo blue", (float)4.5);
        Circle crcl = new Circle("Mauve", (float)4.7);
        Rectangle rect = new Rectangle("Green", (float)4, (float)5);

        string col = sq.GetColor();
        string colo = crcl.GetColor();
        string color = rect.GetColor();

        float areaOfSquare = sq.GetArea();
        float areaOfCircle = crcl.GetArea();
        float areaOfRectangle = rect.GetArea();

        Console.WriteLine();
        Console.WriteLine($"The color is {col}, and the area is equal to {areaOfSquare}");
        Console.WriteLine($"The color is {colo}, and the area is equal to {areaOfCircle}");
        Console.WriteLine($"The color is {color}, and the area is equal to {areaOfRectangle}");


    }

}