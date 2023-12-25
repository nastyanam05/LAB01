namespace Prog;

public class Figure
{
    private Point a, b, c, d, e;
    private string name;

    public string Name
    {
        get { return name; }
    }

    public Figure(Point A, Point B, Point C)
    {
        a = A;
        b = B;
        c = C;
        name = "треугольник";
    }

    public Figure(Point A, Point B, Point C, Point D) : this(A, B, C)
    {
        d = D;
        name = "четырёхугольник";
    }

    public Figure(Point A, Point B, Point C, Point D, Point E) : this(A, B, C, D)
    {
        e = E;
        name = "пятиугольник";
    }

    public double LengthSide(Point A, Point B)
    {
        return Math.Pow(Math.Pow((A.X - B.X), 2) + Math.Pow((A.Y - B.Y), 2), 0.5);
    }

    public double PerimeterCalculator()
    {
        if (name == "треугольник")
        {
            return this.LengthSide(a, b) + this.LengthSide(b, c) + this.LengthSide(a, c);
        }

        if (name == "четырёхугольник")
        {
            return this.LengthSide(a, b) + this.LengthSide(b, c) + this.LengthSide(c, d) + this.LengthSide(d, a);
        }
        else
        {
            return this.LengthSide(a, b) + this.LengthSide(b, c) + this.LengthSide(c, d) + this.LengthSide(d, e) +
                   this.LengthSide(e, a);
        }
    }
}