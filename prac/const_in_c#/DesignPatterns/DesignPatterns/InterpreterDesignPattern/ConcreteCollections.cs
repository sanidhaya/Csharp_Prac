using System.Collections.Generic;

class ConcreteCollection : IAbstractionCollection{

    //the following collection object is going to hold a list of employees
    private List<Employee> listEmployee = new List<Employee>();

    //Create iterator is going to create and return the iterator object
    public Iterator CreateIterator(){
        return new Iterator(this);
    }

    //return the count of elements present in the collection
    public int Count{
        get{return listEmployee.Count;}
    }

    //add items to the collection
    public void AddEmployee(Employee employee)
    {
        listEmployee.Add(employee);
    }

    //get items from collection based on the index position
    public Employee GetEmployee(int IndexPosition)
    {
        return listEmployee[IndexPosition];
    }
}