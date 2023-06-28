namespace C__Algorithm;

public class RemovingVowels
{
    public string RemoveVowels(string input)
    {
        char[] vowels = {'a','e','i','o','u'};
        string result ="";
        foreach(char c in input)
        {
            if(!vowels.Contains(char.ToLower(c)))
            {
                result +=c;
            }
        }
        return result;
    }
}
