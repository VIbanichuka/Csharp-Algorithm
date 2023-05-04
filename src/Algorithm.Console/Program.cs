using C__Algorithm;
public class Program
{
    public static void Main(string[] args)
    {
        var c = new SwappingNumbers();
        Console.WriteLine("Please enter the first number");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the second number");
        int num2 = Convert.ToInt32(Console.ReadLine());
        c.SwapTwoNumbersMethod1(num1, num2);
        c.SwapTwoNumbersMethod2(num1, num2);

        Console.WriteLine("");
        Console.WriteLine("FIBONACII ALOGRITHM");

        var fibonacci = new Fibonacci();
        Console.WriteLine("Please enter a number");
        int number = Convert.ToInt32(Console.ReadLine());
        fibonacci.GenerateFibonacci(number);
        
        var time = new TimeConversion();
        var hour24 = time.ConvertTo24hour("11:30:45PM");
        Console.WriteLine(hour24);

        SumOfArray sum = new SumOfArray();
        var numbers = new List<int>() {1,2,3,8};
        var totalNumber = sum.SimpleArraySum(numbers);
        System.Console.WriteLine(totalNumber);
    }
}
