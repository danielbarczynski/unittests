using NUnit.Framework;

public class CalculatorTests
{
    [Test]
    public void Assert_ForTwoNums_ReturnsSumOf3()
    {
        var calculator = new Calculator();
        var result = calculator.Add(1, 2);
        Assert.AreEqual(3, result);
    }

    [Test]
    public void Assert_ForTwoNums_ReturnsProductOf6()
    {
        var calculator = new Calculator();
        var result = calculator.Multiply(3, 2);
        Assert.AreEqual(6, result);
    }

    [Test]
    [TestCase(5, 5)]
    [TestCase(0, 2)]
    [TestCase(-47, -27)]
    [TestCase(-5, 90)]
    public void IsPositive_ForMultiplyingNumbers_Returns3Negatives1Positive(int x, int y)
    {
        var calculator = new Calculator();
        var result = calculator.IsPositive(x, y);
        Assert.AreEqual(result, false);
    }
}