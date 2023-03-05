namespace FigureArea.Shapes;

internal class Triangle : ITriangle
{
    private double SideA { get; }
    private double SideB { get; }
    private double SideC { get; }
    
    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public bool IsRight
    {
        get
        {
            bool isRight = false;
            
            double ab = double.Hypot(SideA, SideB);
            if (Math.Abs(ab - SideC) < double.Epsilon) isRight = true;

            double bc = double.Hypot(SideB, SideC);
            if (Math.Abs(bc - SideA) < double.Epsilon) isRight = true;

            double ac = double.Hypot(SideA, SideC);
            if (Math.Abs(ac - SideB) < double.Epsilon) isRight = true;

            return isRight;
        }
    }

    public double GetArea()
    {
        double halfPerimeter = (SideA + SideB + SideC) * 0.5;
        double area = Math.Sqrt(halfPerimeter 
                                * (halfPerimeter - SideA) 
                                * (halfPerimeter - SideB) 
                                * (halfPerimeter - SideC));

        return area;
    }
}