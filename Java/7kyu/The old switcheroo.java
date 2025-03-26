public class Kata {
  public static String vowel2Index(String s) {
     char[] vowels = {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
    StringBuilder result = new StringBuilder();

    for (int i = 0; i < s.length(); i++) {
      char currentChar = s.charAt(i);
      boolean isVowel = false;

      for (char vowel : vowels) {
        if (currentChar == vowel) {
          result.append(i + 1); 
          isVowel = true;
          break;
        }
      }

      if (!isVowel) {
        result.append(currentChar); 
      }
    }

    return result.toString();
  }
}
