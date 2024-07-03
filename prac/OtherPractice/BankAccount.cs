// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public interface IBankAccount{
    void Deposit(int cash);
    void Withdraw(int cash);
}

public class CheckingAccount : IBankAccount{
    public int CheckingMoney;
    
    public CheckingAccount(int money){
        CheckingMoney = money;
        Console.WriteLine("The amount in your checking account is "+ CheckingMoney);
    }
    
    public void Deposit(int cash){
        CheckingMoney += cash;
        Console.WriteLine("amount after cash deposited in your checking account" + CheckingMoney);
    }
    
    public void Withdraw(int cash){
        if(cash > CheckingMoney){
            Console.WriteLine(cash+ " is more than the fund present in your account");
        }else{
            CheckingMoney -= cash;
            Console.WriteLine("the remaining amount in your savings is "+CheckingMoney);
        }
    }
}

public class SavingsAccount : IBankAccount{
    
    public int SavingMoney;
    
    public SavingsAccount(int money)
    {
        SavingMoney = money;
        Console.WriteLine("The amount in your savings account is " + SavingMoney);
    }
    
    public void Deposit(int cash){
        SavingMoney += cash;
        Console.WriteLine("total amount in your savings account is "+ SavingMoney);
    }
    
    public void Withdraw(int cash){
        if(cash > SavingMoney){
            Console.WriteLine(cash + " is more than the fund in the account");
        }else{
            SavingMoney -= cash;
            Console.WriteLine("The remaining amount in your savings account is "+SavingMoney);
        }
    }
}

public class HelloWorld
{
    public static void Main(string[] args){
    SavingsAccount s = new SavingsAccount(100000);
    s.Deposit(1000);
    s.Withdraw(10000);
    s.Withdraw(100000000);
    
    Console.WriteLine("\n");
    
    CheckingAccount c = new CheckingAccount(100000);
    c.Deposit(1000);
    c.Withdraw(10000);
    c.Withdraw(1000000000);
}}