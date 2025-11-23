class Triangle(int sideA, int sideB, int sideC) : IShape // имплементация интерфейса
{
    private int sideA = sideA;
    private int sideB = sideB;
    private int sideC = sideC;
    private double halfMeter = (double)(sideA + sideB + sideC) / 2; // полупериметр

    // метод получения информации о фигуре (название, площадь)
    public (string name, double area) GetShapeInfo()
    {
        if (!IsTriangleCorrect()) return new IncorrectShape().GetShapeInfo();
        double area = Math.Round(Math.Sqrt(halfMeter * (halfMeter - sideA) * (halfMeter - sideB) * (halfMeter - sideC)), 2);
        return ("Triangle", area);
    }

    // проверка - образуют ли три стороны правильный треугольник
    private bool IsTriangleCorrect()
    {
        return sideA < sideB + sideC && sideB < sideA + sideC && sideC < sideA + sideB;
    }
}