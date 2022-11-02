namespace TaskMindBox;

public class Circle : IFigure
{
    private readonly double _radius;

    public double Radius => _radius;

    public Circle(double radius)
    {
        FigureHelper.Validate(radius);

        _radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * _radius * _radius;
    }
}
