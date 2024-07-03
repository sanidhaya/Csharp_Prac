//The subject have states and notifies all observers when state changes
public class Subject : ISubject{

    // the list of observer will be stored in this observer
    private List<IObserver> observers = new List<IObserver>(); 

    //the following properties are going to be store the Product information
    private string ProductName{get; set;}
    private int ProductPrice{get; set;}
    private string Availability{get;set;}

    //initialize the product price using the constructors
    public Subject(string productname,int productprice,string availability){
        ProductName = productname;
        ProductPrice = productprice;
        Availability = availability;
    }

    public string GetAvailability()
        {
            return Availability;
        }

    public void SetAvailability(string availability){
        Console.WriteLine("Availability changed from out of stock to available");
        NotifyObserver();
    }

    //The observer will register the product
    public void RegisterObserver(IObserver observer){
        observers.Add(observer);
        Console.WriteLine("observer added "+ observer);
    }

    //Unregister the observer from product
    public void RemoveObserver(IObserver observer){
        observers.Remove(observer);
        Console.WriteLine("observer removed "+ observer);
    }

    //The following method notifies
    public void NotifyObserver(){
        Console.WriteLine("Product Name :"
                            + ProductName + ", product Price : "
                            + ProductPrice + " is Now available. So, notifying all Registered users ");
            Console.WriteLine();
            foreach (IObserver observer in observers)
            {
                //By Calling the Update method, we are sending notifications to observers
                observer.Update(Availability);
            }
    }

}