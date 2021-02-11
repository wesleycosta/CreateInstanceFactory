using System;
using System.Threading.Tasks;

namespace CreateInstanceFactory.Interfaces
{
    public interface IServiceFactory
    {
        ITypeBase GetByType(Type type);
    }
}
