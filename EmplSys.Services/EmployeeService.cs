namespace EmplSys.Services
{
    using System.Linq;
    using System.Threading.Tasks;

    using Data.Interfaces;
    using Data.Models;
    using Interfaces;

    public class EmployeeService : IEmployeesService
    {
        private readonly IGenericRepository<Employee> employees;

        public EmployeeService(IGenericRepository<Employee> employees)
        {
            this.employees = employees;
        }

        public async Task<Employee> AddNew(Employee newEmployee)
        {
            this.employees.Add(newEmployee);
            await this.employees.SaveChangesAsync();

            newEmployee.Id = this.EmployeeByEmail(newEmployee.Email).FirstOrDefault().Id;

            return newEmployee;
        }

        public async Task<Employee> Delete(int id)
        {
            var employeeDb = this.EmployeeById(id).FirstOrDefault();

            this.employees.Delete(employeeDb);
            await this.employees.SaveChangesAsync();

            return employeeDb;
        }

        public async Task<Employee> Delete(string email)
        {
            var employeeDb = this.EmployeeByEmail(email).FirstOrDefault();

            this.employees.Delete(employeeDb);
            await this.employees.SaveChangesAsync();

            return employeeDb;
        }

        public async Task<Employee> Edit(Employee changedEmployee)
        {
            this.employees.Update(changedEmployee);
            await this.employees.SaveChangesAsync();

            changedEmployee.Id = this.EmployeeByEmail(changedEmployee.Email).FirstOrDefault().Id;

            return changedEmployee;
        }

        public IQueryable<Employee> EmployeeByEmail(string email)
        {
            return this.employees.SearchFor(e => e.Email.Equals(email));
        }

        public IQueryable<Employee> EmployeeByFullName(string firstName, string surName, string lastName)
        {
            return this.employees.SearchFor(e => e.FirstName.Equals(firstName) && e.SurName.Equals(surName) && e.LastName.Equals(lastName));
        }

        public IQueryable<Employee> EmployeeById(int id)
        {
            return this.employees.SearchFor(e => e.Id == id);
        }

        public IQueryable<Employee> GetAll()
        {
            return this.employees.GetAll();
        }
    }
}
