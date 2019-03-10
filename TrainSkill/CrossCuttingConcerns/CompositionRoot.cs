using Microsoft.Extensions.DependencyInjection;
using TrainSkill.CrossCuttingConcerns.DependencyInjection;
using TrainSkill.Functions;
using TrainSkill.Services;
using TrainSkill.UseCase.ApplicationStart;
using TrainSkill.UseCase.WherIsMyTrain;

namespace TrainSkill.CrossCuttingConcerns
{
    public class CompositionRoot : Module
    {
        public override void Load(IServiceCollection services)
        {
            //var config = new ConfigurationBuilder()
            //                 .SetBasePath(Directory.GetCurrentDirectory())
            //                 .AddJsonFile("config.json")
            //                 .Build();
            //var github = config.Get<GitHub>("github");
            services.AddTransient<ITrainFunction, TrainFunction>();
            services.AddTransient<ITrainService, TrainService>();
            services.AddTransient<IWhereIsMyTrain, WhereIsMyTrain>();
            services.AddTransient<IApplicationStart, ApplicationStart>();
        }
    }
}
