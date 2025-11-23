class Triangle(int sideA, int sideB, int sideC) : IShape
{
    public int SideA { get; } = sideA;
    public int SideB { get; } = sideB;
    public int SideC { get; } = sideC;
    private double halfMeter = (double)(sideA + sideB + sideC) / 2;

    public (string name, double area) GetShapeInfo()
    {
        if (!IsTriangleCorrect()) return new IncorrectShape().GetShapeInfo();
        double area = Math.Round(Math.Sqrt(halfMeter * (halfMeter - SideA) * (halfMeter - SideB) * (halfMeter - SideC)), 2);
        return ("Triangle", area);
    }

    private bool IsTriangleCorrect()
    {
        return SideA < SideB + SideC && SideB < SideA + SideC && SideC < SideA + SideB;
    }
}