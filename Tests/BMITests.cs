using NUnit.Framework;
public class BMITests
{
    [Test]
    public void Test() 
    {
        // arrange
        var bmiCalculator = new BMI();
        double height = 181.0;
        double weight = 70.0;
        
        // act
        var result = bmiCalculator.CalculateBMI(height, weight);

        // assert
        Assert.AreEqual(result, 21.37);
    }
}