using System.Collections.Generic;

namespace Employees.Models
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        Employee Add(Employee Emp);
        void Remove(int Key);
        void update(Employee Emp);
        Employee Find(int ID);
    }
}