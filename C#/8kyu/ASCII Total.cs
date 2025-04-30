public class Kata
{
  public static int UniTotal(string str)
  {
    int Value = 0;
    foreach(char c in str){
      Value += (int)c;
    }
    return Value;
  }
}
