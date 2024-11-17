public class Kata
{
    public static int[] SymmetricPoint(int[] p, int[] q)
    {
        int symmetricX = 2 * q[0] - p[0];
        int symmetricY = 2 * q[1] - p[1];
        return new int[] { symmetricX, symmetricY };
    }
}