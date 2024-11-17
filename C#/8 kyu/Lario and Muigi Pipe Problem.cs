using System.Collections.Generic;
using System.Linq;

public class Fixer
{
  public static List<int> PipeFix(List<int> numbers)
  {
    numbers.Sort();
     int startNumber = numbers[0];
    int lastNumber = numbers.Last();
    List<int> resultList = new List<int>();
    for(int i =startNumber;i<=lastNumber;i++){
      resultList.Add(i);
    }
    return resultList;
  }
}
