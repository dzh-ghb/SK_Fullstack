class Square(int side) : IShape
{
    public int Side { get; } = side;

    public (string name, double area) GetShapeInfo()
    {
        double area = Math.Round(Math.Pow(Side, 2), 2);
        return ("Square", area);
    }
}