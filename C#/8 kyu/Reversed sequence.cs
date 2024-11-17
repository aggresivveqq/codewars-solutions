using System;

public static class Kata
{
  public static int[] ReverseSeq(int n)
  {
    int[] qwe = new int[n];
    for(int i =0;i<n;i++){
      qwe[i] = n -i;
    }
     return qwe;
  }
}
