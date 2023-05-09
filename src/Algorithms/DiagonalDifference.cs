namespace C__Algorithm;

public class DiagonalDifference
{
    public int SumMDiagonal { get; set; }
    public int SumNDiagonal { get; set; }

    public int SolveDiagonalDifference(List<List<int>> matrix)
    {
        for (int i = 0; i < matrix.Count; i++)
        {
            SumMDiagonal += matrix[i][i];
            SumNDiagonal += matrix[i][matrix.Count - i - 1];
        }
        return Math.Abs(SumMDiagonal - SumNDiagonal);
    }
}
