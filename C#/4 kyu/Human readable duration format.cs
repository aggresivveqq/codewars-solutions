using System;
using System.Collections.Generic;
public class HumanTimeFormat{
  public static string formatDuration(int seconds){
      if(seconds == 0){
        return "now";
      }
      int years = seconds / (365 * 24 * 60 * 60);
      seconds %= 365 * 24 * 60 * 60;
      int days = seconds / 86400;
      seconds %= 86400;
      int hours = seconds / 3600;
      seconds %= 3600;
      int minutes = seconds / 60;
      seconds %= 60;
    List <string> result = new List<string>();
    if (years > 0){
      result.Add(FormatUnit(years, "year"));
      }
    if (days > 0) {
          result.Add(FormatUnit(days, "day"));
          }
    if (hours > 0) {
          result.Add(FormatUnit(hours, "hour"));
          }
    if (minutes > 0)
          {
          result.Add(FormatUnit(minutes, "minute"));
          }
     if (seconds > 0){
          result.Add(FormatUnit(seconds, "second"));
          }
    
    if(result.Count == 1){
      return result[0];
    }else{
      return string.Join(", ", result.GetRange(0, result.Count - 1)) + " and " + result[result.Count - 1];
    }
    }
  public static string FormatUnit(int value, string unit)
    {
        return value == 1 ? $"1 {unit}" : $"{value} {unit}s";
    }
  }
