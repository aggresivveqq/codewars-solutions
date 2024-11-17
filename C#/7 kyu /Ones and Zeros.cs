using System;
namespace Solution
{
  class Kata
    {
      public static int binaryArrayToNumber(int[] BinaryArray)
        {
              string qwe = string.Join("", BinaryArray);
        return Convert.ToInt32(qwe,2);
      }
    }
}
