BMI bmi = new BMI();
var result = bmi.CalculateBMI(181.0, 70.0);
Console.WriteLine(result);

public class BMI
{
    public enum BMIClassification 
    {
        Underweight,
        Normal,
        Overweight,
        Obesity
    }
    public double CalculateBMI(double height, double weight)
    {
        if (height <= 0 || weight <= 0)
            throw new ArgumentException("Invalid input");
        
        return Math.Round(weight / (height / 100 * height / 100), 2);
    }

    public BMIClassification DetermineBMI(double bmi) => bmi switch
    {
        < 18.5 => BMIClassification.Underweight,
        < 24.9 => BMIClassification.Normal,
        < 29.9 => BMIClassification.Overweight,
        _ => BMIClassification.Obesity
    };
}

