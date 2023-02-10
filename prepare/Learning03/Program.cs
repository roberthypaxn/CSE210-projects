using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction oneFraction = new Fraction();
        oneFraction.getFractionString();
        oneFraction.getDecimalValue();

        Fraction secondFraction = new Fraction(5);
        secondFraction.getFractionString();
        secondFraction.getDecimalValue();

        Fraction thirdFraction = new Fraction(3, 4);
        thirdFraction.getFractionString();
        thirdFraction.getDecimalValue();

        Fraction lastFraction = new Fraction(1, 3);
        lastFraction.getFractionString();
        lastFraction.getDecimalValue();
        Console.WriteLine("----------------------------");     
        
    }
}