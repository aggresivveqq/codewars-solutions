using System;
public static class Kata
{
  public static bool IsPrime(int n)
  {
    if(n <= 0){
      return false;
    }
    if(n == 1){
      return false;
    }
    int target =(int) Math.Sqrt(n) +1;
    for(int i = 2;i<target;i++){
      if(n % i == 0){
        return false;
      }
    }
    
       return true;
 }
}
