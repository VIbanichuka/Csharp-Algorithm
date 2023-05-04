namespace C__Algorithm;
public class SwappingNumbers
{
    public int Num1 { get; set; }
    public int Num2 { get; set; }

    public void SwapTwoNumbersMethod1(int num1, int num2)
    {
        Num1 = num1;
        Num2 = num2;

        num1 = num1 * num2;
        num2 = num1 / num2;
        num1 = num1 / num2;
        Console.WriteLine("Method1: Number1 is {0} and Number2 is {1}", num1, num2);
    }

    public void SwapTwoNumbersMethod2(int num1, int num2)
    {
        Num1 = num1;
        Num2 = num2;

        num1 = num1 + num2;
        num2 = num1 - num2;
        num1 = num1 - num2;
        Console.WriteLine("Method2 Number1 is {0} and Number2 is {1}", num1, num2);
    }
}
