using System;
namespace Solution
{
  public static class Program
  {
    public static string StringsSum(string s1, string s2)
    { int a = 0;
      if(!string.IsNullOrEmpty(s1)){
         a = int.Parse(s1);
      }else{
        a = 0;
      }
    int b = 0;
      if(!string.IsNullOrEmpty(s2)){
         b = int.Parse(s2);
      }else{
        b = 0;
      }
     string result = (a+b).ToString();
     return result;
    }
  }
}
