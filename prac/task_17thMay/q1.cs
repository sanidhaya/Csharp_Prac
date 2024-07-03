//Write a LINQ query to find the employee with the most tasks completed in the last month.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Employee
{
	private string _name {  get; set; }
        private int _age { get; set; }
        public List<Task> _tasks { get; set; }    

        public Employee(string name, int age)
        {
        	_name = name;
            	_age = age;
            	_tasks = new List<Task>();
        }
}

class Task
{
        public DateTime _length { get; set; }
        public string _name { get; set; }
        public Employee _employee { get; set; }
        public bool _completed { get; set; }

        public Task(DateTime length, string name)
        {
            	_length = length;
            	_name = name;
        }

        public void AssignToEmployee(Employee employee)
        {
            	_employee = employee;
            	employee._tasks.Add(this);
        }
}

class Program
{
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            	{
                new Employee("John", 22),
                new Employee("Mary", 23),
                new Employee("Peter", 24),
                new Employee("Jane", 25),
                new Employee("Raj", 26),
                new Employee("Ravi", 27),
            	};            
	}
}

