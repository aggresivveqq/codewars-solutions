public class Kata {
  public static String longestWord(String wordString) {
   String[] splitted = wordString.split(" ");
    String longest = " ";
    for(String word : splitted){
      if(word.length() >= longest.length()){
        longest = word;
      }
    }
    return longest;
  }
}
