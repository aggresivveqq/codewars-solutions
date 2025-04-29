public class Kata
{
  public static bool ArrayMadness(int[] a, int[] b)
  {
   int sumOfSquares = 0;
        int sumOfCubes = 0;

        foreach (int num in a)
        {
            sumOfSquares += num * num;
        }

        foreach (int num in b)
        {
            sumOfCubes += num * num * num;
        }

        return sumOfSquares > sumOfCubes;
  }
}
