using C__Algorithm;
public class Program
{
    public static void Main(string[] args)
    {
        // var c = new SwappingNumbers();
        // Console.WriteLine("Please enter the first number");
        // int num1 = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Please enter the second number");
        // int num2 = Convert.ToInt32(Console.ReadLine());
        // c.SwapTwoNumbersMethod1(num1, num2);
        // c.SwapTwoNumbersMethod2(num1, num2);

        // Console.WriteLine("");
        // Console.WriteLine("FIBONACII ALOGRITHM");

        // var fibonacci = new Fibonacci();
        // Console.WriteLine("Please enter a number");
        // int number = Convert.ToInt32(Console.ReadLine());
        // fibonacci.GenerateFibonacci(number);

        // var time = new TimeConversion();
        // var hour24 = time.ConvertTo24hour("11:30:45PM");
        // Console.WriteLine(hour24);

        // SumOfArray sum = new SumOfArray();
        // var numbers = new List<int>() {1,2,3,8};
        // var totalNumber = sum.SimpleArraySum(numbers);
        // System.Console.WriteLine(totalNumber);


        // var compare = new CompareTheTriplets();
        // var a = new List<int>() { 17, 28, 30 };
        // var b = new List<int>() { 99, 16, 8 };
        // var result = compare.CompareTriplets(a, b);
        // for (int i = 0; i < result.Count; i++)
        // {
        //     System.Console.WriteLine(result[i]);
        // }


        // var solve = new AVeryBigSum();
        // var listOfNumbers = new List<long> (){1000000001, 1000000002, 1000000003, 1000000004, 1000000005};
        // var result = solve.SumArray(listOfNumbers);
        // Console.WriteLine(result);

        // var result = new DiagonalDifference();
        // List<List<int>> matrix = new List<List<int>>()
        // {
        //     new List<int>() { 1, 2, 3 },
        //     new List<int>() { 4, 5, 6 },
        //     new List<int>() { 9, 8, 9 }
        // };
        // Console.WriteLine(result.SolveDiagonalDifference(matrix));

        // var result = new Task1();
        // var array = new int [] {15,25,35};
        // var r = result.Total(array);
        // System.Console.WriteLine(r);

        // var result = new SwappingNumbers();
        // result.SwapTwoNumbersMethod3(2, 11);

        // var result = new FIzzBuzz();
        // result.FizzBuzz();

        // var array = new int [] {15,25,35};        
        // var r = new TotalNumber();
        // System.Console.WriteLine(r.TotalNumberArray(array));

        var c = new PlusMinus();
        var list = new List<int> {15,25,35, -1, 0};
        c.SolvePlusMinus(list);
    }
}