import java.util.List;
import java.util.ArrayList;
public class Kata{
  
  public static int[] evenNumbers(int[] arr, int n){
   List<Integer> evens = new ArrayList<>();
    for(int num : arr){
      if(num % 2 == 0){
        evens.add(num);
      }
    }
   int[] result = new int[n];
   int size = evens.size();
    for(int i = 0;i<n;i++){
      result[i] = evens.get(size - n + i);
    }
    return result;
  } 
  
}
