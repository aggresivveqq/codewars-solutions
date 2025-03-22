public class Kata {

    public static String integrate(int coefficient, int exponent) {
      int foundedExponent = exponent + 1;
      int endCoeff = coefficient / foundedExponent ;

      String result = endCoeff +"x^" + foundedExponent;
      return result;
    }
  
}
