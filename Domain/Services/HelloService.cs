using System;
using Domain.Entities;
using Domain.Abstract.Repos;
using Domain.Abstract.Services;

namespace Domain.Services
{
    public class HelloService : IHelloService
    {
        readonly IHelloRepo _helloRepo;

        public HelloService(IHelloRepo helloRepo)
        {
            _helloRepo = helloRepo;
        }

        public void Register(Hello hello)
        {
            _helloRepo.Add(hello);
        }
    }
}
