
using System.Text;
using System;

public class Accumul 
{
	public static String Accum(string s) 
  {
    StringBuilder result = new StringBuilder();
    for(int i =0;i<s.Length;i++){
      char currentChar = char.ToLower(s[i]);
      result.Append(char.ToUpper(currentChar));
      for(int j=0;j<i;j++){
        result.Append(currentChar);
      }
      if(i<s.Length-1){
        result.Append("-");
      }
    } 
    return result.ToString();
  }
}
