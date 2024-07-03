using System;
using System.Threading;

public class ServerClass{
    public void InstanceMethod(){
        Console.WriteLine("Instance Method 1 is running on this thread");

        //pause to make thread apparent 
        Thread.Sleep(3000);
        Console.WriteLine("Instance Method 1 by the worker thread has ended");
    }

    public static void StaticMethod(){
        Console.WriteLine("Static Method 1 is running on this thread");

        //pause to make thread apparent 
        Thread.Sleep(3000);
        Console.WriteLine("Static Method 1 by the worker thread has ended");
    }
}

public class Simple{
    public static void Main(){
        ServerClass serverobj = new ServerClass();

        Thread InstanceCaller = new Thread(new ThreadStart(serverobj.InstanceMethod));

        InstanceCaller.Start();

        Console.WriteLine("The main thread calls after starting the new instance caller thread");

        Thread StaticCaller = new Thread(new ThreadStart(ServerClass.StaticMethod));

        StaticCaller.Start();

        Console.WriteLine("The main thread calls after starting the new static caller thread");
    }
}