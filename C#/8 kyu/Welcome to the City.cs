using System.Collections.Generic;
public class Kata
{
    public static string SayHello(string[] name, string city, string state)
    {
        List<string> qwe = new List<string>();
        for (int i = 0; i < name.Length; i++)
        {
            qwe.Add(name[i]);
        }
        return "Hello, " + string.Join(" ", qwe) + "! Welcome to " + city + ", " + state + "!";
    }
}