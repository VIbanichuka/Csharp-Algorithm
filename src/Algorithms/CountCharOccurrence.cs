namespace C__Algorithm;

public class CountCharOccurrence
{
    public int CountCharacters(string input, char target)
    {
        int count = 0;
        foreach (char c in input)
        {
            if (c == target)
            {
                count++;
            }
        }
        return count;
    }
}
