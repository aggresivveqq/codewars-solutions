using System;
using System.Linq;
public class Kata
{
  public static int NextId(int[] ids)
  {
    var qwe = ids.OrderBy(x =>x).Distinct().ToArray();
   for(int i = 0;i<qwe.Length;i++){
     if(qwe[i] != i){
       return i;
     }
   }
    return qwe.Length;
  }
}
