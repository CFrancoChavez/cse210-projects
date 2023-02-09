using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    // Creates a fraction for 1/1.
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Creates a fraction for the provided whole number.
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Creates a fraction for the provided top and bottom numbers.
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    // Returns a fraction in the form "top/bottom".

    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }


    // Returns the decimal value of the fraction.
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}