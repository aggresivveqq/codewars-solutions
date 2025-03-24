public class Kata{
  public static int countLettersAndDigits(String input){
    int counter = 0;
    for(char ch :input.toCharArray()){
      if(Character.isLetterOrDigit(ch)){
        counter ++;
      }
    }
    return counter;
  }
}
