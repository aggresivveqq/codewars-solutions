using System;
public class Kata
{
    public static string PrintArray(object[] array)
    {
        var resultList = new System.Collections.Generic.List<string>();

        foreach (var item in array)
        {

            if (item is Array innerArray)
            {

                foreach (var innerItem in innerArray)
                {
                    resultList.Add(innerItem.ToString());
                }
            }
            else
            {

                resultList.Add(item.ToString());
            }
        }


        return string.Join(",", resultList);
    }
}