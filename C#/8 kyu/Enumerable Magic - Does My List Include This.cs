public class Kata
{
    public static bool Include(int[] arr, int item)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (item == arr[i])
            {
                return true;
            }
        }
        return false;
    }
}