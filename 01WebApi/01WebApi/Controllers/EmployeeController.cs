
using _01WebApi.Models;
using _01WebApi.Models.RequestModels;
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
            // * Can be done but cumbersome
            // var temp = new JsonResult(EmployeeDataStore.Current.Employees);
            // temp.StatusCode = 200;

            return new JsonResult(EmployeeDataStore.Current.Employees);
        }

        [HttpGet("{id:int}")] // Make sure no spaces
        // [HttpGet("{id}")] // Alternate notation, infers type from function parameter
        public ActionResult<EmployeeDto> Get(int id)
        {
            var employee = EmployeeDataStore.Current.Employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);

            // return new JsonResult(EmployeeDataStore.Current.Employees.FirstOrDefault(e => e.Id == id)); // returns single entity, if not found then null
            // return new JsonResult(EmployeeDataStore.Current.Employees.Where(e => e.Id == id)); // returns array, if no result then []
        }

        [HttpPost]
        public ActionResult Add([FromBody] EmployeeRequestModelDto employeeRequestModel)
        {
            var count = EmployeeDataStore.Current.Employees.Count();

            EmployeeDto newEmployee = new EmployeeDto()
            {
                Id = count + 1,
                FirstName = employeeRequestModel.FirstName,
                LastName = employeeRequestModel.LastName,
                Salary = employeeRequestModel.Salary,
                Department = employeeRequestModel.Department,
                Position = employeeRequestModel.Position,
                HireDate = employeeRequestModel.HireDate,
                DateOfBirth = employeeRequestModel.DateOfBirth,
            };

            try
            {
                // if(count == 200) {
                //     throw new Exception("Max Count reached");
                // }
                EmployeeDataStore.Current.Employees.Add(newEmployee);
                return Ok(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception {0} occurred", ex);
                return NotFound();
            }
        }

    }

}