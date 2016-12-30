namespace EmplSys.WebAPI.Controllers
{
    using AutoMapper;
    using Data.Interfaces;
    using Data.Models;
    using DataTransferModels;
    using Services.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Web;
    using System.Web.Http;

    public class EmployeesController : ApiController
    {
        private readonly IEmployeesService employeeService;
        private readonly IMapper mapper;

        public EmployeesController(IEmployeesService employeeService, IMapper mapper)
        {
            this.employeeService = employeeService;
            this.mapper = mapper;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IHttpActionResult> Get()
        {
            var allEmployeesDb = await this.employeeService.GetAll().ToListAsync();
            var allEmployeeDtos = this.mapper.Map<IEnumerable<EmployeeDto>>(allEmployeesDb);

            return this.Ok(allEmployeeDtos);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IHttpActionResult> Get(int id)
        {
            var employeeDb = await this.employeeService.EmployeeById(id).FirstOrDefaultAsync();

            return this.Ok(this.mapper.Map<EmployeeDto>(employeeDb));
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IHttpActionResult> Get(string email)
        {
            var employeeDb = await this.employeeService.EmployeeByEmail(email).FirstOrDefaultAsync();

            return this.Ok(this.mapper.Map<EmployeeDto>(employeeDb));
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IHttpActionResult> Get(string firstName, string surName, string lastName)
        {
            var employeeDb = await this.employeeService.EmployeeByFullName(firstName, surName, lastName).FirstOrDefaultAsync();

            return this.Ok(this.mapper.Map<EmployeeDto>(employeeDb));
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IHttpActionResult> Post([FromBody]EmployeeDto newEmployee)
        {
            var newEmployeeDb = this.mapper.Map<Employee>(newEmployee);

            return this.Ok(await this.employeeService.AddNew(newEmployeeDb));
        }

        [HttpDelete]
        [AllowAnonymous]
        public async Task<IHttpActionResult> Delete(int id)
        {
            var employee = await this.employeeService.Delete(id);

            return this.Ok(employee);
        }

        [HttpDelete]
        [AllowAnonymous]
        public async Task<IHttpActionResult> Delete(string email)
        {
            var employee = await this.employeeService.Delete(email);

            return this.Ok(employee);
        }
    }
}