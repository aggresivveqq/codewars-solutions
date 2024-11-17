public static class StringExtensions
{
  public static bool IsUpperCase(this string text)
  {
    foreach(char c in text){
      if(!char.IsUpper(c) && char.IsLetter(c)){
        return false;
      }
      }
    return true;
    }
  }
