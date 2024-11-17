using System;
using System.Collections.Generic;
public class Kata
{
  public static bool Narcissistic(int value)
  { 
    int originalValue = value;
    int result = 0;
    List<int> listofIntegers = new List<int>();
    while(value > 0){
      listofIntegers.Add(value % 10);
      value = value / 10;
    }
       int power = listofIntegers.Count;
      foreach (int digit in listofIntegers)
        {
            result += (int)Math.Pow(digit, power);
        }
      if(result == originalValue){
      return true;
    }else{
      return false;
    }
    
  }
}
