using FigureArea;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace UnitTests;

public class TriangleTests
{
    [TestCase(5, 5.123, 10)]
    public void Triangle_Test_Correct_Sides(double sideA, double sideB, double sideC)
    {
        const double expectedArea = 3.93284d;
        double area = Figure.GetTriangle(sideA, sideB, sideC).GetArea();

        Assert.That(Math.Abs(Math.Round(area, 5) - expectedArea), Is.LessThan(double.Epsilon));
    }

    [TestCase(10, 1, 1)]
    [TestCase(-1, -1, -1)]
    [TestCase(0, 0, 0)]
    [TestCase(0, -1, 10)]
    public void Triangle_Test_Incorrect_Sides(double sideA, double sideB, double sideC)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            FigureArea.Figure.GetTriangle(sideA, sideB, sideC);
        });
    }

    [TestCase(3, 4, 5, ExpectedResult = true)]
    [TestCase(3.0, 4.0, 5.0, ExpectedResult = true)]
    [TestCase(2, 3, 4, ExpectedResult = false)]
    public bool Triangle_Test_Is_Triangle_Right(double sideA, double sideB, double sideC)
    {
        var triangle = Figure.GetTriangle(sideA, sideB, sideC);

        return triangle.IsRight;
    }
}