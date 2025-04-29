using System;
public class Kata
{
  public static string DatingRange(int age)
  {if(age <=14){
    int min =(int) Math.Floor(age - 0.10* age);
    int max = (int)Math.Floor(age + 0.10 * age);
    
    return ($"{min}-{max}");
    }else{
    int min = (int)Math.Floor(age/2.0 + 7);
    int max= (int)Math.Floor(2.0 * (age - 7));
      return  ($"{min}-{max}");
  }
  }
}
