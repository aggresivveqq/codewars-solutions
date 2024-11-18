using System;

public class Kata
{
  public static string ToWeirdCase(string s)
  {
    string[] qwe = s.Split(' ');
    for(int i =0;i<qwe.Length;i++){
      char[] wordsChar = qwe[i].ToCharArray();
      for(int j = 0;j<wordsChar.Length;j++){
        if(j % 2 == 0){
        wordsChar[j] = Char.ToUpper(wordsChar[j]);  
        }else{
          wordsChar[j] = Char.ToLower(wordsChar[j]);
        }
     
      }
    qwe[i] = new string(wordsChar);  
    }
    return string.Join(" ",qwe);
    
  }
}
