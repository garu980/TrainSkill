using System;

namespace TrainSkill.CrossCuttingConcerns.DependencyInjection
{
    public interface IContainerBuilder
    {
        IContainerBuilder RegisterModule(IModule module = null);
        IServiceProvider Build();
    }
}
