namespace C__Algorithm;

public class AVeryBigSum
{
    public long Number { get; set; }

    public long SumArray(List<long> arrayOfNumbers)
    {
        foreach (long number in arrayOfNumbers)
        {
            Number += number;
        }
        return Number;
    }
}