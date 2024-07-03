public class Car
{
    public string Make;
    public string Model;
    public int Year;

    //Default Constructor 
    public Car(){
        Make = "Unknown";
        Model = "Unknown";
        Year = 0;
    }

    //Parameterized Constructor
    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    //Copy constructor
    public Car(Car other)
    {
        Make = other.Make;
        Model = other.Model;
        Year = other.Year;
    }
}

class Program
{
    static void Main()
    {
        // Using the default constructor
        Car c1 = new Car();
        Console.WriteLine($"{c1.Make} Make with {c1.Model} {c1.Year}");

        //using the parameterized constructor
        Car c2  = new Car("Toyota","Corolla",2021);
        Console.WriteLine($"{c2.Make} {c2.Model} in {c2.Year}");

        //Using the copy constructor
        Car c3 = new Car(c2);
        Console.WriteLine($"{c3.Make} - {c3.Model} - {c3.Year}");
    }
}