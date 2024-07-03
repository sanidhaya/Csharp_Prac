public interface ISubject{
    //Register an observer to the user
    void RegisterObserver(IObserver observer);
    //Remove an observer from the user
    void RemoveObserver(IObserver observer);
    //Notify all the observers when the state is changed
    void NotifyObserver();
}

