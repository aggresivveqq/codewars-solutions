using System;

public static class Kata
{
    public static int[] Take(int[] arr, int n)
      
    { if(arr.Length == 0 || n == 0){
      return new int[0];
    }
     int length = Math.Min(arr.Length, n);
      int[] qwe = new int[length];
    for(int i =0;i<length;i++){
      qwe[i] = arr[i];
    }         
     return qwe;
  }
}
