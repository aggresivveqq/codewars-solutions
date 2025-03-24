public class Kata {
    public static double magnitude(double[] vector) {
     double sum = 0;
      for(int i = 0;i<vector.length;i++){
        sum += Math.pow(vector[i],2);
      }
      return Math.sqrt(sum);
      
    }

}
