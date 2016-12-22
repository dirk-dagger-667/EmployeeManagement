namespace EmplSys.Services.Interfaces
{
    using Data.Models;
    using System.Collections.Generic;
    using WebAPI.Models;

    public interface IEmployeesService
    {
        Employee EmployeeById(int id);

        IEnumerable<Employee> GetAll();

        Employee AddNew(EmployeeDto newEmployee);

        Employee Edit(EmployeeDto changedEmployee);

        Employee Delete(int id);

        Employee EmplDtoToEmpl(EmployeeDto emplDto);

        EmployeeDto EmplToEmplDto(Employee employee);
    }
}
