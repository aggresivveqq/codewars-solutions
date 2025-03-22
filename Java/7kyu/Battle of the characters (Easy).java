public class BattleOfTheCharacters {
     public static String battle(final String x, final String y) {
        int group1 = calculatePower(x);
        int group2 = calculatePower(y);

        if (group1 > group2) {
            return x;
        } else if (group1 < group2) {
            return y;
        } else {
            return "Tie!";
        }
    }

    private static int calculatePower(String group) {
        int power = 0;
        for (char c : group.toCharArray()) {
            power += c - 'A' + 1;
        }
        return power;
    }
}
