using System;

public static class AgeDiff
{
    public static string CalculateAge(int birth, int yearTo)
    {

        int ageDifference = yearTo - birth;

        if (ageDifference > 0)
        {

            return $"You are {ageDifference} year{(ageDifference > 1 ? "s" : "")} old.";
        }
        else if (ageDifference < 0)
        {
            return $"You will be born in {-ageDifference} year{(-ageDifference > 1 ? "s" : "")}.";
        }
        else
        {
            return "You were born this very year!";
        }
    }
}