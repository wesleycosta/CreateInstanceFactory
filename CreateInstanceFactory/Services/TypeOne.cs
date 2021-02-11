using CreateInstanceFactory.Interfaces;
using System;
using System.Threading.Tasks;

namespace CreateInstanceFactory.Services
{
    public class TypeOne : ITypeBase
    {
        public async Task Execute()
        {
            Console.WriteLine("Type One");
            await Task.CompletedTask;
        }
    }
}
