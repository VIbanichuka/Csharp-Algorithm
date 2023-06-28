namespace C__Algorithm;

public class ReverseString
{
    public string ReverseSrtringOrder(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
