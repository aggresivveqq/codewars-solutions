public class NewAverage {
  
  public static long newAvg(double[] arr, double navg) {
    double numberofDonations = arr.length;
    double sum = 0;
    for(int i =0;i<arr.length;i++){
      sum += arr[i];
    }
    double result = Math.ceil(navg * (numberofDonations +1) - sum);
   if(result <= 0){
     throw new IllegalArgumentException();
     }

    return (long)result;
    
  }
}
