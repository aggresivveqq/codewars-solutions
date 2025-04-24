public class Kata
{
  public static string MouthSize(string animal)
  {
    string a = animal.ToLower();
    if(a == "alligator"){
      return "small";
    }else{
      return "wide";
    }
  }
}
