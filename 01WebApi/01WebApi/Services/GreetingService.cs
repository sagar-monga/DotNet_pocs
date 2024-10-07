using System;
using _01WebApi.Interfaces;

namespace _01WebApi.Services;

public class GreetingService : IGreetingService
{
    public void Greet()
    {
        Console.WriteLine("Hello");
    }
}
