
using _01WebApi.Interfaces;
using _01WebApi.Models;
using _01WebApi.Models.RequestModels;
using _01WebApi.Services;
using Microsoft.AspNetCore.JsonPatch;
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

        private ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            // * Can be done but cumbersome
            // var temp = new JsonResult(EmployeeDataStore.Current.Employees);
            // temp.StatusCode = 200;

            return new JsonResult(EmployeeDataStore.Current.Employees);
        }

        [HttpGet("{id:int}", Name = "GetEmployee")] // Make sure no spaces
        // [HttpGet("{id}")] // Alternate notation, infers type from function parameter
        public ActionResult<EmployeeDto> Get(int id)
        {
            var employee = EmployeeDataStore.Current.Employees.FirstOrDefault(e => e.Id == id);

            var greetingService = HttpContext.RequestServices.GetService<IGreetingService>();

            if (employee == null)
            {
                greetingService?.Greet();
                _logger.LogWarning($"Employee with id {id} not found");
                return NotFound();
            }

            return Ok(employee);

            // return new JsonResult(EmployeeDataStore.Current.Employees.FirstOrDefault(e => e.Id == id)); // returns single entity, if not found then null
            // return new JsonResult(EmployeeDataStore.Current.Employees.Where(e => e.Id == id)); // returns array, if no result then []
        }

        [HttpPost]
        // Works even if we omit [FromBody] as using APIController attribute.
        public ActionResult Add(EmployeeRequestModelDto employeeRequestModel)
        {
            var count = EmployeeDataStore.Current.Employees.Count();

            // Works but this mapping is cumbersome and can lead to errors
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
                if (count == 210)
                {
                    throw new Exception("Max Count reached");
                }
                EmployeeDataStore.Current.Employees.Add(newEmployee);
                return CreatedAtRoute("GetEmployee",
                new
                {
                    id = newEmployee.Id,
                }, newEmployee);  // newEmployee ends up in the response.
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception {0} occurred", ex);
                // TODO: Check if something better can be returned.
                return Ok(false);
            }
        }

        [HttpPut("{id}")]
        public ActionResult FullUpdate(int id, EmployeeDtoForUpdate newEmployeeDetails)
        {
            var employeeFromStore = EmployeeDataStore.Current.Employees.FirstOrDefault(e => e.Id == id);

            if (employeeFromStore == null)
            {
                return NotFound("Employee not found");
            }

            employeeFromStore.FirstName = newEmployeeDetails.FirstName;
            employeeFromStore.LastName = newEmployeeDetails.LastName;
            employeeFromStore.Salary = newEmployeeDetails.Salary;
            employeeFromStore.Department = newEmployeeDetails.Department;
            employeeFromStore.Position = newEmployeeDetails.Position;
            employeeFromStore.LastWorkingDate = newEmployeeDetails.LastWorkingDate;
            employeeFromStore.HireDate = newEmployeeDetails.HireDate;
            employeeFromStore.DateOfBirth = newEmployeeDetails.DateOfBirth;

            //* Can return NoContent or the updated employee details as required by application
            return NoContent();
            // return Ok(employeeFromStore);
        }

        [HttpPatch("{id}")]
        public ActionResult PartialUpdate(int id, JsonPatchDocument<EmployeeDtoForUpdate> patchDocument)
        {
            var employeeFromStore = EmployeeDataStore.Current.Employees.FirstOrDefault(e => e.Id == id);

            if (employeeFromStore == null)
            {
                return NotFound();
            }

            var employeeToPatch = new EmployeeDtoForUpdate()
            {
                FirstName = employeeFromStore.FirstName,
                LastName = employeeFromStore.LastName,
                Salary = employeeFromStore.Salary,
                Department = employeeFromStore.Department,
                Position = employeeFromStore.Position,
                LastWorkingDate = employeeFromStore.LastWorkingDate,
                HireDate = employeeFromStore.HireDate,
                DateOfBirth = employeeFromStore.DateOfBirth,
            };



            patchDocument.ApplyTo(employeeToPatch, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(employeeToPatch);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var employeeFromStore = EmployeeDataStore.Current.Employees.FirstOrDefault(e => e.Id == id);

            if (employeeFromStore == null)
            {
                return NotFound();
            }

            EmployeeDataStore.Current.Employees.Remove(employeeFromStore);

            return NoContent();
        }
    }

}