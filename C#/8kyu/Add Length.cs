using System;
using System.Collections.Generic;

public class Kata
{
  public static string[] AddLength(string str)
  {
    List<string> list = new List<string>();
    string[] words = str.Split(' ');
    for (int i = 0; i < words.Length; i++)
    {
      string pattern = words[i] + " " + words[i].Length;
      list.Add(pattern);
    }
    return list.ToArray();
  }
}
