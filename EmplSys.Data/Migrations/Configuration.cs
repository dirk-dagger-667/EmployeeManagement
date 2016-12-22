namespace EmplSys.Data
{
    using Models;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using EmplSys.Data;

    public sealed class Configuration : DbMigrationsConfiguration<EmplSysDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EmplSysDbContext context)
        {
            this.SeedEmployees(context);
        }

        private void SeedEmployees(EmplSysDbContext context)
        {
            if (context.Employees.Any())
            {
                return;
            }

            context.Employees.AddOrUpdate( new Employee() { FirstName = "John", SurName = "Johnson", LastName = "Johnson", Email = "jjj@asd.asd" },
                new Employee() { FirstName = "Ivan", SurName = "Yordanov", LastName = "Stoyanov", Email = "iys@asd.asd" },
                new Employee() { FirstName = "Maria", SurName = "Alehandro", LastName = "Escobar", Email = "mae@asd.asd" },
                new Employee() { FirstName = "Tsutomu", SurName = "Shingo", LastName = "Sonzaemon", Email = "tss@asd.asd" },
                new Employee() { FirstName = "Vibhutti", SurName = "Nandakumar", LastName = "Bhutki", Email = "vnb@asd.asd" },
                new Employee() { FirstName = "MeiMei", SurName = "LinLin", LastName = "Youanhou", Email = "mly@asd.asd"});

            context.SaveChanges();
        }
    }
}
