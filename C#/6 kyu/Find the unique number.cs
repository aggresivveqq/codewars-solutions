using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int GetUnique(IEnumerable<int> numbers)
  {
     var counts = new Dictionary<int, int>();

        foreach (var num in numbers)
        {
            if (counts.ContainsKey(num))
            { counts[num]++;
            }
            else
            {  counts[num] = 1;
            }
        }

        return counts.FirstOrDefault(x => x.Value == 1).Key;
  
  }
}
