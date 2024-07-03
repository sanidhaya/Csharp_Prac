public class StaticConstructorExample
{
    public static int StaticValue;

    static StaticConstructorExample()
    {
        StaticValue = 10;
    }
}

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine(StaticConstructorExample.StaticValue);  // Output: 10
//     }
// }
