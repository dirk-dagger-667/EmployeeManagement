namespace EmplSys.Data
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Interfaces;
    using Models;
    using Repositories;

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

        public IGenericRepository<AdditionalContactInfo> AdditionalContactInfos
        {
            get { return this.GetRepository<AdditionalContactInfo>(); }
        }

        public IGenericRepository<CorporateHistory> CorporateHistories
        {
            get { return this.GetRepository<CorporateHistory>(); }
        }

        public IGenericRepository<Country> Coutries
        {
            get { return this.GetRepository<Country>(); }
        }

        public IGenericRepository<Employee> Employees
        {
            get { return this.GetRepository<Employee>(); }
        }

        public IGenericRepository<Municipality> Municipalities
        {
            get { return this.GetRepository<Municipality>(); }
        }

        public IGenericRepository<Office> Offices
        {
            get { return this.GetRepository<Office>(); }
        }

        public IGenericRepository<PlaceOfResidence> PlacesOfResidence
        {
            get { return this.GetRepository<PlaceOfResidence>(); }
        }

        public IGenericRepository<Position> Positions
        {
            get { return this.GetRepository<Position>(); }
        }

        public IGenericRepository<Recommendation> Recommendations
        {
            get { return this.GetRepository<Recommendation>(); }
        }

        public IGenericRepository<Training> Trainings
        {
            get { return this.GetRepository<Training>(); }
        }

        public IGenericRepository<User> Users
        {
            get { return this.GetRepository<User>(); }
        }

        public IGenericRepository<Warning> Warnings
        {
            get { return this.GetRepository<Warning>(); }
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
