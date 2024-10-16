using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _01WebApi.Entities;

public class Employee
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(50)]
    public string LastName { get; set; }

    public int Salary { get; set; }

    [Required]
    [MaxLength(100)]
    public string Department { get; set; }

    [Required]
    [MaxLength(100)]
    public string Position { get; set; }

    // public DateTime? LastWorkingDate { get; set; }

    [Required]
    public DateTime HireDate { get; set; }

    [Required]
    public DateTime DateOfBirth { get; set; }

    public Employee(string firstName, string lastName, string department, string position, DateTime hireDate, DateTime dateOfBirth)
    {
        FirstName = firstName;
        LastName = lastName;
        Department = department;
        Position = position;
        HireDate = hireDate;
        DateOfBirth = dateOfBirth;
    }

}
