using System;
using System.Collections.Generic;

public class Kata
{
  public static int SquareDigits(int n)
  {
    if(n == 0){
      return 0;
    }
     string result = "";
    while(n>0){
      int digit = n % 10;
      int squareddigit =digit * digit;
      result = squareddigit.ToString() + result;
      n = n / 10;
    } 
     return int.Parse(result);
  }
}
