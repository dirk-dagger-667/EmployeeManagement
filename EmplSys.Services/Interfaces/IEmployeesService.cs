namespace EmplSys.Services.Interfaces
{
    using Data.Models;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IEmployeesService
    {
        IQueryable<Employee> EmployeeById(int id);

        IQueryable<Employee> GetAll();

        IQueryable<Employee> EmployeeByFullName(string firstName, string surName, string lastName);

        IQueryable<Employee> EmployeeByEmail(string email);

        Task<Employee> AddNew(Employee newEmployee);

        Task<Employee> Edit(Employee changedEmployee);

        Task<Employee> Delete(int id);
    }
}
