import java.util.*;
public class TheOffice {
  public static String boredom(Person[] staff) {
   Map<String, Integer> boredomScores = new HashMap<>();
        boredomScores.put("accounts", 1);
        boredomScores.put("finance", 2);
        boredomScores.put("canteen", 10);
        boredomScores.put("regulation", 3);
        boredomScores.put("trading", 6);
        boredomScores.put("change", 6);
        boredomScores.put("IS", 8);
        boredomScores.put("retail", 5);
        boredomScores.put("cleaning", 4);
        boredomScores.put("pissing about", 25);
    int totalScore = 0;
    for(Person person : staff){
      totalScore += boredomScores.getOrDefault(person.department,0);
    }
      if (totalScore <= 80) {
            return "kill me now";
        } else if (totalScore < 100) {
            return "i can handle this";
        } else {
            return "party time!!";
        }
  }
}
