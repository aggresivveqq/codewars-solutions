using System;

class PoleVault
{
    public static double StartingMark(double bodyHeight)
    {
        double x1 = 1.52, y1 = 9.45;
        double x2 = 1.83, y2 = 10.67;

        double m = (y2 - y1) / (x2 - x1);

        double b = y1 - m * x1;

        double startingMark = m * bodyHeight + b;

        return Math.Round(startingMark, 2);
    }
}
