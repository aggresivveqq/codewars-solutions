public class Kata
{
  public static string Derive(double coefficient, double exponent)
  {
    double a=coefficient * exponent;
    int newexponent = (int)exponent - 1;
    return $"{a}x^{newexponent}";
  }
}
