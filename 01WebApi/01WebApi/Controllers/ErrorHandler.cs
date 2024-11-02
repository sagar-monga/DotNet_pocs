using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _01WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ErrorHandler : ControllerBase
    {
        [Route("/error")]
        protected IActionResult HandleError()
        {
            var problemDetails = new ProblemDetails
            {
                Title = "An error occurred",
                Status = StatusCodes.Status500InternalServerError,
                Detail = "Internal Server Error",
                Instance = HttpContext.Request.Path
            };

            return StatusCode(StatusCodes.Status500InternalServerError, problemDetails);
        }
    }
}
