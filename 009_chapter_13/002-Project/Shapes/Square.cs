class Square(int side) : IShape
{
    private int side = side;

    public (string name, double area) GetShapeInfo()
    {
        double area = Math.Round(Math.Pow(side, 2), 2);
        return ("Square", area);
    }
}