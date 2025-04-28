using System;
public class Kata
{
  public static int SumMul(int n, int m)
  {
   int sum = 0;
    if(n <= 0 || m <= 0){
      throw new ArgumentException("1");
    }
    if(n > m ){
      throw new ArgumentException("2");
    }
    for(int i = n;i < m;i+= n){
      sum += i;
    }
    return sum;
  }
}
