using System.Collections.Generic;
using System;
public class Kata
{
  public static int[] TwoSum(int[] numbers, int target)
  { List<int> result = new List<int>();
    for(int i =0;i<numbers.Length;i++){
      for(int j =i+1;j<numbers.Length;j++){
             if(numbers[i]+ numbers[j] == target){
              return new int[] {i,j};
               
             }
      }
    }
   return new int[0];
  }
}
