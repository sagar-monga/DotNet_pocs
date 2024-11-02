using _01WebApi.DbContexts;
using _01WebApi.Entities;
using _01WebApi.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace _01WebApi.Services;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly EmployeeContext _context;

    public EmployeeRepository(EmployeeContext employeeContext)
    {
        _context = employeeContext;
    }

    public async Task<Employee> ReadById(int id)
    {
        return await _context.Employees.Where(e => e.Id == id).FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<Employee>> ReadAll()
    {
        return await _context.Employees.ToListAsync();
    }

    public async Task<bool> Exists(int id)
    {
        return await _context.Employees.AnyAsync(e => e.Id == id);
    }
    
    public void Create(Employee employee)
    {
        _context.Employees.Add(employee);
    }

    public void Delete(Employee employee)
    {
        _context.Employees.Remove(employee);
    }

    public async Task<bool> SaveChangesAsync()
    {
        return (await _context.SaveChangesAsync() >= 0);
    }
    
}