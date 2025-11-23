class IncorrectShape : IShape
{
    public (string, double) GetShapeInfo()
    {
        return ("Incorrect shape", -1);
    }
}