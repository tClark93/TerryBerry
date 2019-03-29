using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using App.Domain.Entities;

namespace App.Domain.Abstract
{
    public interface IHelloService
    {
        //void Register(Hello hello);
        Task<Hello> GetHelloAsync();
    }
}
