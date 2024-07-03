public class Singleton
{
    private static Singleton instance;

    private Singleton() { }

    public static Singleton GetInstance()
    {
        if (instance == null)
        {
            instance = new Singleton();
        }
        return instance;
    }

    public override string ToString()
    {
        return "this is an instance of Singleton";
    }
}

// class Program
// {
//     static void Main()
//     {
//         Singleton obj = Singleton.GetInstance();
//         Console.WriteLine(obj);
//     }
// }
