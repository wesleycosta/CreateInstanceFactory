using CreateInstanceFactory.Interfaces;
using System;
using System.Threading.Tasks;

namespace CreateInstanceFactory.Services
{
    public class TypeThree : ITypeBase
    {
        public async Task Execute()
        {
            Console.WriteLine("Type Three");
            await Task.CompletedTask;
        }
    }
}
