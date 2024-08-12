namespace _01WebApi.Models;

public class EmployeeDto
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public int Salary { get; set; }
    public string Department { get; set; } = string.Empty;
    public string Position { get; set; } = string.Empty;
    public DateTime? LastWorkingDate {get; set; }
    public DateTime HireDate { get; set; }
    public DateTime DateOfBirth { get; set; }


    // * Calculated Properties
    // fullName
    // isActive
    // AnnualSalary
    // YearsInCurrentRole
    // Age

}
