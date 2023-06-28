namespace C__Algorithm;

public class PlusMinus
{
    public double ZeroRatio { get; set; }
    public double PositiveRatio { get; set; }
    public double NegativeRatio { get; set; }
    public void SolvePlusMinus(List<int> array)
    {
        var positiveNumberCount = 0;
        var negativeNumberCount = 0;
        var zeroNumberCount = 0;
        var lengthOfArray = array.Count();

        foreach(var num in array)
        {
            if(num > 0)
            {
                positiveNumberCount++;
            }
            else if(num<0)
            {
                negativeNumberCount++;
            }
            else if(num ==0)
            {
                zeroNumberCount++;
            }
        }
        PositiveRatio = positiveNumberCount/lengthOfArray;
        NegativeRatio = negativeNumberCount/lengthOfArray;
        ZeroRatio = zeroNumberCount/lengthOfArray;
    }
}
