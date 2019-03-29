using System;
using App.Domain.Entities;

namespace App.Domain.Abstract.Repos
{
    public interface IHelloRepo
    {
        void Add(Hello hello);
    }
}
