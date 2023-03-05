using System;

class Rectangle : Shape
{
    private float _height;
    private float _width;
    public Rectangle(string aColor, float height, float width) : base(aColor)
    {
        _height = height;
        _width = width;
    }
    public override float GetArea()
    {
        return _height * _width;
    }
}