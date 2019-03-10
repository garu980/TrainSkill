using Microsoft.Extensions.DependencyInjection;

namespace TrainSkill.CrossCuttingConcerns.DependencyInjection
{
    public class Module : IModule
    {
        public virtual void Load(IServiceCollection services)
        {
            return;
        }
    }
}
