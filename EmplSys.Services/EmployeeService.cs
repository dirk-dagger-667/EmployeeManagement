namespace EmplSys.Services
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Data.Models;
    using WebAPI.Models;
    using Data.Interfaces;

    public class EmployeeService : IEmployeesService
    {
        private readonly IGenericRepository<Employee> employees;

        public EmployeeService(IGenericRepository<Employee> employees)
        {
            this.employees = employees;
        }

        public Employee AddNew(EmployeeDto newEmployee)
        {
            var employeeDb = this.EmplDtoToEmpl(newEmployee);

            this.employees.Add(employeeDb);
            this.employees.SaveChanges();

            return employeeDb;
        }

        public Employee Delete(int id)
        {
            var employeeDb = this.EmployeeById(id);

            this.employees.Delete(employeeDb);
            this.employees.SaveChanges();

            return employeeDb;
        }

        public Employee Edit(EmployeeDto changedEmployee)
        {
            var employeeDb = this.EmplDtoToEmpl(changedEmployee);

            this.employees.Update(employeeDb);
        }

        public Employee EmplDtoToEmpl(EmployeeDto emplDto)
        {
            return new Employee()
            {
                EmployeeId = emplDto.EmployeeId,
                FirstName = emplDto.FirstName,
                SurName = emplDto.SurName,
                LastName = emplDto.LastName,
                Email = emplDto.Email
            };
        }

        public Employee EmployeeById(int id)
        {
            throw new NotImplementedException();
        }

        public EmployeeDto EmplToEmplDto(Employee employee)
        {
            return new EmployeeDto()
            {
                EmployeeId = employee.EmployeeId,
                FirstName = employee.FirstName,
                SurName = employee.SurName,
                LastName = employee.LastName,
                Email = employee.Email
            };
        }

        public IEnumerable<Employee> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
