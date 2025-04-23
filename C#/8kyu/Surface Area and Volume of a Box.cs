using System;

    public class Kata
    {
        public static int[] Get_size(int w,int h,int d)
        {
        int volume = w * h * d;
        int surfaceArea = 2 * (w * h + h * d + w * d);
        return new int[] { surfaceArea, volume };
        }
    }
