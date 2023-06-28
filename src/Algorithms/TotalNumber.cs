namespace C__Algorithm;

public class TotalNumber
{
    public int TotalNumberArray(int[] array)
    {
        int sum = 0;
        foreach(var num in array)
        {
            sum += num;
        }
        return sum;
    }
}
