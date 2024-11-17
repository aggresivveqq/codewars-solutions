public class Number
{
  public static int DigitalRoot(long n)
  {  int root = 0;
        if (n == 0)
        {
            return 0;
        }

        while (n > 0 || root > 9)
        {
            if (n == 0) 
            {
                n = root;
                root = 0;
            }
            root += (int)(n % 10);
            n /= 10;
        }

        return root;
  }
}
