using System;
using System.Collections.Generic;

public class Kata
{
  public static string High(string s)
  {
     var qw = new Dictionary<char, int>();
        for (char c = 'a'; c <= 'z'; c++)
        {
            qw[c] = (int)c - 'a' + 1;
        }

        string[] charsToKaif = s.Split(' ');
        string highestWord = "";
        int highestScore = 0;

        for (int i = 0; i < charsToKaif.Length; i++)
        {
            int score = 0;
            for (int j = 0; j < charsToKaif[i].Length; j++)
            {
                char currentChar = charsToKaif[i][j];
                if (qw.ContainsKey(currentChar))
                {
                    score += qw[currentChar]; 
                }
            }

        
            if (score > highestScore)
            {
                highestScore = score;
                highestWord = charsToKaif[i];
            }
        }

        return highestWord; 
}
  }
