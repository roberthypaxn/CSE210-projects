using System;

class Circle : Shape
{
    private float _radius;
    public Circle(string aColor, float radius) : base(aColor)
    {
        _radius = radius;
    }
    public override float GetArea()
    {
        double area = Math.PI * Math.Pow(_radius, 2);
        return (float)area;
    }
}