/*
Define a custom exception InvalidTransactionException
 that inherits from Exception. Create a BankAccount
 class that throws this exception when an invalid transaction
 (e.g., overdraft) occurs. Demonstrate handling this custom exception.
*/

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
using System.Linq;

public class InvalidTransactionException : Exception{
    public InvalidTransactionException() {}
    
    public InvalidTransactionException(string message) : base(message){}
    
    public InvalidTransactionException(string message, Exception inner) : base(message, inner){}
}

public class BankAccount
{
    public int BankAmount{get;set;}

    public BankAccount(int bankAmount)
    {
        BankAmount = bankAmount;
    }
    
    private int WithdrawValidate(int withdrawAmount)
    {
        if (withdrawAmount > BankAmount)
        {
            throw new InvalidTransactionException("The amount is more than the amount in your account");
        }
        BankAmount -= withdrawAmount;
        return BankAmount;
    }
    
    public void Withdraw(int withdrawAmount)
    {
        try{
            int newBalance = WithdrawValidate(withdrawAmount);
            Console.WriteLine(newBalance);
            Console.WriteLine("The transaction is complete");
        }
        catch(InvalidTransactionException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        BankAccount account = new BankAccount(100);
        account.Withdraw(32);
        account.Withdraw(120);
    }
}