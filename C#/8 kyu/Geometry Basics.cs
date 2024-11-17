using System;
public class Kata
{
    public static double DistanceBetweenPoints(Point a, Point b)
    {
        double qwe = Math.Pow(b.X - a.X, 2);
        double eqw = Math.Pow(b.Y - a.Y, 2);
        return Math.Sqrt(qwe + eqw);
    }
}