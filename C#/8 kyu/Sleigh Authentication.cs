public class Sleigh
{
    public static bool Authenticate(string name, string password)
    {
        if (name == "Santa Claus" && password == "Ho Ho Ho!")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}