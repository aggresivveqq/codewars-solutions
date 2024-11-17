public class Kata
{
    public static bool Collinearity(int x1, int y1, int x2, int y2)
    {
        int x = 0;
        int y = 0;
        if (x2 == 0 || x1 == 0)
        {
            x = 0;
        }
        if (y2 == 0 || y1 == 0)
        {
            y = 0;
        }
        if (x2 != 0)
        {
            x = y1 * x2;
        }
        if (y2 != 0)
        {
            y = x1 * y2;
        }
        if (x2 == 0 && y2 == 0)
        {
            return true;
        }
        if (x == y)
        {
            return true;
        }
        else
        {
            return false;
        }



    }
}