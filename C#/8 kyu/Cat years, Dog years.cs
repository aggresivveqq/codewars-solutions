public class Dinglemouse
{

    public static int[] humanYearsCatYearsDogYears(int humanYears)
    {

        int catYears = 0;
        int dogYears = 0;

        if (humanYears == 1)
        {
            catYears = 15;
        }
        else if (humanYears == 2)
        {
            catYears = 15 + 9; // 24
        }
        else
        {
            catYears = 15 + 9 + (humanYears - 2) * 4;
        }

        // Calculate dog years
        if (humanYears == 1)
        {
            dogYears = 15;
        }
        else if (humanYears == 2)
        {
            dogYears = 15 + 9; // 24
        }
        else
        {
            dogYears = 15 + 9 + (humanYears - 2) * 5;
        }

        return new int[] { humanYears, catYears, dogYears };
    }

}