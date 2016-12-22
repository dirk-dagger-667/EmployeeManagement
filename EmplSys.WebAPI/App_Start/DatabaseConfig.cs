namespace EmplSys.WebAPI.App_Start
{
    using Data;
    using System.Data.Entity;

    public static class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<EmplSysDbContext, Configuration>());
        }
    }
}