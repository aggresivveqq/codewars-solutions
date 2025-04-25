using System;

public static class Kata
{
    public static string MultiTable(int number)
    { 
      string[] a = new string[10];
      for(int i = 0;i<10;i++){
        int res = (i+1) * number;
        string b = $"{i+1} * {number} = {res}";
        a[i] = b;
      }
      string result = string.Join("\n",a);
      return result;
    }
}
