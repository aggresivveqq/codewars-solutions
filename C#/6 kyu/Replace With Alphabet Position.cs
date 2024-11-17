using System;
using System.Text;
public static class Kata
{
  public static string AlphabetPosition(string text)
  {
       char[] alpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
     char[] target = text.ToLower().ToCharArray();
    var sb = new StringBuilder();
    for(int i =0;i<target.Length;i++){
      for(int j = 0;j<alpha.Length;j++){
        if(alpha[j] == target[i]){
          if(sb.Length > 0){
           sb.Append(" ");
            
            
          }
                      sb.Append(j + 1);
        }
      
      }
    }
    return sb.ToString();
    }
}
