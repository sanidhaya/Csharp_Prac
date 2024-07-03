/*
Develop a User class with private fields for UserName and Password. 
Implement properties with get and set accessors that include validation
logic (e.g., password must be at least 6 characters long). Demonstrate
how encapsulation ensures data integrity.
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class User{
    private string Username;
    public string username
    {
        get{return Username;}
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("username cannot be empty");
            }
            Username = value;
        }
    }
    
    private string Password;
    public string password{
        get{return Password;}
        set
        {
            if((value.Length < 6) || (value == null))
            {
                throw new ArgumentException("Password must be 6 characters long");
            }
            Password = value;
        }
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        try
        {
            User user = new User(){
                username = "aa",
                password = "122"
            };
        }catch(ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
