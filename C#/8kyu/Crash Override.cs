using System;
using System.Collections.Generic;    
public partial class Kata
    {
        public static string AliasGen(string fName, string lName)
        {
          if(string.IsNullOrEmpty(fName) || string.IsNullOrEmpty(lName)){
            return "Unknown";
          }
          char first = char.ToUpper(fName[0]);
          char last = char.ToUpper(lName[0]);
         
          if(!char.IsLetter(first) || !char.IsLetter(last)){
            return "Your name must start with a letter from A - Z.";
          }
        string a = first.ToString();
        string b = last.ToString();
          return FirstName[a] + " " + Surname[b];
        }
    }
