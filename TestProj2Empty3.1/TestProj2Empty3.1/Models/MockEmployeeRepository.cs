using System;
using System.Collections.Generic;
using System.Linq;

namespace TestProj2Empty3._1.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private readonly List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>() {
                new Employee() {Id = new Guid(), Name = "John", Email = "johndoe@gmail.com"},
                new Employee() {Id = new Guid(), Name = "Jane", Email = "janedoe@gmail.com"},
                new Employee() {Id = new Guid(), Name = "Jacob", Email = "jacobdoe@gmail.com"}
            };
        }
        public Employee GetEmployee(string Name)
        {
            return _employeeList.FirstOrDefault(e => Name.Equals(e.Name));
        }
    }
}
