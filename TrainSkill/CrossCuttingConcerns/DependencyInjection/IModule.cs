using Microsoft.Extensions.DependencyInjection;

namespace TrainSkill.CrossCuttingConcerns.DependencyInjection
{
    public interface IModule
    {
        void Load(IServiceCollection services);
    }
}
