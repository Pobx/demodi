using System;
namespace DemoDI.Services
{
    public class HelloService : IHelloService
    {
        public string SayHi(string Name)
        {
            return $"Hello, {Name}";
        }
    }
}

