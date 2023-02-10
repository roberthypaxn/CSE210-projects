using System;


public class Fraction
{
    private int _topNum = 0;
    private int _botNum = 0;
    public Fraction()
    {
        _topNum = 1;
        _botNum = 1;
    }
    public Fraction(int WholeNumber)
    {
        _topNum = WholeNumber;
        _botNum = 1;
    }
    public Fraction(int top, int bottom)
    {   
        _topNum = top;
        _botNum = bottom;
        
    }
    public void getFractionString()
    {
        Console.WriteLine("----------------------------");     
        Console.WriteLine($"{_topNum}/{_botNum}");
    }
    public void getDecimalValue()
    {
        double results = Convert.ToDouble(_topNum) / Convert.ToDouble(_botNum);
        Console.WriteLine(results);
    }
    public void fracDisplay()
    {
        Console.WriteLine("etc");

    }
}