class Circle(int radius) : IShape
{
    private int radius = radius;

    public (string name, double area) GetShapeInfo()
    {
        double area = Math.Round(Math.PI * Math.Pow(radius, 2), 2);
        return ("Circle", area);
    }
}