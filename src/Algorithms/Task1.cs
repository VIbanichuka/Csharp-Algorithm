namespace C__Algorithm;

public class Task1
{
    public int Total(int[] array)
    {
        var totalScore = 0;
        foreach (var number in array)
        {
            if(number %2 ==0)
            {
                totalScore+= 1;
            }
            else
            {
                totalScore +=3;
            }
            if(number == 8)
            {
                totalScore += 5;
            }
        }
        return totalScore;
    }
}
