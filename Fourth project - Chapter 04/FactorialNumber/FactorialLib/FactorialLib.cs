namespace FactorialPackt;

using static System.Console;
using static System.Math;
public class Factorial
{
    public void FactorialCalculation(int number)
    {
        
        while (number % 2 == 0)
        {
            if (number==2)
            {
                 Write("2");
                number /= 2;
            }
            else
            {
                Write("2 X");
                number /= 2;
            }
        }
         // number must be odd at this point.  So we can skip  
        // one element (Note i = i +2) 
        for (int i = 3; i <= Sqrt(number); i = i+2) 
        { 
            // While i divides n, print i and divide n 
            while (number % i == 0) 
            { 
                if (number <= i)
                {
                    Write(i); 
                    number /= i;
                }
                else
                {
                    Write($"{i} X"); 
                    number /= i;
                }
            } 
        } 
        // This condition is to handle the case when n  
        // is a prime number greater than 2 
        if (number  > 2) 
        {
             Write(number);
        }  
    } 
}
