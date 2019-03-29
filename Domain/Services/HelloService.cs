using System;
using App.Domain.Entities;
using App.Domain.Abstract.Repos;
using App.Domain.Abstract.Services;

namespace App.Domain.Services
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
