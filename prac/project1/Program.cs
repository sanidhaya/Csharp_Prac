using System;

public class Foo{
    private string bar;

    public string Bar{
        get{ return bar; }
        set{ bar = value;}
    }
}

class P1{
    static void Testmeth(int myPerm){
        string Permission = "Admin|Manager";
        int StaticPerm = 55;

        if (Permission.Contains("Admin")){
            if (myPerm > StaticPerm){
                Console.WriteLine("You are an Admin\n");
            }
            else{
                Console.WriteLine("You are not an Admin\n");
            }
        }else if (Permission.Contains("Manager\n")){
            if (myPerm > StaticPerm){
                Console.WriteLine("You are a Manager\n");
            }
            else{
                Console.WriteLine("You are not a Manager\n");
            }
        }
        else{
            Console.WriteLine("You are not an Admin or Manager\n");
        }
    }

    static void Main(){
        int StaticPerm1 = 90;
        int StaticPerm2 = 34;
        int StaticPerm3 = 11;

        Testmeth(StaticPerm1);
        Testmeth(StaticPerm2);
        Testmeth(StaticPerm3);
    }
}

