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
}