namespace C__Algorithm;

public class Fibonacci
{
    public void GenerateFibonacci(int number)
    {
        int next = 0;
        int prev = 0;
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine(next);
            if (next == 0)
            {
                next = 1;
            }
            else
            {
                int temp = next;
                next = next + prev;
                prev = temp;
            }
        }
    }
}
