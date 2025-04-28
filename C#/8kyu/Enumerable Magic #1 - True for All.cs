using System;

public class Kata
{
  public static bool All(int[] arr, Func<int, bool> fun)
  {
    for(int i = 0;i<arr.Length;i++){
    if (!fun(arr[i]))
        {
         return false;
        }
    }
    return true;
  }
}
