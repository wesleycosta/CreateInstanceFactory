using CreateInstanceFactory.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CreateInstanceFactory.Services
{
    public class ServiceFactory : IServiceFactory
    {
        private readonly ITypeBase _typeBase;
        private readonly IServiceProvider _serviceProvider;

        public ServiceFactory(ITypeBase typeBase,
            IServiceProvider serviceProvider)
        {
            _typeBase = typeBase;
            _serviceProvider = serviceProvider;
        }

        public ITypeBase GetByType(Type type)
        {
            var services = _serviceProvider.GetServices<ITypeBase>();
            return services.FirstOrDefault(service => service.GetType() == type);
        }
    }
}
