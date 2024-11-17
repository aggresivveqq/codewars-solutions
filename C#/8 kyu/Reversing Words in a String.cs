using System;
using System.Linq;

public class Kata
{
    public static string Reverse(string text)
    {
        string[] qwe = text.Split(' ');
        qwe = qwe.Reverse().ToArray(); 
        return string.Join(" ", qwe);
    }
}
