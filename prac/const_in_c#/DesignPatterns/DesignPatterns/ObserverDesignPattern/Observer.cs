class Observer : IObserver{
    public string Username{get;set;}

    public Observer(string username){
        Username = username;
    }

    public void AddSubscriber(ISubject subject){
        subject.RegisterObserver(this);
    }

    public void RemoveSubscriber(ISubject subject){
        subject.RemoveObserver(this);
    }

    public void Update(string availability){
        Console.WriteLine("Hello " + Username + ", Product is now " + availability + " on Amazon");
    }
}