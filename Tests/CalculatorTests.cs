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
}