using _01WebApi.Entities;

namespace _01WebApi.Interfaces;

public interface IEmployeeRepository
{
    Task<Employee> ReadById(int id);
    Task<IEnumerable<Employee>> ReadAll();
    Task<bool> Exists(int id);
    void Create(Employee employee);
    void Delete(Employee employee);
    Task<bool> SaveChangesAsync();
}