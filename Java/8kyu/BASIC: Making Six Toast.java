public class Kata{
  public static int sixToast(int num){
    int result = 0;
    if(num < 6){
      result = 6-num;
      return result;
    }else if(num > 6){
      result = Math.abs(num-6);
      return result;
    }else{
      return 0;
    }
  }
}
