
using Microsoft.AspNetCore.Mvc;

namespace _01WebApi.Controllers
{

    [ApiController]
    // [Route("")] This configures the api to work at the base route. eg is server works at localhost:7033, this get below will be 
    // present at localhost:7033/

    // [Route("[controller]")]
    // This sets the base route to https://localhost:7033/Employee

    [Route("myRoute")]
    public class EmployeeController : ControllerBase
    {
        public EmployeeController()
        {

        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok("Hello");
        }

        [HttpGet("{id:int}")] // Make sure no spaces
        public IActionResult Get(int id)
        {
            return Ok(new { uuid = id });
        }

    }

}