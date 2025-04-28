using System;

    public class Kata
    {
        public static bool Validate_hello(string greetings)
        {
         string[] dict = new string[] {"hello","ciao","salut" ,"hallo" ,"hola","ahoj","czesc"};
          string newGreet = greetings.ToLower();
          for(int i = 0;i<dict.Length;i++){
            if(newGreet.Contains(dict[i])){
              return true;
            }
          }
          return false;
        }
    }
