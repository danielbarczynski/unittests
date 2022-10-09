class Calculator
{
    public int Add(int x, int y)
    {
        return x + y;
    }

    public int Multiply(int x, int y)
    {
        return x * y;
    }

    public bool IsPositive(int x, int y)
    {
        if (x * y < 0)
            return false;
            
        return true;
    }
}
