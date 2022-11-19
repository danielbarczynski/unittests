using NUnit.Framework;
public class BMITests
{
    [Test]
    public void Assert_ForHeighAndWeght_Returns2137() 
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

    [Test]
    public void Determine_BMI()
    {
        double num = 21.37;
        var determineBMI = new BMI();
        var result = determineBMI.DetermineBMI(num);
        Assert.AreEqual(result, BMI.BMIClassification.Normal); // if somebody change this classification to e.g. overweight, test will show an error

    }
}