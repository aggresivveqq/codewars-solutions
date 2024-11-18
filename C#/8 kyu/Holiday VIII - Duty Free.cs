public class Kata
{
  public static int DutyFree(int normPrice, int Discount, int hol)
  {
    double savingsPerBottle = normPrice * (Discount / 100.0);
        double result = hol / savingsPerBottle;
        return (int)result;
  }
}
