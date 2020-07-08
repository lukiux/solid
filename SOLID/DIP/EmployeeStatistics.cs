using System;
using System.Linq;
using SOLID.DIP;

namespace SOLID
{
    public class EmployeeStatistics
    {
        //private readonly EmployeeAdmin _empManager;
        private readonly IEmployeeSearchable _emp;

        /*public EmployeeStatistics(EmployeeAdmin empManager)
        {
            _empManager = empManager;
        }*/

        public EmployeeStatistics(IEmployeeSearchable emp)
        {
            _emp = emp;
        }

        /*public int CountFemaleManagers() =>
            _empManager.Employees.Count(emp => emp.Gender == Gender.Female && emp.Position == Position.Manager);*/

        public int CountFemaleManagers() => _emp.GetEmployessByGenderAndPosition(Gender.Female, Position.Manager).Count();

        public int CountFemaleAdmins() => _emp.GetEmployessByGenderAndPosition(Gender.Female, Position.Administrator).Count();
    }
}
