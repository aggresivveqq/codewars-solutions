public class Kata {
  public static boolean betterThanAverage(int[] classPoints, int yourPoints) {
   int sum = 0;
    for(int i =0;i<classPoints.length;i++){
      sum += classPoints[i];
    }
    int average = sum / classPoints.length;
    if(average < yourPoints){
      return true;
    }else{
      return false;
    }
  }
}
