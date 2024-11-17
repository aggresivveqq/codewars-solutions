using System.Collections.Generic;
public class LineNumbering 
{
    public static List<string> Number(List<string> lines) 
    {
        List<string> numberedLines = new List<string>();
        for (int i = 0; i < lines.Count; i++)
        {
            numberedLines.Add($"{i + 1}: {lines[i]}");
        }
        return numberedLines;
    }
}
