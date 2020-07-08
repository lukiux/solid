using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLID
{
    public class EmployeeManager : IEmployeeSearchable
    {
        private readonly List<Employee> _employees;

        public EmployeeManager()
        {
            _employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public IEnumerable<Employee> GetEmployessByGenderAndPosition(Gender gender, Position position) =>
            _employees.Where(emp => emp.Gender == gender && emp.Position == position);
    }
}
