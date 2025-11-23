// класс-заглушка для некорректных фигур
class IncorrectShape : IShape
{
    public (string, double) GetShapeInfo()
    {
        return ("Incorrect shape", -1);
    }
}