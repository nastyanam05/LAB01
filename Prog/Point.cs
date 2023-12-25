namespace Prog;

public class Point
{
    private int _x;
    private int _y;
    
    public Point(int x, int y)
    {
        this._x = x;
        this._y = y;
    }

    public double X
    {
        get { return _x; }
    }

    public double Y
    {
        get { return _y; }
    }
}