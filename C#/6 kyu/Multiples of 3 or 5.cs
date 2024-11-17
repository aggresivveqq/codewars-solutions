using System;
using System.Collections.Generic;
public static class Kata
{
  public static int Solution(int value)
  {
     int target = value;
    int sum = 0;
    if(target < 0){
      return 0;
    }
    List<int> qwe = new List<int>();
    for(int i =0;i<target;i++){
      if(i % 3 == 0 || i % 5 == 0){
        qwe.Add(i);
      }
    }
    for(int i = 0;i<qwe.Count;i++){
      sum += qwe[i];
    }
    return sum;
  }
}
