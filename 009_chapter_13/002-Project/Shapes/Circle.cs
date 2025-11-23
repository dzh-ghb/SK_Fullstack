class Circle(int radius) : IShape
{
    public int Radius { get; } = radius;

    public (string name, double area) GetShapeInfo()
    {
        double area = Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        return ("Circle", area);
    }
}