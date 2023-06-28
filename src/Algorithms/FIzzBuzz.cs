namespace C__Algorithm;

public class FIzzBuzz
{
    // Write a program that prints the numbers from 1 to 100. 
    // But for multiples of three, print "Fizz" instead of the number, and 
    // for the multiples of five, print "Buzz". For numbers that are multiples of both three 
    // and five, print "FizzBuzz".

    public void FizzBuzz()
    {
        for(int i = 1; i<= 100; i++)
        {
            if(i%3 ==0 && i%5 ==0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if(i%5 ==0)
            {
                Console.WriteLine("Buzz");
            }
            else if(i%3 ==0)
            {
                Console.WriteLine("Fizz");
            }
        }
    }
}