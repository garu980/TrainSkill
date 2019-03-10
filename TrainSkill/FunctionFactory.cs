using System;
using TrainSkill.CrossCuttingConcerns.DependencyInjection;
using TrainSkill.Functions;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using Microsoft.Azure.WebJobs.Host;

namespace TrainSkill
{
    public class FunctionFactory : IFunctionFactory
    {
        readonly IServiceProvider container;
        
        public FunctionFactory(IModule module = null)
        {
            container = new ContainerBuilder()
                                  .RegisterModule(module)
                                  .Build();
        }

        public TFunction Create<TFunction>(string name = null)
            where TFunction : IFunction
        {
            var function = container.GetService<TFunction>();
            return function;
        }
    }
}
