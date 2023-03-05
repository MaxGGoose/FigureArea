using FigureArea.Shapes;

namespace FigureArea;

public static class Figure
{
    public static ICircle GetCircle(double radius)
    {
        if (radius <= double.Epsilon)
        {
            throw new ArgumentOutOfRangeException(nameof(radius), "Invalid radius.");
        }
        
        return new Circle(radius);
    }

    public static ITriangle GetTriangle(double sideA, double sideB, double sideC)
    {
        double ab = sideA + sideB;
        double bc = sideB + sideC;
        double ac = sideA + sideC;

        if (ab - sideC < double.Epsilon ||
            bc - sideA < double.Epsilon ||
            ac - sideB < double.Epsilon)
        {
            throw new ArgumentOutOfRangeException("Such triangle cannot exist", new Exception());
        }
        
        return new Triangle(sideA, sideB, sideC);
    }
}