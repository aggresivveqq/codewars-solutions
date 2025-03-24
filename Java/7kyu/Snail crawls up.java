public class Kata {
    public static int snail(int column, int day, int night) {
       if (day >= column) return 1;
        
        int dailyProgress = day - night;
        int daysNeeded = (column - night + dailyProgress - 1) / dailyProgress;
        
        return daysNeeded;
    }
}
