//Write a LINQ query to find the employee with the most tasks completed in the last month.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    public class Employee
    {
        public string _name {  get; set; }
        private int _age { get; set; }
        public List<Task> _tasks { get; set; }    

        public Employee(string name, int age)
        {
            _name = name;
            _age = age;
            _tasks = new List<Task>();
        }
    }

    public class Task
    {
        public DateTime _start_date { get; set; }
        public DateTime _end_date { get; set; }
        public TimeSpan _length { get; set; }
        public string _name { get; set; }
        public Employee _employee { get; set; }
        public bool _completed { get; set; }

        public Task(DateTime start_date, DateTime end_date, string name, bool completed)
        {
            _start_date = start_date;
            _end_date = end_date;
            _length = _start_date - _end_date;
            _name = name;
            _completed = completed;
        }

        public void AssignToEmployee(Employee employee)
        {
            _employee = employee;
            employee._tasks.Add(this);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee("John", 22),
                new Employee("Mary", 23),
                new Employee("Peter", 24),
                new Employee("Jane", 25)
            };

            Task task1 = new Task(new DateTime(2024, 4, 2, 0, 0, 0),new DateTime(2024, 5,3,0,0,0), "Task1" ,true);
            Task task2 = new Task(new DateTime(2024, 4, 3, 0, 0, 0), new DateTime(2024, 5,4, 0, 0, 0), "Task2", true);
            Task task3 = new Task(new DateTime(2024, 4, 4, 0, 0, 0), new DateTime(2024, 5, 5, 0, 0, 0), "Task3", true);
            Task task4 = new Task(new DateTime(2024, 4, 5, 0, 0, 0), new DateTime(2024, 5, 6, 0, 0, 0), "Task4", true);
            Task task5 = new Task(new DateTime(2024, 4, 6, 0, 0, 0), new DateTime(2024, 5, 7, 0, 0, 0), "Task5", true);
            Task task6 = new Task(new DateTime(2024, 4, 7, 0, 0, 0), new DateTime(2024, 5, 8, 0, 0, 0), "Task6", true);
            Task task7 = new Task(new DateTime(2024, 4, 8, 0, 0, 0), new DateTime(2024, 5, 9, 0, 0, 0), "Task7", true);
            Task task8 = new Task(new DateTime(2024, 4, 9, 0, 0, 0), new DateTime(2024, 5, 10, 0, 0, 0), "Task8", true);
            Task task9 = new Task(new DateTime(2024, 4, 10, 0, 0, 0), new DateTime(2024, 5, 11, 0, 0, 0), "Task9", true);
            Task task10 = new Task(new DateTime(2024, 4, 11, 0, 0, 0), new DateTime(2024, 5, 12, 0, 0, 0), "Task10", true);
            Task task11 = new Task(new DateTime(2024, 4, 12, 0, 0, 0), new DateTime(2024, 5, 13, 0, 0, 0), "Task11", true);

            task1.AssignToEmployee(employees[0]);
            task2.AssignToEmployee(employees[0]);
            task3.AssignToEmployee(employees[0]);
            task4.AssignToEmployee(employees[0]);
            task5.AssignToEmployee(employees[0]);
            task6.AssignToEmployee(employees[1]);
            task7.AssignToEmployee(employees[1]);
            task8.AssignToEmployee(employees[2]);
            task9.AssignToEmployee(employees[2]);
            task10.AssignToEmployee(employees[3]);
            task11.AssignToEmployee(employees[1]);

            DateTime OneMonthAgo = DateTime.Now.AddMonths(-1);

            var most_work = (from employee in employees
                             let completed_task = employee._tasks.Count(task => task._completed && task._end_date > OneMonthAgo)
                             orderby completed_task descending
                             select employee).First();

            if (most_work != null)
            {
                Console.WriteLine($"Employee with the most tasks completed in the last month: {most_work._name}");
            }
            else
            {
                Console.WriteLine("No employees have completed tasks in the last month.");
            }
        }
    }
}
