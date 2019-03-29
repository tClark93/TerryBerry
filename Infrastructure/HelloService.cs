using System.Threading.Tasks;
using App.Domain.Abstract;
using App.Domain.Entities;

namespace App.Infrastructure
{
    public class HelloService : IHelloService
    {
        public Task<Hello> GetHelloDB()
        {
            var Response = new Hello { Text = "Hello World!" };

            //Console.WriteLine("database");
            return Task.FromResult(Response);
        }

        public async Task<Hello> GetHelloAsync()
        {
            var Response = await GetHelloDB();

            //Console.WriteLine(Response + "async");
            return Response;
        }
    }
}
