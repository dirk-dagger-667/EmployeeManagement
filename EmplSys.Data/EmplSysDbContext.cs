namespace EmplSys.Data
{
    using Interfaces;
    using Models;
    using System.Data.Entity;
    using System.Threading.Tasks;

    public class EmplSysDbContext : DbContext, IEmplSysDbContext
    {
        public EmplSysDbContext()
            :base("EmployeeManagement")
        {
        }

        public virtual IDbSet<Employee> Employees { get; set; }

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
