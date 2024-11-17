using System;
using System.Collections.Generic;
public class SplitString
{
  public static string[] Solution(string str)
  { 
    if(str.Length % 2 != 0){
      str += "_";
    }
    List <string> pairs = new List<string>();
    for(int i =0;i<str.Length;i+=2){
      pairs.Add(str.Substring(i,2));
    }
    
    return pairs.ToArray();
  }
}
