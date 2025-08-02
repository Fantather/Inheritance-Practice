using Inheritance_Practice.Task_4;

List<Figure> figures = new List<Figure>();
figures.Add(new Rectangle(4, 5));
figures.Add(new Circle(3));
figures.Add(new RightTriangle(5, 6));
figures.Add(new Trapezoid(4, 3, 5));

foreach (Figure f in figures)
{
    Console.WriteLine($": {f.GetArea()}");
}