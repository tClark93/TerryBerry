using System;
using System.Threading.Tasks;
using App.Domain.Entities;

namespace App.Domain.Abstract.Services
{
    public interface IHelloService
    {
        //void Register(Hello hello);
        Task<Hello> GetHello();
    }
}
