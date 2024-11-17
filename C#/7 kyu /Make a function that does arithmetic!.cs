using System;

public class Kata 
{
  public static double Arithmetic(double a, double b, string op) 
  {
    switch(op){
        case "add":
          return a+b;
          break;
        case "subtract":
          return a-b;
          break;
        case "multiply":
          return a  * b;
          break;
        case "divide":
          return a / b;
          break;
        default:
          return 0;
          break;
    }
  }
}
