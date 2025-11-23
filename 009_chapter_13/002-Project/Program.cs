Console.Write("Enter circle radius: ");
int radius = int.Parse(Console.ReadLine());
Circle circle = new(radius: radius);
Console.WriteLine($"{InfoAboutShape.GetName(circle)} area (r = {circle.Radius}): {InfoAboutShape.GetArea(circle)}");

Console.Write("\nEnter triangle sides via space: ");
string sides = Console.ReadLine();
try
{
    int sideA = int.Parse(sides.Split(" ")[0]);
    int sideB = int.Parse(sides.Split(" ")[1]);
    int sideC = int.Parse(sides.Split(" ")[2]);
    Triangle triangle = new(sideA: sideA, sideB: sideB, sideC: sideC);
    Console.WriteLine($"{InfoAboutShape.GetName(triangle)} area (a = {sideA}, b = {sideB}, c = {sideC}): {InfoAboutShape.GetArea(triangle)}");
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine($"ERROR ({ex.GetType().Name}): incorrect input (necessary to enter 3 sides via SPACE)");
}
catch (FormatException ex)
{
    Console.WriteLine($"ERROR ({ex.GetType().Name}): incorrect input (necessary to enter 3 integers)");
}

Console.Write("\nEnter side of square: ");
int side = int.Parse(Console.ReadLine());
Square square = new(side: side);
Console.WriteLine($"{InfoAboutShape.GetName(square)} area (side = {square.Side}): {InfoAboutShape.GetArea(square)}");