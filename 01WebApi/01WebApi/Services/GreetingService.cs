using System;

namespace _01WebApi.Services;

public interface IGreetingService
{
    string Greet();
}

public class GreetingService : IGreetingService
{
    public string Greet()
    {
        return "Hello";
    }
}
