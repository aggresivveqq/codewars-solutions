using System.Collections.Generic;
using System;

public class Kata
{
  public static Dictionary<char, int> Count(string str)
  {
   Dictionary<char,int> result = new Dictionary<char,int>();
    foreach(char a in str){
      if(result.ContainsKey(a)){
        result[a]++;
      }else{
        result[a] = 1;
      }
      
    }
    return result;
  }
}
