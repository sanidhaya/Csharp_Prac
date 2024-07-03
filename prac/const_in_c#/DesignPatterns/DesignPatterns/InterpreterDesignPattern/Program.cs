public class ProgramIteratorClass{
    static void Main(){
        ConcreteCollection collection = new ConcreteCollection();

        collection.AddEmployee(new Employee("Anurag",100));
        collection.AddEmployee(new Employee("Pranaya",200));
        collection.AddEmployee(new Employee("Sanidhaya",300));
        collection.AddEmployee(new Employee("Shreya",400));

        Iterator iterator = collection.CreateIterator();

        for(Employee emp = iterator.First(); !iterator.IsCompleted ; emp = iterator.Next()){
            Console.WriteLine($"Namev {emp.Name} hs id {emp.Id}");
        }

        Console.ReadLine();
    }
}