namespace Kata
{
  public static class Problem
  {
    public static string CamelCase(this string str)  
    {  
 if (string.IsNullOrWhiteSpace(str))
        return string.Empty;

    var words = str.Split(' ');
    for (int i = 0; i < words.Length; i++)
    {
        if (!string.IsNullOrWhiteSpace(words[i]))
        {
            words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
        }
    }

    return string.Join(string.Empty, words); 
    }
  }
}

