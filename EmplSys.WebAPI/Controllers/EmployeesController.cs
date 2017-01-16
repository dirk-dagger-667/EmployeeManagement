namespace EmplSys.WebAPI.Controllers
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Threading.Tasks;
    using System.Web.Http;
    using System.Web.Http.Cors;

    using AutoMapper;
    using Data.Models;
    using DataTransferModels;
    using Services.Interfaces;

    [EnableCorsAttribute("http://localhost:36845", "*", "*")]
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
        public async Task<IHttpActionResult> Get()
        {
            var allEmployeesDb = await this.employeeService.GetAll().ToListAsync();

            if (allEmployeesDb.Count == 0)
            {
                return this.NotFound();
            }

            var allEmployeeDtos = this.mapper.Map<IEnumerable<EmployeeDto>>(allEmployeesDb);

            return this.Ok(allEmployeeDtos);
        }

        [HttpGet]
        public async Task<IHttpActionResult> Get(int id)
        {
            var employeeDb = await this.employeeService.EmployeeById(id).FirstOrDefaultAsync();

            if (employeeDb == null)
            {
                return this.NotFound();
            }

            return this.Ok(this.mapper.Map<EmployeeDto>(employeeDb));
        }

        [HttpGet]
        public async Task<IHttpActionResult> Get(string email)
        {
            var employeeDb = await this.employeeService.EmployeeByEmail(email).FirstOrDefaultAsync();

            if (employeeDb == null)
            {
                return this.NotFound();
            }

            return this.Ok(this.mapper.Map<EmployeeDto>(employeeDb));
        }

        [HttpGet]
        public async Task<IHttpActionResult> Get(string firstName, string surName, string lastName)
        {
            var employeeDb = await this.employeeService.EmployeeByFullName(firstName, surName, lastName).FirstOrDefaultAsync();

            if (employeeDb == null)
            {
                return this.NotFound();
            }

            return this.Ok(this.mapper.Map<EmployeeDto>(employeeDb));
        }

        [HttpPost]
        [Authorize]
        public async Task<IHttpActionResult> Post([FromBody]EmployeeDto newEmployee)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            var newEmployeeDb = this.mapper.Map<Employee>(newEmployee);

            return this.Ok(await this.employeeService.AddNew(newEmployeeDb));
        }

        [HttpDelete]
        [Authorize]
        public async Task<IHttpActionResult> Delete(int id)
        {
            var employee = await this.employeeService.Delete(id);

            return this.Ok(employee);
        }

        [HttpDelete]
        [Authorize]
        public async Task<IHttpActionResult> Delete(string email)
        {
            var employee = await this.employeeService.Delete(email);

            return this.Ok(employee);
        }
    }
}