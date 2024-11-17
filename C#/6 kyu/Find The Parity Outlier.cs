public class Kata
{
    public static int Find(int[] integers)
    { int counterForEven = 0;
      int counterForOdd = 0;
    for(int i = 0;i<integers.Length;i++){
      if(integers[i] % 2 == 0){
         counterForOdd++;
      }else{
        counterForEven++;
      }
    }
     if(counterForEven < counterForOdd){
       for(int i = 0;i<integers.Length;i++){
         if(integers[i] % 2 !=0){
           return integers[i];
         }
       }
     }else{
       for(int i = 0;i<integers.Length;i++){
         if(integers[i] % 2 ==0){
           return integers[i];
         }
     }
    }
     return 0;
}
    }
