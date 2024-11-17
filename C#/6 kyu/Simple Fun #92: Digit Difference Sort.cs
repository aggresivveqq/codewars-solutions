using System;
using System.Linq;
namespace myjinxin
{
    using System;
    
    public class Kata
    {
        public int[] DigitDifferenceSort(int[] a){
        int[] sortedA = a
            .Select((num, index) => new 
            {
                Value = num,
                Difference = num.ToString().Select(d => int.Parse(d.ToString())).Max() - num.ToString().Select(d => int.Parse(d.ToString())).Min(),
                Index = index
            })
            .OrderBy(x => x.Difference)
            .ThenByDescending(x => x.Index)
            .Select(x => x.Value)
            .ToArray();

       
        return sortedA;
          
        }
    }
}
