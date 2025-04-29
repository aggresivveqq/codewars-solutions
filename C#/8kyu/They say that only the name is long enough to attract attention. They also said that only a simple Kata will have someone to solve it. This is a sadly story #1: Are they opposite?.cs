using System;
public class Kata
{
  public static bool IsOpposite(string s1, string s2)
  { if(s1 == "" && s2 == ""){
      return false;
    }
    if(s1 == "" || s2 == ""){
      return false;
    }
    char[] c1 = s1.ToCharArray();
    char[] c2 = s2.ToCharArray();
    for(int i = 0;i<c1.Length;i++){
      if(Char.IsLower(c1[i])){
        c1[i] = Char.ToUpper(c1[i]);
      }else if(Char.IsUpper(c1[i])){
        c1[i] = Char.ToLower(c1[i]);
      }else{
        c1[i] = s1[i];
      }
    }
    for(int i = 0;i<c2.Length;i++){
      if(Char.IsLower(c2[i])){
        c2[i] = Char.ToUpper(c2[i]);
      }else if(Char.IsUpper(c2[i])){
        c2[i] = Char.ToLower(c2[i]);
      }else{
        c2[i] = s2[i];
      }
    }
   string ans1 = new string(c1);
   string ans2 = new string(c2);
   if(ans1 == s2 && ans2 == s1){
     return true;
   }else{
     return false;
   }
  }
}
