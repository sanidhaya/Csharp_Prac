public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
}

public class Person
{
    //Properties
    public string Name {get; set;}
    public int Age {get; set;}
    public Address Address {get; set;}

    public void SayHello()
    {
        Console.WriteLine($"Hello, my name is {Name} and my age us {Age} years");
    }

    public Person(string name, int age){
        Name = name;
        Age = age;
    }

    public Person(Person other)
    {
        Name = other.Name;
        Age = other.Age;
        Address = new Address{
            Street= other.Address.Street,
            City = other.Address.City,
            State = other.Address.State,
            Zip = other.Address.Zip
        };
    }
}

// public class Program{
//     public static void Main(){
//         Address a1 = new Address{
//             Street = "A1",
//             City = "C1",
//             State = "S1",
//             Zip = "Z1"
//         };

//         Person p1 = new Person ("n1",22){Address = a1};
//         Person p2 = new Person(p1);

//         Console.WriteLine($"{p1.Age} is {p1.Name} has address {p1.Address.State},{p1.Address.City},{p1.Address.Street},{p1.Address.Zip}");
//         Console.WriteLine($"{p2.Address} is {p2.Name}");
//     }
// }