namespace EmplSys.WebAPI.Controllers
{
    using Data.Interfaces;
    using Data.Models;
    using Services.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Http;

    public class EmployeesController : ApiController
    {
        private readonly IEmployeesService employeeService;

        public EmployeesController(IEmployeesService employeeService)
        {

        }
    }
}