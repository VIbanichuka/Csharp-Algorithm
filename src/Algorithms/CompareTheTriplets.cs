using System.Collections.Generic;

namespace C__Algorithm;

public class CompareTheTriplets
{
    public List<int> CompareTriplets(List<int> a, List<int> b)
    {
        List<int> comparisonScore = new List<int>();
        int aComparisonScore = 0;
        int bComparisonScore = 0;

        for (int i = 0; i < a.Count; i++)
        {
            if (a[i] > b[i])
            {
                aComparisonScore++;
            }
            else if (a[i] < b[i])
            {
                bComparisonScore++;
            }
        }
        comparisonScore.Add(aComparisonScore);
        comparisonScore.Add(bComparisonScore);

        return comparisonScore;
    }
}
