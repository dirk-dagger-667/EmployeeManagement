namespace EmplSys.Data
{
    using Interfaces;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System.Data.Entity;
    using System.Threading.Tasks;

    public class EmplSysDbContext : IdentityDbContext<User>, IEmplSysDbContext
    {
        public EmplSysDbContext()
            :base("EmployeeManagement", throwIfV1Schema: false)
        {
        }

        public virtual IDbSet<Employee> Employees { get; set; }

        public virtual IDbSet<AdditionalContactInfo> AdditionalContactInfos { get; set; }

        public virtual IDbSet<CorporateHistory> CorporateHistories { get; set; }

        public virtual IDbSet<Country> Countries { get; set; }

        public virtual IDbSet<Municipality> Municipalities { get; set; }

        public virtual IDbSet<PlaceOfResidence> PlacesOfResidence { get; set; }

        public virtual IDbSet<Office> Offices { get; set; }

        public virtual IDbSet<Position> Positions { get; set; }

        public virtual IDbSet<Recommendation> Recommendations { get; set; }

        public virtual IDbSet<Training> Trainings { get; set; }

        public virtual IDbSet<User> AppUsers { get; set; }

        public virtual IDbSet<Warning> Warnings { get; set; }

        public static EmplSysDbContext Create()
        {
            return new EmplSysDbContext();
        }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
