class InfoAboutShape
{
    public static string GetName(IShape shape)
    {
        return shape.GetShapeInfo().name;
    }

    public static double GetArea(IShape shape)
    {
        return shape.GetShapeInfo().area;
    }
}