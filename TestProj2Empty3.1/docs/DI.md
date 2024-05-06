# Dependency Injection

# Why DI?
In our controller etc, we want to inject our service so that the system in loosely coupled & modular.

# How is it done?
in the ctor of the controller, we add an instance of the interface of the service as a param and store it in a private field.

```
private readonly IEmployeeRepository _employeeRepository;

public HomeController(IEmployeeRepository employeeRepository)
{
    _employeeRepository = employeeRepository;
}
```

But this gives an error 
![Alt text](image-3.png)

## Why the error?
Since IEmployeeRepository is an interface, it can have any number of implementations, hence the controller is not able to figure out which implementation to use for injecting the dependency.

## Fixing the error
In startup.cs, inside `ConfigureServices`, we have an IServiceCollection interface used to add our services to our DI container
addSingleton, addTransient or addScoped <Interface, Class> to create a binding so that anywhere our interface is used for DI, it will resolve to this class specified here.

# AddSingleton, AddTransient or AddScoped

AddSingleton creates an instance when called for the first time, and then uses this created instance every time it is called throughout the application.
AddTransient creates a new instance each time it is requested.
AddScoped creates a new instance between 
scopes but uses the same instance in the same scope.