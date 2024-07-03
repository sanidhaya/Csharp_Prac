class Iterator : IAbstractIterator{
    private ConcreteCollection Collection;

    //the index position to access elements of collection
    private int Current =0;

    //The following variable is used to move to the next element from the current element
    private readonly int Step = 1;

    //Constructor
    public Iterator(ConcreteCollection Collection){
        //Initializing the Concrete Aggregate variable using Constructor
        this.Collection = Collection;
    }

    public Employee First(){
        //setting current as 0  to access the First element of sequence 
        Current = 0;
        return Collection.GetEmployee(Current);
    }
    
    //Get next item from the Collection
    public Employee Next(){
        //increase the current index Position by step (Step = 1)
        //to access the next element from the collection
        Current += Step;
        if (!IsCompleted){
            return Collection.GetEmployee(Current);
        }else{
            return null;
        }
    }
    //Check wether the iterator is complete
    public bool IsCompleted
    {
        get {return Current >= Collection.Count;}
    }
}