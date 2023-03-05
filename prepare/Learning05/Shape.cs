using System;

class Shape
{
    private string _color;

    public Shape(string aColor)
    {
        _color = aColor;
    }

    public void SetColor(string aColor)
    {
        _color = aColor;
    }
    public string GetColor()
    {
        return _color;
    }
    public virtual float GetArea()
    {
        float _area = 0;
        return _area;
    }
}