using System;
using Microsoft.AspNetCore.Mvc;
using TestProj2Empty3._1.Models;

namespace TestProj2Empty3._1.Controllers
{
    public class HomeController : Controller
    {
        //* readonly can only be initialized during definition and in non static constructor
        private readonly IEmployeeRepository _employeeRepository;

        //* DI is done in the ctor.
        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public Employee Index()
        {
            string Name = "John";
            // return "Hello from MVC";
            // return Json(new { id = 1, name = "test" });
            return _employeeRepository.GetEmployee(Name);
        }
    }
}
