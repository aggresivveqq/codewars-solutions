using System;
public class CountDig 
{
    
    public static int NbDig(int n, int d) 
    {
      int count = 0;      
      string target = d.ToString();
       for(int k = 0;k<=n;k++){
         int square = k * k;
         string squareStr = square.ToString();
         foreach(char c in squareStr){
           if(c.ToString() == target){
             count++;
           }
         }
       }
      return count;
    }
}
