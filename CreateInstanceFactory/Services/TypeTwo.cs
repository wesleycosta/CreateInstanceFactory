using CreateInstanceFactory.Interfaces;
using System;
using System.Threading.Tasks;

namespace CreateInstanceFactory.Services
{
    public class TypeTwo : ITypeBase
    {
        public async Task Execute()
        {
            Console.WriteLine("Type Two");
            await Task.CompletedTask;
        }
    }
}
