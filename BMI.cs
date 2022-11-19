BMI bmi = new BMI();
var result = bmi.CalculateBMI(181.0, 70.0);
Console.WriteLine(result);

public class BMI
{
    public double CalculateBMI(double height, double weight)
    {
        return Math.Round(weight / (height / 100 * height / 100), 2);
    }
}

