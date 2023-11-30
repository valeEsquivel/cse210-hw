using System;

class Square : Shape
{
    private double _side  = 0;

    public Square()
    {
    }

    public Square(string color, double side) : base(color)
    {
        _side = side;

    }

    public override double GetArea() {
        return _side * _side;
    }
}