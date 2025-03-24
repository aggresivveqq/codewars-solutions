public class Reduce{
  public static int[] myFraction(int[] fractions){
    int a = fractions[0];
    int b = fractions[1];
    int c = gcd(a,b);
    return new int[]{a / c,b / c};
  }
    public static int gcd(int a,int b){
      while(b!=0){
           int temp = b;
           b =a % b;
           a = temp;
      }
      return a;
    }
  }
