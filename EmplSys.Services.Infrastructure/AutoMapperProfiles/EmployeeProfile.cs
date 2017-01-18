namespace EmplSys.Services.Infrastructure.AutoMapperProfiles
{
    using AutoMapper;
    using Data.Models;
    using DataTransferModels.Employee;

    public class EmployeeProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Employee, EmployeeDto>();
            CreateMap<EmployeeDto, Employee>();
        }
    }
}
