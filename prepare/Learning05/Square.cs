using System;

class Square : Shape
{
    private float _side;
    public Square(string aColor, float side) : base(aColor)
    {
        _side = side;
    }
    public override float GetArea()
    {
        return _side * _side;
    }
}