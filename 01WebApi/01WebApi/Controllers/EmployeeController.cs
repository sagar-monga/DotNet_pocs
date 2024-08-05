
using _01WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace _01WebApi.Controllers
{

    [ApiController] //* Attribute for improving dev experience like automatic returning 400 on bad request requiring routing etc
    // [Route("")] This configures the api to work at the base route. eg is server works at localhost:7033, this get below will be 
    // present at localhost:7033/

    // [Route("[controller]")]
    // This sets the base route to https://localhost:7033/Employee

    // [Route("api/[controller]")] vs [Route("api/employee")] - The first might change during refactoring of controller thus not recommended
    [Route("api/employee")] //* attribute for routing, matches action to controller
    // public class EmployeeController : Controller //* Controller contains additional functionality like working with Views
    public class EmployeeController : ControllerBase //* ControllerBase contains basic functionality the Controller needs
    {
        public EmployeeController()
        {

        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return new JsonResult(EmployeeDataStore.Current.Employees);
        }

        [HttpGet("{id:int}")] // Make sure no spaces
        // [HttpGet("{id}")] // Alternate notation, infers type from function parameter
        public IActionResult Get(int id)
        {
            return new JsonResult(EmployeeDataStore.Current.Employees.Where(e => e.Id == id));
        }

    }

}