using System;

public class HQ9
{
    public static string Interpret(string code)
    {
        if (string.IsNullOrEmpty(code) || code.Length != 1) return null;

        switch (code)
        {
            case "H": return "Hello World!";
            case "Q": return "Q";
            case "9":
                string song = "";
                for (int i = 99; i >= 1; i--)
                {
                    string current = i == 1 ? "1 bottle" : $"{i} bottles";
                    string next = i - 1 == 1 ? "1 bottle" : i - 1 > 0 ? $"{i - 1} bottles" : "no more bottles";

                    song += $"{current} of beer on the wall, {current} of beer.\n";

                    if (i > 1)
                        song += $"Take one down and pass it around, {next} of beer on the wall.\n";
                    else
                    {
                        song += "Take one down and pass it around, no more bottles of beer on the wall.\n";
                        song += "No more bottles of beer on the wall, no more bottles of beer.\n";
                        song += "Go to the store and buy some more, 99 bottles of beer on the wall.";
                    }
                }

                return song.TrimEnd();

            default:
                return null;
        }
    }
}
