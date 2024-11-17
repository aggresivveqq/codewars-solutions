using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static string SpinWords(string sentence)
  {
var result = string.Join(" ", sentence.Split(' ')
    .Select(x => x.Length >= 5 ? new string(x.Reverse().ToArray()) : x));     
         return result;             
  }
}
