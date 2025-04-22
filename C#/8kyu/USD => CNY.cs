public static class Kata
{
 public static string Usdcny(int usd)
   {
   double cny = usd * 6.75;
     return $"{cny:F2} Chinese Yuan";
   }
}
