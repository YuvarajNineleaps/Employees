using System;
using System.Collections.Generic;
using System.Linq;

namespace Employees.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        Dictionary<int, Employee> table=new Dictionary<int, Employee>();

        public EmployeeRepository()
        {
            Console.WriteLine("Initialize");
             Employee initial=new Employee{ID=001, Name="Abc", Description="cde", Salary=10000.00F};
             Employee initial1=new Employee{ID=002, Name="Abc", Description="cde", Salary=10000.00F};
             table.Add(initial.ID, initial);
             table.Add(initial1.ID, initial1);
        }
        public IEnumerable<Employee> GetAll()
        {
            return table.Values.ToList();
        }
        public Employee Add(Employee Emp)
        {
            Console.WriteLine("Add"
            );
            table[Emp.ID] = Emp;
            // table.
            // Console.WriteLine(table.Count());
            foreach (KeyValuePair<int, Employee> kvp in table)
            {
                //textBox3.Text += ("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value.ID);
            }
            return Emp;
        }
        public void Remove(int Key)
        {}
        public void update(Employee Emp)
        {}
        public Employee Find(int ID)
        {
            return new Employee{ID=001, Name="Abc", Description="cde", Salary=10000.00F};
        }
    }
}