namespace _01WebApi.Models;

public class EmployeeDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int? Salary { get; set; }
    public string? Department { get; set; }
    public string? Position { get; set; }

}
