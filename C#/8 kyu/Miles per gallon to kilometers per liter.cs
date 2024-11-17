using System;
public static class Kata
{
    public static double Converter(int mpg)
    {
        const double litersPerGallon = 4.54609188;
        const double kilometersPerMile = 1.609344;
        double qwe = (mpg * kilometersPerMile) / litersPerGallon;
        return Math.Round(qwe, 2);
    }
}