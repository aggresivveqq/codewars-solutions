using System;
using System.Collections.Generic;

namespace Solution
{
  class Kata
    {
    public static int find_it(int[] seq) 
      {
      Dictionary<int,int> result = new Dictionary<int,int>();
      int qwe = 0;
      foreach(int num in seq){
        if(result.ContainsKey(num)){
          result[num]++;
        }
        else{
          result.Add(num,1);
        }
      
      }
       foreach(KeyValuePair<int,int> asd in result){
         if(asd.Value % 2 != 0){
          qwe = asd.Key;
           break;
         }
       }
      
       return qwe;
    }
}
}
