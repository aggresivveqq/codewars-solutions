using System;

public class Kata
{
    public static int[] Get_size(int w, int h, int d)
    {
        int surfaceArea = (2 * (w * h)) + (2 * (w * d)) + (2 * (h * d));
        int volume = w * h * d;
        return new int[] { surfaceArea, volume };
    }
}