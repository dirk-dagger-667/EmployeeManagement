namespace EmplSys.Data
{
    using Interfaces;
    using Models;
    using Repositories;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class EmplSysData : IEmplSysData
    {
        private IEmplSysDbContext context;
        private IDictionary<Type, object> repositories;

        public EmplSysData()
            :this (new EmplSysDbContext())
        {
        }

        public EmplSysData(IEmplSysDbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public IGenericRepository<Employee> Employees
        {
            get
            {
                return this.GetRepository<Employee>();
            }
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        public Task<int> SaveChangesAsync()
        {
            return this.context.SaveChangesAsync();
        }

        private IGenericRepository<T> GetRepository<T>() where T : class
        {
            var typeOfModel = typeof(T);

            if (!this.repositories.ContainsKey(typeOfModel))
            {
                var type = typeof(GenericRepository<T>);

                this.repositories.Add(typeOfModel, Activator.CreateInstance(type, this.context));
            }

            return (IGenericRepository<T>)this.repositories[typeOfModel];
        }
    }
}
