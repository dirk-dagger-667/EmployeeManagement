namespace EmplSys.Data.Interfaces
{
    using Models;
    using System.Threading.Tasks;

    public interface IEmplSysData
    {
        IGenericRepository<Employee> Employees { get; }

        int SaveChanges();

        Task<int> SaveChangesAsync();
    }
}

