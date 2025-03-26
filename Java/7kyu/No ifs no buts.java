public class NoIfsNoButs {
  
    public static String noIfsNoButs(int a, int b) {     
      String[] results = {a + " is greater than " + b,a + " is equal to " + b,a + " is smaller than " + b};
      return results[Integer.compare(b,a) + 1];
    } 
}
