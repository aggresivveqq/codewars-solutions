using System;
using System.Text;
public class Kata
{
    public static string DrawStairs(int n)
    {
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            builder.Append(' ', i);
            builder.AppendLine("I");

        }
        return builder.ToString().TrimEnd();
    }
}