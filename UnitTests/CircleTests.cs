using FigureArea;

namespace UnitTests;

public class Tests
{
    [Test]
    public void Circle_Test_Correct_Radius()
    {
        const double radius = 10.0;
        
        const double expectedArea = 314.15927d;
        double area = Figure.GetCircle(radius).GetArea();
        
        Assert.That(Math.Abs(Math.Round(area, 5) - expectedArea), Is.LessThan(double.Epsilon)); ;
    }

    [TestCase(0)]
    [TestCase(-1)]
    public void Circle_Test_Invalid_Radius(double radius)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            FigureArea.Figure.GetCircle(radius);
        });
    }
}