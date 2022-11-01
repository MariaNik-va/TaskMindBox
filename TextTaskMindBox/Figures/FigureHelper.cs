namespace TextTaskMindBox;

public static class FigureHelper
{
    public static void Validate(double value)
    {
        if (value < 0)
            throw new ArgumentOutOfRangeException("Value cannot be negative");
        if (value == 0)
            throw new ArgumentOutOfRangeException("Value cannot be 0");
        if (double.IsNaN(value))
            throw new ArgumentOutOfRangeException("Value cannot be NaN");
        if (double.IsInfinity(value))
            throw new ArgumentOutOfRangeException("Value cannot be infinity");
    }
}
