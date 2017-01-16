namespace EmplSys.Data.Interfaces
{
    using Models;
    using System.Threading.Tasks;

    public interface IEmplSysData
    {
        IGenericRepository<Employee> Employees { get; }

        IGenericRepository<AdditionalContactInfo> AdditionalContactInfos { get; }

        IGenericRepository<CorporateHistory> CorporateHistories { get; }

        IGenericRepository<Country> Coutries { get; }

        IGenericRepository<Municipality> Municipalities { get; }

        IGenericRepository<PlaceOfResidence> PlacesOfResidence { get; }

        IGenericRepository<Office> Offices { get; }

        IGenericRepository<Position> Positions { get; }

        IGenericRepository<Recommendation> Recommendations { get; }

        IGenericRepository<Training> Trainings { get; }

        IGenericRepository<User> Users { get; }

        IGenericRepository<Warning> Warnings { get; }

        int SaveChanges();

        Task<int> SaveChangesAsync();
    }
}

