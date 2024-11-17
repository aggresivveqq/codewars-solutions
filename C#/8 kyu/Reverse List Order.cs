using System.Collections.Generic;

public class Kata
{
  public static List<int> ReverseList(List<int> list)
  {
    List<int> reversedList = new List<int>(list);
      reversedList.Reverse();
       return reversedList;
  }
}
