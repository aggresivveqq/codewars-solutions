using System;

public class Kata
{
  public static string[] SortByLength (string[] array)
  { 
       Array.Sort(array, (a, b) => a.Length.CompareTo(b.Length));
        return array;
    
  }
}
