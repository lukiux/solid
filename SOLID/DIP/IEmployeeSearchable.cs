using System;
using System.Collections.Generic;

namespace SOLID
{
    public interface IEmployeeSearchable
    {
        IEnumerable<Employee> GetEmployessByGenderAndPosition(Gender gender, Position position);
    }
}
