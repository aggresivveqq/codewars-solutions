using System;

public class Kata
{
    public static bool Validate_hello(string greetings)
    {
        string lowerInput = greetings.ToLower();

        string[] qwe = { "hello", "ciao", "salut", "hallo", "hola", "ahoj", "czesc" };

        foreach (string greeting in qwe)
        {
            if (lowerInput.Contains(greeting))
            {
                return true;
            }
        }

        return false;
    }
}