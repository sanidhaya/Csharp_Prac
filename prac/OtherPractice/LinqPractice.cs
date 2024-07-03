/*
Write a LINQ query to retrieve all the prime numbers from a given list of integers.

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Linq;

public class HelloWorld
{
    public static bool IsPrime(int num)
    {
        if(num == 1)
        {
            return false;
        }
        else if(num%2 == 0)
        {
            return false;
        }
        else{
            int sqrele = (int)Math.Round(Math.Sqrt(num));
            for(int i = 3; i <= sqrele; i++)
            {
                if(num%i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
    
    public static void Main(string[] args)
    {
        int[] nums = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16};
        var ints = nums.Where(n => IsPrime(n));
        
        foreach(var item in ints)
        {
            Console.WriteLine(item);
        }
    }
}
*/