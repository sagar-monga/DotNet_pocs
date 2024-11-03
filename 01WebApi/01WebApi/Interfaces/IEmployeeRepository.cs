using _01WebApi.Entities;

namespace _01WebApi.Interfaces;

public interface IEmployeeRepository
{
    Task<Employee> ReadByIdAsync(int id);
    Task<IEnumerable<Employee>> ReadAllAsync();
    Task<bool> ExistsAsync(int id);
    void Create(Employee employee);
    void Delete(Employee employee);
    Task<bool> SaveChangesAsync();
}