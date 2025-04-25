using System;
public class Kata
{
  public static int CalculateTip(double amount, string rating)
  {
     string newRating = rating.ToLower();
    switch(newRating){
        case "terrible":
        return 0;       
        case "poor":
        return (int)Math.Ceiling(amount * 0.05);
        case "good":
        return (int)Math.Ceiling(amount * 0.10);
        case "great":
        return (int)Math.Ceiling(amount * 0.15);
        case "excellent":
        return (int)Math.Ceiling(amount * 0.20);
        default:
        return -1;
    }
  }
}
