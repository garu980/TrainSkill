using Microsoft.Extensions.DependencyInjection;
using System;

namespace TrainSkill.CrossCuttingConcerns.DependencyInjection
{
    public class ContainerBuilder : IContainerBuilder
    {
        readonly IServiceCollection services;

        public ContainerBuilder()
        {
            services = new ServiceCollection();
        }

        public IServiceProvider Build()
        {
            var provider = this.services.BuildServiceProvider();
            return provider;
        }

        public IContainerBuilder RegisterModule(IModule module = null)
        {
            if(module == null)
            {
                module = new Module();
            }

            module.Load(services);

            return this;
        }
    }
}
