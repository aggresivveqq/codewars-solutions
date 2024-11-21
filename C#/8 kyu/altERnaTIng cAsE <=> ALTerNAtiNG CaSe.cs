using System;
using System.Text;
namespace Extensions
{
  public static class StringExt
  {
    public static string ToAlternatingCase (this string s)
    {
      StringBuilder result = new StringBuilder(s.Length);
            
            foreach (var ch in s)
            {
                if (char.IsLower(ch))
                {
                    result.Append(char.ToUpper(ch));
                }
                else
                {
                    result.Append(char.ToLower(ch));
                }
            }
            
            return result.ToString();
      }
  }
}
