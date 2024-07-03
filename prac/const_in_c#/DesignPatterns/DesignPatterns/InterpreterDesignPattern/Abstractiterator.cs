//Interface for defining the operations for accessing and traversing elements in a sequence

interface IAbstractIterator
{
    Employee First();
    Employee Next();
    bool IsCompleted{get;}
}