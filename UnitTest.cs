using NUnit.Framework;

public class UnitTest
{
    [Test]
    public void Adding_Two_Numbers()
    {
        var calculator = new Calculator();
        var result = calculator.Add(1, 2);
        Assert.AreEqual(3, result);
    }

    [Test]
    public void Multiplying_Two_Numbers()
    {
        var calculator = new Calculator();
        var result = calculator.Multiply(3, 2);
        Assert.AreEqual(6, result);
    }
}