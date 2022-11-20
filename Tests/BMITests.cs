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
    // one way (bad approach)
    [Test]
    public void Determine_BMI()
    {
        double num = 21.37;
        var determineBMI = new BMI();
        var result = determineBMI.DetermineBMI(num);
        Assert.AreEqual(result, BMI.BMIClassification.Normal); // if somebody change this classification to e.g. overweight, test will show an error
    }

    // second way (good aproach)
    [Test]
    [TestCase(16.12, BMI.BMIClassification.Underweight)]
    [TestCase(21.37, BMI.BMIClassification.Normal)]
    [TestCase(25.99, BMI.BMIClassification.Overweight)]
    [TestCase(36.66, BMI.BMIClassification.Obesity)]
    public void Determine_BMI2(double num, BMI.BMIClassification bmiClassification)
    {
        var determineBMI = new BMI();
        var result = determineBMI.DetermineBMI(num);
        Assert.AreEqual(result, bmiClassification); 
    }
    [Test]
    [TestCase(0, 100)]
    [TestCase(100, 0)]
    [TestCase(-10, 100)]
    [TestCase(-10, 100)]
    [TestCase(10, -100)]
    [TestCase(0, 0)]
    [TestCase(-10, -10)]
    public void Assert_AreParametersValid_ReturnsException(double height, double weight)
    {
        var bmiCalculator = new BMI();
        Action result = () => bmiCalculator.CalculateBMI(height, weight);
        
        //one way
        Assert.Throws<ArgumentException>(() => bmiCalculator.CalculateBMI(height, weight)); // must be delegate

        //second way
        // Assert.Throws<ArgumentException>(() => result());
    }
}