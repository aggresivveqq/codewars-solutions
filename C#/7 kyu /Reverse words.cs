using System;

public static class Kata
{
  public static string ReverseWords(string str)
  {
      string[] strToArray =str.Split(' ');
    for(int i =0;i<strToArray.Length;i++){
      char[] chrArray = strToArray[i].ToCharArray();
      Array.Reverse(chrArray);
      strToArray[i] = new string(chrArray);
    }
    string result = string.Join(" ",strToArray);
    return result;
  }
}
