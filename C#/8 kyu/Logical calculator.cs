public class Kata
{
    public static bool LogicalCalc(bool[] array, string op)
    {
        bool result = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            switch (op)
            {
                case "AND":
                    result = result & array[i];
                    break;
                case "OR":
                    result = result | array[i];
                    break;
                case "XOR":
                    result = result ^ array[i];
                    break;
            }
        }
        return result;
    }
}