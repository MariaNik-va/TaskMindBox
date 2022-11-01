namespace TextTaskMindBox;

public class Triangle : IFigure
{
    private readonly double _firstSide;
    private readonly double _secondSide;
    private readonly double _thirdSide;

    public double FirstSide => _firstSide;
    public double SecondSide => _secondSide;
    public double ThirdSide => _thirdSide;

    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        FigureHelper.Validate(firstSide);
        FigureHelper.Validate(secondSide);
        FigureHelper.Validate(thirdSide);

        if (firstSide >= secondSide + thirdSide
            || secondSide >= firstSide + thirdSide
            || thirdSide >= firstSide + secondSide)
            throw new ArgumentOutOfRangeException("One side is greater than sum of other two");

        _firstSide = firstSide;
        _secondSide = secondSide;
        _thirdSide = thirdSide;
    }

    public double CalculateArea()
    {
        var semiperimeter = (_firstSide + _secondSide + _thirdSide) / 2.0;

        return Math.Sqrt(semiperimeter
            * (semiperimeter - _firstSide)
            * (semiperimeter - _secondSide)
            * (semiperimeter - _thirdSide));
    }

    public bool IsRectangular()
    {
        return _firstSide * _firstSide + _secondSide * _secondSide == _thirdSide * _thirdSide
            || _firstSide * _firstSide + _thirdSide * _thirdSide == _secondSide * _secondSide
            || _secondSide * _secondSide + _thirdSide * _thirdSide == _firstSide * _firstSide;
    }
}
