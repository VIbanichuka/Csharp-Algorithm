using System.Collections.Generic;

namespace C__Algorithm;

public class SumOfArray
{
    public int Num { get; set; }
    public int SimpleArraySum(List<int> ar)
    {
        foreach (var number in ar)
        {
            Num += number;
        } 
        return Num;
    }
}
