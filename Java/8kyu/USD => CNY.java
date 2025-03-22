public class Kata {
  public static String usdcny(int usd) {
  double cny = usd * 6.75;
    return String.format("%.2f Chinese Yuan",cny);
  }
}
