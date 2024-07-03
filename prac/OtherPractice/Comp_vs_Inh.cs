public class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public void StartEngine()
    {
        Console.WriteLine("Engine started");
    }
}

public class Engine
{
    public string Type { get; set; }

    public void Start()
    {
        Console.WriteLine("Engine started");
    }
}

public class Car : Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public Engine CarEngine { get; set; } // Composition

    public Car()
    {
        CarEngine = new Engine();
    }

    public void StartCar()
    {
        CarEngine.Start();
    }
}