public static class Kata
{
    public static string bonus_time(int salary, bool bonus)
    {
        if (bonus)
        {
            return "$" + (salary * 10).ToString();
        }
        else
        {
            return "$" + salary.ToString();
        }
    }
}