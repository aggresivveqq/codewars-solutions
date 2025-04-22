using System;

public static class Kata
{
  public static string Quote(string fighter)
  {
    string name = fighter.ToLower();
    if(name == "george saint pierre"){
      return "I am not impressed by your performance.";
    }else if(name == "conor mcgregor"){
     return "I'd like to take this chance to apologize.. To absolutely NOBODY!";
    }else{
      return "Wtf";
    }
  }
}
