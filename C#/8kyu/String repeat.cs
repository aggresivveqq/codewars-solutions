using System.Linq;
namespace Solution
{
  public static class Program
  {
    public static string RepeatStr(int n, string s){
      string a = string.Join("",Enumerable.Repeat(s,n));
    return a;
    }
  }
}
